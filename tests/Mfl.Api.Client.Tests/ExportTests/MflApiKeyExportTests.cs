
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
