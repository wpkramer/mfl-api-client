
using Windows.Media.Protection.PlayReady;
using Xunit.Sdk;

namespace Mfl.Api.Client.Tests.ExportTests;

public class MflApiKeyExportTests
{
    private const int TestSeason = 2025;
    private readonly string _apiKey;
    private readonly string _leagueId;
    public MflApiKeyExportTests()
    {
        _apiKey = Environment.GetEnvironmentVariable("MFL_TEST_APIKEY")
            ?? throw SkipException.ForSkip("No APIKEY configured");
        _leagueId = Environment.GetEnvironmentVariable("MFL_TEST_LEAGUEID")
            ?? throw SkipException.ForSkip("No leagueid configured");
    }

    [Fact]
    public async Task GetLeagueDataWithKeyAsync()
    {
        //// Arrange
        using var client = new MflApiClient(TestSeason);
        client.ApiKey = _apiKey; // Set API key for authentication

        // Act
        var leagueResult = await client.GetLeagueAsync(_leagueId);
        // Assert
        Assert.True(leagueResult.IsSuccess, $"GetLeagueAsync failed: {leagueResult.Message}");
        Assert.NotNull(leagueResult.Value);
    }

    [Fact]
    public async Task GetPlayerUpdatesWithKey()
    {
        using var client = new MflApiClient(TestSeason);
        client.ApiKey = _apiKey;
        // Act
        var playersResult = await client.GetPlayerUpdatesAsync(since: DateTime.UtcNow.AddDays(-7), _leagueId);
        // Assert
        Assert.True(playersResult.IsSuccess, $"GetPlayersAsync failed: {playersResult.Message}");
        Assert.NotNull(playersResult.Value);
        Assert.NotEmpty(playersResult.Value);
        var playersList = playersResult.Value;
        Assert.True(playersList[0].Name.Length > 0, "First player's name is empty");
    }



    [Fact]
    public async Task GetScheduleDataWithKeyAsync()
    {
        //// Arrange
        using var client = new MflApiClient(TestSeason);
        client.ApiKey = _apiKey; // Set API key for authentication

        // Act
        var scheduleResult = await client.GetScheduleAsync(_leagueId);
        // Assert
        Assert.True(scheduleResult.IsSuccess, $"GetLeagueAsync failed: {scheduleResult.Message}");
        Assert.NotNull(scheduleResult.Value);
    }




}
