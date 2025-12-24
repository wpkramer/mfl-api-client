using Mfl.Api.Common;
using Mfl.Api.Model.NFL;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using mflAdp = Mfl.Api.Model.Adp;
using mflLeague = Mfl.Api.Model.League;
using mflPlayer = Mfl.Api.Model.Player;
using mflSched = Mfl.Api.Model.MflSchedule;
using myLeague = Mfl.Api.Model.MyLeague;
using NFLSched = Mfl.Api.Model.NFL;


namespace Mfl.Api;

/// <summary>
/// Provides a client for interacting with the MyFantasyLeague (MFL) REST API.
/// </summary>
public sealed partial class MflApiClient : IDisposable
{
    #region Private Data Members
    private readonly HttpClient _httpClient; // Reused for the lifetime of the MflApiClient
    private readonly int _nflSeason; // NFL season year for API requests
    private bool _disposed; // Tracks whether the client has been disposed
    private readonly JsonSerializerOptions _jsonSerializerOptions; // JSON serialization options
    private string? _apiKey; // API key for authentication when not logging in with username/password
    private string? _cookieValue; // MFL_USER_ID cookie value for authenticated requests
    #endregion


    #region Construction and Initialization

    /// <summary>
    /// Creates a new MFL API client for a specific NFL season.
    /// </summary>
    /// <param name="nflSeason">The NFL season year (e.g., 2025). Required.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if nflSeason is not a reasonable year.</exception>
    public MflApiClient(int nflSeason, HttpMessageHandler? handler = null)
    {
        if (nflSeason < 2000 || nflSeason > DateTime.UtcNow.Year + 1)
            throw new ArgumentOutOfRangeException(nameof(nflSeason), "Season year must be reasonable (2000 or later, not far in the future).");

        _disposed = false;
        _nflSeason = nflSeason;
        
        _jsonSerializerOptions = new()
        {
            PropertyNameCaseInsensitive = true,
        };
        var httpHandler = handler ?? new HttpClientHandler
        {
            AllowAutoRedirect = true
        };
        _httpClient = new HttpClient(httpHandler);



        // Initial BaseAddress and base parameters without APIKEY
        UpdateBaseAddress();
    }

    /// <summary>
    /// Updates the base address and export URL for API requests based on the current NFL season and API key.
    /// </summary>
    /// <remarks>Call this method after changing the NFL season or API key to ensure that subsequent API
    /// requests use the correct base address and authentication parameters. The BaseAdress should end with
    /// a '/' mark. The HttpClient will lop off anything afer the last '/' mark.  The _urlBaseParameters is
    /// used to add parameters to the url.</remarks>
    private void UpdateBaseAddress()
    {
        string baseUrl = $"https://api.myfantasyleague.com/{_nflSeason}/";

        _httpClient.BaseAddress = new Uri(baseUrl);
    }

    #endregion


    #region calls to MFL HTTP service

    /// <summary>
    /// Http Get with global rate limiter ensuring no more than one request per second across all clients.
    /// </summary>
    internal async Task<HttpResponseMessage> SendThrottledGetAsync(string requestUri)
    {

        return await RateLimiter.Instance.ExecuteAsync(async () =>
            await _httpClient.GetAsync(requestUri));
    }

