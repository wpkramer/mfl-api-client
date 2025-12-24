using Mfl.Api.Model.Player;
using System.Text.Json;


namespace Mfl.Api.Client.Tests.DeserializationTests;


public class MflPlayersJsonTests
{
    private static readonly JsonSerializerOptions Options = new()
    {
        PropertyNameCaseInsensitive = true
    };

    #region Test JSON Samples

    private const string MultiplePlayers = @"
        {
            ""players"": {
                ""player"": [
                    {
                        ""id"": ""12345"",
                        ""name"": ""Mahomes, Patrick"",
                        ""position"": ""QB"",
                        ""team"": ""KC""
                    },
                    {
                        ""id"": ""13456"",
                        ""name"": ""Kelce, Travis"",
                        ""position"": ""TE"",
                        ""team"": ""KC"",
                        ""jersey"": ""87"",
                        ""status"": ""R""
                    },
                    {
                        ""id"": ""99999"",
                        ""name"": ""Kansas City Chiefs"",
                        ""position"": ""Def"",
                        ""team"": ""KC""
                    }
                ],
                ""timestamp"": ""1734652800""
            },
            ""version"": ""1.0"",
            ""encoding"": ""utf-8""
        }";

    private const string SinglePlayer = @"
        {
            ""players"": {
                ""player"": {
                    ""id"": ""11111"",
                    ""name"": ""Rookie, Joe"",
                    ""position"": ""RB"",
                    ""team"": ""FA"",
                    ""status"": ""R"",
                    ""birthdate"": ""946684800""
                }
            },
            ""timestamp"": ""1734652800""
        }";

    private const string EmptyPlayers = @"
        {
            ""players"": {
                ""player"": [],
                ""timestamp"": ""1734652800""
            }
        }";

    private const string NullPlayers = @"
        {
            ""players"": null,
            ""version"": ""1.0""
        }";

    private const string DetailedPlayerArray = @"
        {
            ""players"": {
                ""player"": [
                    {
                        ""id"": ""14234"",
                        ""name"": ""Stroud, C.J."",
                        ""position"": ""QB"",
                        ""team"": ""HOU"",
                        ""jersey"": ""7"",
                        ""height"": ""75"",
                        ""weight"": ""218"",
                        ""birthdate"": ""1012348800"",
                        ""college"": ""Ohio State"",
                        ""draft_year"": ""2023"",
                        ""draft_round"": ""1"",
                        ""draft_pick"": ""2"",
                        ""draft_team"": ""HOU"",
                        ""espn_id"": ""4432577"",
                        ""rotowire_id"": ""16384"",
                        ""status"": ""R""
                    }
                ]
            }
        }";

    #endregion

    [Fact]
    public void Deserialize_MultiplePlayers_ParsesCorrectly()
    {
        var result = JsonSerializer.Deserialize<MflPlayersRoot>(MultiplePlayers, Options);

        Assert.NotNull(result);
        Assert.NotNull(result.Players);
        Assert.Equal(3, result.Players.PlayerList.Count);

        var mahomes = result.Players.PlayerList[0];
        Assert.Equal("12345", mahomes.Id);
        Assert.Equal("Mahomes, Patrick", mahomes.Name);
        Assert.Equal("QB", mahomes.Position);
        Assert.Equal("KC", mahomes.Team);
        Assert.False(mahomes.IsRookie);

        var kelce = result.Players.PlayerList[1];
        Assert.Equal(87, kelce.JerseyNumber);
        Assert.True(kelce.IsRookie);

        var def = result.Players.PlayerList[2];
        Assert.True(def.IsTeamUnit);
    }

    [Fact]
    public void Deserialize_SinglePlayer_HandledByConverter()
    {
        var result = JsonSerializer.Deserialize<MflPlayersRoot>(SinglePlayer, Options);

        Assert.NotNull(result);
        Assert.NotNull(result.Players);
        Assert.Single(result.Players.PlayerList);

        var player = result.Players.PlayerList[0];
        Assert.Equal("11111", player.Id);
        Assert.Equal("Rookie, Joe", player.Name);
        Assert.Equal("FA", player.Team);
        Assert.True(player.IsRookie);
        Assert.True(player.IsFreeAgent);
        Assert.Equal(new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero), player.BirthDate);
    }

    [Fact]
    public void Deserialize_EmptyPlayers_ReturnsEmptyList()
    {
        var result = JsonSerializer.Deserialize<MflPlayersRoot>(EmptyPlayers, Options);

        Assert.NotNull(result);
        Assert.NotNull(result.Players);
        Assert.Empty(result.Players.PlayerList);
    }

    [Fact]
    public void Deserialize_NullPlayers_HandlesGracefully()
    {
        var result = JsonSerializer.Deserialize<MflPlayersRoot>(NullPlayers, Options);

        Assert.NotNull(result);
        Assert.Null(result.Players); // Root-level null becomes null object
    }

    [Fact]
    public void Deserialize_DetailedPlayer_ParsesAllFields()
    {
        var result = JsonSerializer.Deserialize<MflPlayersRoot>(DetailedPlayerArray, Options);

        Assert.NotNull(result);
        Assert.Single(result.Players.PlayerList);

        var stroud = result.Players.PlayerList[0];
        Assert.Equal("14234", stroud.Id);
        Assert.Equal("Stroud, C.J.", stroud.Name);
        Assert.Equal("HOU", stroud.Team);
        Assert.Equal(7, stroud.JerseyNumber);
        Assert.Equal(75, stroud.HeightInches);
        Assert.Equal(218, stroud.WeightLbs);
        Assert.Equal("Ohio State", stroud.College);
        Assert.Equal("2023", stroud.DraftYear);
        Assert.Equal("1", stroud.DraftRound);
        Assert.Equal("2", stroud.DraftPick);
        Assert.Equal("4432577", stroud.EspnId);
        Assert.Equal("16384", stroud.RotowireId);
        Assert.True(stroud.IsRookie);
    }
}