using Xunit.Sdk;
using Adp = Mfl.Api.Model.Adp;

namespace Mfl.Api.Client.Tests.ExportTests;

public partial class DraftPrepExportTests : IDisposable
{
    private readonly string _username;
    private readonly string _password;
    private readonly string _leagueId;
    private readonly MflApiClient _client;
    private const int TestSeason = 2025;

    public DraftPrepExportTests()
    {
        _username = Environment.GetEnvironmentVariable("MFL_TEST_USERNAME")
            ?? throw SkipException.ForSkip("No username configured");
        _password = Environment.GetEnvironmentVariable("MFL_TEST_PASSWORD")
            ?? throw SkipException.ForSkip("No password configured");
        _leagueId = Environment.GetEnvironmentVariable("MFL_TEST_LEAGUEID")
            ?? throw SkipException.ForSkip("No leagueid configured");

        _client = new MflApiClient(TestSeason);
        var loginResult = _client.LoginAsync(_username, _password).GetAwaiter().GetResult();
        if (!loginResult.IsSuccess)
        {
            throw SkipException.ForSkip($"Failed to login: {loginResult.Message}");
        }
    }
    [Fact]
    public async Task GetAndFindMyLeagueAsync()
    {
        var leagueResult = await _client.GetMyLeaguesAsync();
        Assert.True(leagueResult.IsSuccess, $"GetMyLeaguesAsync failed: {leagueResult.Message}");
        var myleagues = leagueResult.Value;
        Assert.NotNull(myleagues);
        Assert.NotEmpty(myleagues);
    }

    [Fact]
    public async Task GetLeagueDataAsync()
    {
        // Act
        var leagueResult = await _client.GetLeagueAsync(_leagueId);
        // Assert
        Assert.True(leagueResult.IsSuccess, $"GetLeagueAsync failed: {leagueResult.Message}");
        Assert.NotNull(leagueResult.Value);
        Assert.Equal("Kamikazees", leagueResult.Value.Name);
        Assert.Equal("10", leagueResult.Value.Franchises.Count);
        Assert.Equal(10, leagueResult.Value.Franchises.FranchiseList.Count);

    }

    [Fact]
    public async Task GetScheduleDataAsync()
    {
        // Act
        var scheduleResult = await _client.GetScheduleAsync(_leagueId);
        // Assert
        Assert.True(scheduleResult.IsSuccess, $"GetScheduleAsync failed: {scheduleResult.Message}");
        Assert.NotNull(scheduleResult.Value);

    }

    [Fact]
    public async Task GetPlayerUpdates()
    {
        // Act
        var playersResult = await _client.GetPlayerUpdatesAsync(since: DateTime.UtcNow.AddDays(-7), _leagueId);
        // Assert
        Assert.True(playersResult.IsSuccess, $"GetPlayersAsync failed: {playersResult.Message}");
        Assert.NotNull(playersResult.Value);
        Assert.NotEmpty(playersResult.Value);
        var playersList = playersResult.Value;
        Assert.True(playersList[0].Name.Length > 0, "First player's name is empty");
    }

    [Fact]
    public async Task GetAverageDraftPosition()
    {
        // Act
        var adpResult = await _client.GetAdpAsync(Adp.PeriodType.ALL, Adp.FranchiseCountType.ExactlyTen, Adp.ScoringType.NotPPR, Adp.KeeperStatus.N, Adp.MockDraftType.Real, 20);
        // Assert
        Assert.True(adpResult.IsSuccess, $"GetAdpAsync failed: {adpResult.Message}");
        Assert.NotNull(adpResult.Value);
        var adpList = adpResult.Value;
        Assert.NotEmpty(adpList);
        var adpPlayer = adpList[0];
        Assert.NotNull(adpPlayer);
        string sAveragePick = adpList[0].AveragePick;
        Assert.True(double.TryParse(sAveragePick, out _), "Average pick is not a valid number");

    }

    [Theory]
    [InlineData(0)]
    [InlineData(2)]
    public async Task GetNFLSchedule(int week)
    {
        var nflScheduleResult = await _client.GetNflScheduleAsync(week);
        Assert.True(nflScheduleResult.IsSuccess, $"GetNflScheduleAsync failed: {nflScheduleResult.Message}");
        Assert.NotNull(nflScheduleResult.Value);
        var scheduleList = nflScheduleResult.Value;
        Assert.NotEmpty(scheduleList);
        if(week == 0)
        {
            // Full season schedule
            Assert.True(scheduleList.Count > 17,"expected full season");
        }
        else
        {
            // Single week schedule
            Assert.True(scheduleList.Count == 1, $"Expected 1 week, got {scheduleList.Count}");
        }
        Assert.True(scheduleList[0].Matchups[0].Teams.Count == 2, "Expected 2 teams in first matchup");
    }

    public void Dispose()
    {
       _client.Dispose();
    }
}