    /// <summary>
    /// Http Post with global rate limiter ensuring no more than one request per second across all clients.
    /// </summary>
    internal async Task<HttpResponseMessage> SendThrottledPostAsync(string requestUri, HttpContent content)
    {
        return await RateLimiter.Instance.ExecuteAsync(async () =>
            await _httpClient.PostAsync(requestUri, content));
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the constant API key obtained from the MFL Help page.
    /// When set, this key is passed as the APIKEY query parameter on every export request
    /// (which takes precedence over any MFL_USER_ID cookie, per MFL documentation).
    /// Setting this immediately applies the key to future requests.
    /// </summary>
    public string? ApiKey
    {
        get => _apiKey;
        set
        {
            if (value == _apiKey)
                return;

            if (string.IsNullOrWhiteSpace(value))
            {
                _apiKey = null;
            }
            else
            {
                _apiKey = value.Trim();
            }

        }
    }
    #endregion

    #region Self Validation Methods

    /// <summary>
    /// Throws an exception if the current instance has been disposed.
    /// </summary>
    /// <remarks>Call this method before performing operations that require the instance to be valid. This
    /// helps ensure that methods are not called on a disposed object, which would otherwise result in undefined
    /// behavior.</remarks>
    /// <exception cref="ObjectDisposedException"Thrown if the instance has been disposed.</exception>
    private void ThrowIfDisposed()
    {
        ObjectDisposedException.ThrowIf(_disposed, nameof(MflApiClient));
    }


    /// <summary>
    /// Throws an exception if the client has not been authenticated with an API key or a valid session cookie.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown if the client is not authenticated. Call the login method or provide an API key before invoking
    /// operations that require authentication.</exception>
    private void ThrowIfNotValidated()
    {
        if(_apiKey != null)
            return;
        if (_httpClient.DefaultRequestHeaders.Contains("Cookie"))
            return;
        throw new InvalidOperationException("Client is not authenticated. Please login first.");
    }

    /// <summary>
    /// Gets a value indicating whether the current user is authenticated.
    /// The <exception cref="InvalidOperationException">Thrown if not authenticated (no ApiKey or login cookie)</exception>
    /// when accessing methods that require authentication.
    /// </summary>
    public bool IsAuthenticated => _apiKey != null || _cookieValue != null;

    #endregion

    #region Login Methods 

    /// <summary>
    /// Parses the login response XML and returns the result.
    /// </summary>
    /// <param name="xmlContent">The raw XML response body from the login endpoint.</param>
    /// <returns>A Result containing the MFL_USER_ID (cookie_value) on success, or an error message.</returns>
    internal static Result<string> ParseLogin(string xmlContent)
    {
        if (string.IsNullOrWhiteSpace(xmlContent))
        {
            return Result<string>.Failure("Login response body was empty.");
        }

        XDocument doc;
        try
        {
            doc = XDocument.Parse(xmlContent);
        }
        catch (Exception ex)
        {
            return Result<string>.Failure("Failed to parse XML response from login.", ex);
        }

        var root = doc.Root;
        if (root == null)
        {
            return Result<string>.Failure("Invalid XML: no root element.");
        }

        if (root.Name.LocalName == "error")
        {
            // Prefer the 'status' attribute if present, otherwise use element value
            string msg = root.Attribute("status")?.Value
                         ?? root.Value?.Trim()
                         ?? "Login failed";
            if (string.IsNullOrWhiteSpace(msg))
                msg = "Login failed";
            return Result<string>.Failure(msg);
        }

        if (root.Name.LocalName != "status")
        {
            return Result<string>.Failure("Unexpected root element in login response.");
        }

        // Success: Extract from <status> root element
        // Primary: cookie_value attribute (modern format)
        var cookieValueAttr = root.Attribute("cookie_value");
        if (cookieValueAttr != null && !string.IsNullOrEmpty(cookieValueAttr.Value))
        {
            return Result<string>.Success(cookieValueAttr.Value.Trim());
        }

        // Fallback: MFL_USER_ID attribute (legacy format)
        var legacyAttr = root.Attribute("MFL_USER_ID");
        if (legacyAttr != null && !string.IsNullOrEmpty(legacyAttr.Value))
        {
            return Result<string>.Success(legacyAttr.Value.Trim());
        }

        return Result<string>.Failure("No cookie_value or MFL_USER_ID found in login response.");
    }


    /// <summary>
    /// Performs username/password authentication against the MFL login endpoint using HTTP POST.
    /// On success, sets the MFL_USER_ID cookie header for subsequent authenticated requests.
    /// Note: If ApiKey is set, it will take precedence over the cookie on all calls.
    /// </summary>
    /// <param name="username">MFL username.</param>
    /// <param name="password">MFL password.</param>
    /// <returns>A non-generic Result indicating success or failure.</returns>
    public async Task<Result> LoginAsync(string username, string password)
    {
        try
        {
            ThrowIfDisposed();

            ArgumentNullException.ThrowIfNull(username);
            ArgumentNullException.ThrowIfNull(password);

            var loginData = new FormUrlEncodedContent(
            [
                new KeyValuePair<string, string>("USERNAME", username),
            new KeyValuePair<string, string>("PASSWORD", password),
            new KeyValuePair<string, string>("XML", "1")
            ]);

            HttpResponseMessage response = await SendThrottledPostAsync("login", loginData);
            string content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return Result.Failure($"Login failed with status {response.StatusCode}. Body: {content}");
            }

            var parseResult = ParseLogin(content);

            if (!parseResult.IsSuccess)
            {
                return Result.Failure(parseResult.Message ?? string.Empty);
            }

            string cookieValue = parseResult.Value!;
            AssignCookieForFutureRequests(cookieValue);

            return Result.Success();
        }
        catch (ObjectDisposedException ex)
        {
            return Result.Failure("MflApiClient has been disposed", ex);
        }
        catch (ArgumentNullException ex)
        {
            return Result.Failure("Username or password cannot be null.", ex);
        }
        catch (Exception ex)
        {
            return Result.Failure("Unexpected error during login.", ex);
        }
    }

