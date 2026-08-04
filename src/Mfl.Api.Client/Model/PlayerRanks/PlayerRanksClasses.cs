using Mfl.Api.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Mfl.Api.Model.PlayerRanks;

public class MflPlayerRanksRoot
{
    [JsonPropertyName("encoding")]
    public string Encoding { get; set; } = string.Empty;

    [JsonPropertyName("version")]
    public string Version { get; set; } = string.Empty;

    [JsonPropertyName("player_ranks")]
    public PlayerRanksWrapper PlayerRanks { get; set; } = new PlayerRanksWrapper();
}

public class PlayerRanksWrapper
{
    [JsonPropertyName("pos")]
    public string Position { get; set; } = string.Empty;   // e.g. "QB", "RB", "WR", "TE", etc.

    // Handles both array and potential single-object cases
    [JsonPropertyName("player")]
    [JsonConverter(typeof(SingleOrArrayConverter<RankedPlayer>))]
    public List<RankedPlayer> PlayerList { get; set; } = new List<RankedPlayer>();
}

public class RankedPlayer
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("rank")]
    public string Rank { get; set; } = string.Empty;

    [JsonPropertyName("last_week")]
    public string LastWeek { get; set; } = string.Empty;

    [JsonPropertyName("change")]
    public string Change { get; set; } = string.Empty;   // e.g. "0", "+1", "-8"

    // Convenience properties
    [JsonIgnore]
    public int RankValue => int.TryParse(Rank, out var r) ? r : int.MaxValue;

    [JsonIgnore]
    public int LastWeekValue => int.TryParse(LastWeek, out var lw) ? lw : int.MaxValue;

    [JsonIgnore]
    public int ChangeValue => int.TryParse(Change, out var c) ? c : 0;

    [JsonIgnore]
    public bool RankImproved => ChangeValue > 0;

    [JsonIgnore]
    public bool RankDropped => ChangeValue < 0;

    [JsonIgnore]
    public bool RankUnchanged => ChangeValue == 0;
}