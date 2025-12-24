
using Mfl.Api.Model.Adp;
using System.Text.Json;

namespace Mfl.Api.Client.Tests.DeserializationTests;


public class MflAdpJsonTests
{
    private static readonly JsonSerializerOptions Options = new()
    {
        PropertyNameCaseInsensitive = true
    };


    private const string AdpNoResultsJson = @"{
            ""encoding"": ""utf-8"",
            ""version"": ""1.0"",
            ""adp"": {
                ""totalPicks"": ""0"",
                ""timestamp"": ""1766347982"",
                ""totalDrafts"": ""0""
            }
        }";

    private const string AdpSingleResultJson = @"
    {
      ""encoding"": ""utf-8"",
      ""version"": ""1.0"",
      ""adp"": {
        ""timestamp"": ""1766403521"",
        ""totalPicks"": ""453"",
        ""totalDrafts"": ""202"",
        ""player"": {
          ""id"": ""15281"",
          ""averagePick"": ""3.27"",
          ""minPick"": ""1"",
          ""maxPick"": ""10"",
          ""rank"": ""1"",
          ""draftSelPct"": ""95"",
          ""draftsSelectedIn"": ""192""
        }
      }
    }";

    private const string AdpMultipleResultJson = @"
    {
      ""encoding"": ""utf-8"",
      ""adp"": {
        ""timestamp"": ""1766403521"",
        ""totalPicks"": ""453"",
        ""totalDrafts"": ""202"",
        ""player"": [
          {
            ""averagePick"": ""3.27"",
            ""minPick"": ""1"",
            ""maxPick"": ""10"",
            ""rank"": ""1"",
            ""draftSelPct"": ""95"",
            ""draftsSelectedIn"": ""192"",
            ""id"": ""15281""
          },
          {
            ""averagePick"": ""3.71"",
            ""minPick"": ""1"",
            ""maxPick"": ""12"",
            ""rank"": ""2"",
            ""draftSelPct"": ""97"",
            ""draftsSelectedIn"": ""197"",
            ""id"": ""13604""
          },
          {
            ""averagePick"": ""3.86"",
            ""minPick"": ""1"",
            ""maxPick"": ""11"",
            ""rank"": ""3"",
            ""draftSelPct"": ""97"",
            ""draftsSelectedIn"": ""197"",
            ""id"": ""16161""
          },
          {
            ""averagePick"": ""4.99"",
            ""minPick"": ""1"",
            ""maxPick"": ""22"",
            ""rank"": ""4"",
            ""draftSelPct"": ""98"",
            ""draftsSelectedIn"": ""198"",
            ""id"": ""16162""
          },
          {
            ""averagePick"": ""5.18"",
            ""minPick"": ""1"",
            ""maxPick"": ""11"",
            ""rank"": ""5"",
            ""draftSelPct"": ""94"",
            ""draftsSelectedIn"": ""191"",
            ""id"": ""13589""
          }
        ]
      },
      ""version"": ""1.0""
    }";


    [Fact]
    public void Deserialize_NoResultsJson_ReturnsEmptyPlayerList()
    {
        var result = JsonSerializer.Deserialize<MflAdpRoot>(AdpNoResultsJson, Options);

        Assert.NotNull(result);
        Assert.Equal("1.0", result.Version);
        Assert.Equal("utf-8", result.Encoding);

        Assert.NotNull(result.Adp);
        Assert.Equal("0", result.Adp.TotalDrafts);
        Assert.Equal("0", result.Adp.TotalPicks);
        Assert.Empty(result.Adp.PlayerList);
    }


    [Fact]
    public void Deserialize_MultipleResultJson_ParsesFivePlayersCorrectly()
    {
        var result = JsonSerializer.Deserialize<MflAdpRoot>(AdpMultipleResultJson, Options);

        Assert.NotNull(result);
        Assert.NotNull(result.Adp);
        Assert.Equal("202", result.Adp.TotalDrafts);
        Assert.Equal("453", result.Adp.TotalPicks);
        Assert.Equal(5, result.Adp.PlayerList.Count);
    }

    [Fact]
    public void Deserialize_MultipleResultJson_FirstPlayerIsRank1()
    {
        var result = JsonSerializer.Deserialize<MflAdpRoot>(AdpMultipleResultJson, Options);
        Assert.NotNull(result);
        var firstPlayer = result.Adp.PlayerList[0];

        Assert.Equal("15281", firstPlayer.Id);
        Assert.Equal("1", firstPlayer.Rank);
        Assert.Equal("3.27", firstPlayer.AveragePick);
        Assert.Equal(3.27, firstPlayer.AdpValue, 0.001);
        Assert.Equal(1, firstPlayer.MinPickValue);
        Assert.Equal(10, firstPlayer.MaxPickValue);
        Assert.Equal(95, firstPlayer.SelectionPercentage);
        Assert.Equal(192, firstPlayer.DraftCount);
        Assert.Equal(1, firstPlayer.RankValue);
    }

    [Fact]
    public void Deserialize_MultipleResultJson_LastPlayerIsRank5()
    {
        var result = JsonSerializer.Deserialize<MflAdpRoot>(AdpMultipleResultJson, Options);
        Assert.NotNull(result);
        var lastPlayer = result.Adp.PlayerList[4];

        Assert.Equal("13589", lastPlayer.Id);
        Assert.Equal("5", lastPlayer.Rank);
        Assert.Equal("5.18", lastPlayer.AveragePick);
        Assert.Equal(5.18, lastPlayer.AdpValue, 0.001);
        Assert.Equal(1, lastPlayer.MinPickValue);
        Assert.Equal(11, lastPlayer.MaxPickValue);
        Assert.Equal(94, lastPlayer.SelectionPercentage);
        Assert.Equal(191, lastPlayer.DraftCount);
        Assert.Equal(5, lastPlayer.RankValue);
    }

    [Fact]
    public void Deserialize_MultipleResultJson_ConveniencePropertiesWorkCorrectly()
    {
        var result = JsonSerializer.Deserialize<MflAdpRoot>(AdpMultipleResultJson, Options);
        Assert.NotNull(result);
        var player = result.Adp.PlayerList[2];

        Assert.Equal("16161", player.Id);
        Assert.Equal(3.86, player.AdpValue, 0.001);
        Assert.Equal(97, player.SelectionPercentage);
        Assert.Equal(197, player.DraftCount);
        Assert.Equal(3, player.RankValue);
    }

    [Fact]
    public void Deserialize_SingleResultJson_ParsesOnePlayerCorrectly()
    {
        var result = JsonSerializer.Deserialize<MflAdpRoot>(AdpSingleResultJson, Options);

        Assert.NotNull(result);
        Assert.NotNull(result.Adp);
        Assert.Equal("202", result.Adp.TotalDrafts);
        Assert.Equal("453", result.Adp.TotalPicks);
        Assert.Single(result.Adp.PlayerList);
    }

    [Fact]
    public void Deserialize_SingleResultJson_PlayerDataIsCorrect()
    {
        var result = JsonSerializer.Deserialize<MflAdpRoot>(AdpSingleResultJson, Options);
        Assert.NotNull(result);
        var player = result.Adp.PlayerList[0];

        Assert.Equal("15281", player.Id);
        Assert.Equal("1", player.Rank);
        Assert.Equal("3.27", player.AveragePick);
        Assert.Equal("1", player.MinPick);
        Assert.Equal("10", player.MaxPick);
        Assert.Equal("95", player.DraftSelPct);
        Assert.Equal("192", player.DraftsSelectedIn);
    }

    [Fact]
    public void Deserialize_SingleResultJson_ConveniencePropertiesAreCorrect()
    {
        var result = JsonSerializer.Deserialize<MflAdpRoot>(AdpSingleResultJson, Options);

        Assert.NotNull(result);
        var player = result.Adp.PlayerList[0];

        Assert.Equal(3.27, player.AdpValue, 0.001);
        Assert.Equal(1, player.RankValue);
        Assert.Equal(1, player.MinPickValue);
        Assert.Equal(10, player.MaxPickValue);
        Assert.Equal(95.0, player.SelectionPercentage, 0.001);
        Assert.Equal(192, player.DraftCount);
    }

}