    private void AssignCookieForFutureRequests(string cookieValue)
    {
        _cookieValue = cookieValue;
        _httpClient.DefaultRequestHeaders.Remove("Cookie");
        _httpClient.DefaultRequestHeaders.Add("Cookie", $"MFL_USER_ID={cookieValue}");
    }


    #endregion

    #region Export Data For Draft / Cheat Sheet Preparation

    private string GetExportUrl(string parameters)
    {
        string apiKeyParam = !string.IsNullOrWhiteSpace(_apiKey)
            ? $"APIKEY={Uri.EscapeDataString(_apiKey)}&"
            : "";
        return $"export?{apiKeyParam}{parameters}";
    }
   

    /// <summary>
    /// Asynchronously retrieves league information for the specified league identifier.
    /// </summary>
    public async Task<Result<mflLeague.League>> GetLeagueAsync(string leagueId)
    {

        try
        {
            ThrowIfDisposed();
            ThrowIfNotValidated();

            string requestUri = GetExportUrl($"TYPE=league&L={leagueId}&JSON=1");
            HttpResponseMessage response = await SendThrottledGetAsync(requestUri);
            string responseBody = await response.Content.ReadAsStringAsync();

            var root = JsonSerializer.Deserialize<mflLeague.MflLeagueRoot>(responseBody, _jsonSerializerOptions);
            if (root == null)
            {
                return Result<mflLeague.League>.Failure("Failed to parse league data from response.");
            }

            return Result<mflLeague.League>.Success(root.League);

        }
        catch (Exception ex)
        {
            return Result<mflLeague.League>.Failure("Error fetching league data.", ex);
        }
    }

    /// <summary>
    /// Asynchronously retrieves the schedule for the specified league.
    /// </summary>
    /// <param name="leagueId">The unique identifier of the league for which to retrieve the schedule. Cannot be null or empty.</param>
    public async Task<Result<mflSched.Schedule>> GetScheduleAsync(string leagueId)
    {
       
        try
        {
            ThrowIfDisposed();
            ThrowIfNotValidated();

            string requestUri = GetExportUrl($"TYPE=schedule&L={leagueId}&JSON=1");
            HttpResponseMessage response = await SendThrottledGetAsync(requestUri);

            string responseBody = await response.Content.ReadAsStringAsync();

            var root = JsonSerializer.Deserialize<mflSched.MflScheduleRoot>(responseBody, _jsonSerializerOptions);
            if (root == null)
            {
                return Result<mflSched.Schedule>.Failure("Failed to parse league data from response.");
            }

            return Result<mflSched.Schedule>.Success(root.Schedule);

        }
        catch (Exception ex)
        {
            return Result<mflSched.Schedule>.Failure("Error fetching schedule data.", ex);
        }
    }

