using Mfl.Api.Model.MyLeague;
using System.Text.Json;

namespace Mfl.Api.Client.Tests.DeserializationTests;

public class MflMyLeagueJsonTests
{
    public const string SingleLeague = @"
    {
        ""leagues"": {
            ""league"": {
                ""name"": ""Knights"",
                ""franchise_name"": ""The Kid"",
                ""franchise_id"": ""0002"",
                ""url"": ""https://www44.myfantasyleague.com/2025/home/99999"",
                ""league_id"": ""99991""
            }
        },
        ""version"": ""1.0"",
        ""encoding"": ""utf-8""
    }";

    // Multiple leagues (simulated user in 3 leagues)
    public const string MultipleLeagues = @"
    {
        ""leagues"": {
            ""league"": [
                {
                    ""name"": ""Knights"",
                    ""franchise_name"": ""The Kid"",
                    ""franchise_id"": ""0002"",
                    ""url"": ""https://www44.myfantasyleague.com/2025/home/99999"",
                    ""league_id"": ""99991""
                },
                {
                    ""name"": ""Dynasty Warriors"",
                    ""franchise_name"": ""The Commissioner"",
                    ""franchise_id"": ""0001"",
                    ""url"": ""https://www45.myfantasyleague.com/2025/home/99999"",
                    ""league_id"": ""99992""
                },
                {
                    ""name"": ""Old School Redraft"",
                    ""franchise_name"": ""The Kid"",
                    ""franchise_id"": ""0005"",
                    ""url"": ""https://www41.myfantasyleague.com/2025/home/99999"",
                    ""league_id"": ""99993""
                }
            ]
        },
        ""version"": ""1.0"",
        ""encoding"": ""utf-8""
    }";

    // Edge case: No leagues (possible if not logged in correctly)
    public const string NoLeagues = @"
    {
        ""leagues"": {
            ""league"": []
        },
        ""version"": ""1.0"",
        ""encoding"": ""utf-8""
    }";


    [Theory]
    [InlineData(MflMyLeagueJsonTests.SingleLeague, 1)]
    [InlineData(MflMyLeagueJsonTests.MultipleLeagues, 3)]
    [InlineData(MflMyLeagueJsonTests.NoLeagues, 0)]
    public void ParseMyLeagues_ReturnsCorrectCount(string json, int expectedCount)
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        var result = JsonSerializer.Deserialize<MflMyLeaguesRoot>(json, options);
        Assert.NotNull(result);
        Assert.True(expectedCount == result.Leagues.LeagueList.Count);
    }

    [Fact]
    public void ParseSingleLeague_ValidatesProperties()
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var result = JsonSerializer.Deserialize<MflMyLeaguesRoot>(MflMyLeagueJsonTests.SingleLeague, options);
        Assert.NotNull(result);
        Assert.Single(result.Leagues.LeagueList);
        var league = result.Leagues.LeagueList[0];
        Assert.Equal("Knights", league.Name);
        Assert.Equal("The Kid", league.FranchiseName);
        Assert.Equal("0002", league.FranchiseId);
        Assert.Equal("https://www44.myfantasyleague.com/2025/home/99999", league.Url);
        Assert.Equal("99991", league.LeagueId);
        Assert.Equal("www44.myfantasyleague.com", league.BaseHost);
    }

    [Fact]
    public void ParseMultipleLeagues_ValidatesProperties()
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var result = JsonSerializer.Deserialize<MflMyLeaguesRoot>(MflMyLeagueJsonTests.MultipleLeagues, options);
        Assert.NotNull(result);
        Assert.Equal(3, result.Leagues.LeagueList.Count);
        var league1 = result.Leagues.LeagueList[0];
        Assert.Equal("Knights", league1.Name);
        Assert.Equal("The Kid", league1.FranchiseName);
        Assert.Equal("0002", league1.FranchiseId);
        Assert.Equal("https://www44.myfantasyleague.com/2025/home/99999", league1.Url);
        Assert.Equal("99991", league1.LeagueId);
        var league2 = result.Leagues.LeagueList[1];
        Assert.Equal("Dynasty Warriors", league2.Name);
        Assert.Equal("The Commissioner", league2.FranchiseName);
        Assert.Equal("0001", league2.FranchiseId);
        Assert.Equal("https://www45.myfantasyleague.com/2025/home/99999", league2.Url);
        Assert.Equal("99992", league2.LeagueId);
        var league3 = result.Leagues.LeagueList[2];
        Assert.Equal("Old School Redraft", league3.Name);
        Assert.Equal("The Kid", league3.FranchiseName);
        Assert.Equal("0005", league3.FranchiseId);
        Assert.Equal("https://www41.myfantasyleague.com/2025/home/99999", league3.Url);
        Assert.Equal("99993", league3.LeagueId);
    }

    [Fact]
    public void ParseNoLeagues_ResultsInEmptyList()
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var result = JsonSerializer.Deserialize<MflMyLeaguesRoot>(MflMyLeagueJsonTests.NoLeagues, options);
        Assert.NotNull(result);
        Assert.NotNull(result.Leagues);
        Assert.Empty(result.Leagues.LeagueList);
    }
}