    /// <summary>
    /// Asynchronously retrieves the list of leagues associated with the current user.
    /// </summary>
    public async Task<Result<List<myLeague.MyLeague>>> GetMyLeaguesAsync()
    {
        try
        {
            ThrowIfDisposed();
            ThrowIfNotValidated();
            string requestUri = GetExportUrl($"TYPE=myleagues&YEAR{_nflSeason}&FRANCHISE_NAMES=1&JSON=1");
            HttpResponseMessage response = await SendThrottledGetAsync(requestUri);
            string responseBody = await response.Content.ReadAsStringAsync();
            var root = JsonSerializer.Deserialize<myLeague.MflMyLeaguesRoot>(responseBody, _jsonSerializerOptions);
            if (root == null)
            {
                return Result<List<myLeague.MyLeague>>.Failure("Failed to parse my leagues data from response.");
            }
            return Result<List<myLeague.MyLeague>>.Success(root.Leagues.LeagueList);
        }
        catch (Exception ex)
        {
            return Result<List<myLeague.MyLeague>>.Failure("Error fetching my leagues data.", ex);
        }
    }
    /// <summary>
    /// Retrieves a list of player updates from the specified league that have occurred since the given date and time.
    /// </summary>
    /// <param name="since">The point in time, in UTC, from which to retrieve player updates. Only updates occurring after this time are
    /// returned.</param>
    /// <param name="leagueId">The unique identifier of the league.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a Result object with a list of
    /// updated players. If no updates are found, the list will be empty. If an error occurs, the Result will indicate
    /// failure and include an error message.</returns>
    public async Task<Result<List<mflPlayer.MflPlayer>>> GetPlayerUpdatesAsync(DateTime since, string leagueId)
    {
        try
        {
            ThrowIfDisposed();
            ThrowIfNotValidated();
            int unixTimestamp = (int)(since.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds;
            string requestUri = GetExportUrl($"TYPE=players&L={leagueId}&APIKEY=&DETAILS=1&SINCE={unixTimestamp}&JSON=1");
            HttpResponseMessage response = await SendThrottledGetAsync(requestUri);
            string responseBody = await response.Content.ReadAsStringAsync();
            var root = JsonSerializer.Deserialize<mflPlayer.MflPlayersRoot>(responseBody, _jsonSerializerOptions);
            if (root == null)
            {
                return Result<List<mflPlayer.MflPlayer>>.Failure("Failed to parse player data from response.");
            }
            return Result<List<mflPlayer.MflPlayer>>.Success(root.Players.PlayerList);
        }
        catch (Exception ex)
        {
            return Result<List<mflPlayer.MflPlayer>>.Failure("Error fetching player data.", ex);
        }
    }

    /// <summary>
    /// Asynchronously retrieves average draft position (ADP) player data based on the specified league and draft
    /// settings.
    /// </summary>
    /// <remarks>This method returns only players who meet the specified cutoff for draft appearances. The
    /// returned data reflects the selected league configuration and scoring settings.</remarks>
    /// <param name="periodType">Filter for drafts that started after the specified period</param>
    /// <param name="franchiseCountType">Filter draft data to leagues with this number of franchises</param>
    /// <param name="scoringType">The scoring system used by the drafting league.</param>
    /// <param name="keeperStatus">Draft was for keeper, rookie, or redraft.</param>
    /// <param name="mockDraftType">Draft was a mock, live, or both</param>
    /// <param name="cutoff">	Only returns data for players selected in at least this percentage of drafts. So if you pass 10,
    /// it means that players selected in less than 10% of all drafts will not be returned. Note that 
    /// if the value is less than 5, the results may be unpredicatble.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a Result object with a list of
    /// players and their ADP data. If the operation fails, the Result will contain error information.</returns>
    public async Task<Result<List<mflAdp.MflAdpPlayer>>> GetAdpAsync(
        mflAdp.PeriodType periodType
        , mflAdp.FranchiseCountType franchiseCountType
        , mflAdp.ScoringType scoringType
        , mflAdp.KeeperStatus keeperStatus
        , mflAdp.MockDraftType mockDraftType
        , int cutoff)
    {
        try
        {
            ThrowIfDisposed();
            ThrowIfNotValidated();
            string requestUri = GetExportUrl($"TYPE=adp&PERIOD={periodType}&FCOUNT={(int)franchiseCountType}&ISPPR={(int)scoringType}&ISKEEPER={keeperStatus}&IS_MOCK={(int)mockDraftType}&CUTOFF={cutoff}&DETAILS=0&JSON=1");
            HttpResponseMessage response = await SendThrottledGetAsync(requestUri);
            string responseBody = await response.Content.ReadAsStringAsync();
            var root = JsonSerializer.Deserialize<mflAdp.MflAdpRoot>(responseBody, _jsonSerializerOptions);
            if (root == null)
            {
                return Result<List<mflAdp.MflAdpPlayer>>.Failure("Failed to parse ADP data from response.");
            }
            return Result<List<mflAdp.MflAdpPlayer>>.Success(root.Adp.PlayerList);
        }
        catch (Exception ex)
        {
            return Result<List<mflAdp.MflAdpPlayer>>.Failure("Error fetching ADP data.", ex);
        }
    }
    /*
        public async Task<Result<List<NFLSched.NflSchedule>>> GetNflScheduleAsync(int week = 0)
        {
            try
            {
                ThrowIfDisposed();
                // Public endpoint — no auth needed
                string weekParam;
                if(week > 0)
                {
                    weekParam = $"{week}";
                    string requestWeekUri = $"export?TYPE=nflSchedule&W={weekParam}&JSON=1";
                    HttpResponseMessage weekResponse = await SendThrottledGetAsync(requestWeekUri);
                    string weekbody = await weekResponse.Content.ReadAsStringAsync();
                    var weekroot = JsonSerializer.Deserialize<NFLSched.NFLOneWeekRoot>(weekbody, _jsonSerializerOptions);
                    if (weekroot == null) {
                        return Result<List<NFLSched.NflSchedule>>.Failure("Failed to parse NFL schedule.");
                    }
                    List<NFLSched.NflSchedule> weekList =
                    [
                        weekroot.NflSchedule
                    ];
                    return Result<List<NFLSched.NflSchedule>>.Success(weekList);
                }

                string requestUri = $"export?TYPE=nflSchedule&W=ALL&JSON=1";
                HttpResponseMessage response = await SendThrottledGetAsync(requestUri);
                string body = await response.Content.ReadAsStringAsync();
                var root = JsonSerializer.Deserialize<NFLSched.NFLAllWeeksRoot>(body, _jsonSerializerOptions);
                return root == null
                    ? Result<List<NFLSched.NflSchedule>>.Failure("Failed to parse NFL schedule.")
                    : Result<List<NFLSched.NflSchedule>>.Success(root.FullNflSchedule.NflScheduleWeeks);
            }
            catch (Exception ex)
            {
                return Result<List<NFLSched.NflSchedule>>.Failure("Error fetching NFL schedule.", ex);
            }
        }
    */

    /// <summary>
    /// Asynchronously retrieves the NFL schedule.
    /// </summary>
    /// <param name="week">The specific week number to retrieve (1-18). If 0 or omitted, returns the full season schedule.</param>
    /// <returns>A Result containing a list of weekly schedules on success.</returns>
    public async Task<Result<List<NFLSched.NflSchedule>>> GetNflScheduleAsync(int week = 0)
    {
        try
        {
            ThrowIfDisposed();

            string requestUri;
            if (week > 0)
            {
                // Single week request
                requestUri = $"export?TYPE=nflSchedule&W={week}&JSON=1";
            }
            else
            {
                // Full season request
                requestUri = "export?TYPE=nflSchedule&W=ALL&JSON=1";
            }

            HttpResponseMessage response = await SendThrottledGetAsync(requestUri);
            if (!response.IsSuccessStatusCode)
            {
                return Result<List<NFLSched.NflSchedule>>.Failure(
                    $"Failed to fetch NFL schedule: {response.StatusCode}");
            }

            string body = await response.Content.ReadAsStringAsync();

            if (week > 0)
            {
                var weekRoot = JsonSerializer.Deserialize<NFLSched.NFLOneWeekRoot>(body, _jsonSerializerOptions);
                if (weekRoot?.NflSchedule == null)
                {
                    return Result<List<NFLSched.NflSchedule>>.Failure("Failed to parse single-week NFL schedule.");
                }

                return Result<List<NFLSched.NflSchedule>>.Success([weekRoot.NflSchedule]);
            }
            else
            {
                var fullRoot = JsonSerializer.Deserialize<NFLSched.NFLAllWeeksRoot>(body, _jsonSerializerOptions);
                if (fullRoot?.FullNflSchedule?.NflScheduleWeeks == null)
                {
                    return Result<List<NFLSched.NflSchedule>>.Failure("Failed to parse full NFL schedule.");
                }

                return Result<List<NFLSched.NflSchedule>>.Success(fullRoot.FullNflSchedule.NflScheduleWeeks);
            }
        }
        catch (Exception ex)
        {
            return Result<List<NFLSched.NflSchedule>>.Failure("Error fetching NFL schedule.", ex);
        }
    }

    #endregion

    public void Dispose()
    {
        if (_disposed)
            return;

        _httpClient.Dispose();
        _disposed = true;
    }
}