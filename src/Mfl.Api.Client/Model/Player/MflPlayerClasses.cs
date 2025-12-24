using Mfl.Api.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;



namespace Mfl.Api.Model.Player;


public class MflPlayersRoot
{
    [JsonPropertyName("players")]
    public PlayersWrapper Players { get; set; } = new PlayersWrapper();

    [JsonPropertyName("version")]
    public string Version { get; set; } = string.Empty;

    [JsonPropertyName("encoding")]
    public string Encoding { get; set; } = string.Empty;

    [JsonPropertyName("timestamp")]
    public string Timestamp { get; set; } = string.Empty;
}

public class PlayersWrapper
{
    // Handles both: "player": { ... } (single)  AND  "player": [ ... ] (array)
    [JsonPropertyName("player")]
    [JsonConverter(typeof(SingleOrArrayConverter<MflPlayer>))]
    public List<MflPlayer> PlayerList { get; set; } = [];

    [JsonPropertyName("timestamp")]
    public string Timestamp { get; set; } = string.Empty;

    [JsonPropertyName("since")]
    public string Since { get; set; } = string.Empty;
}

public class MflPlayer
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;               // "Last, First"

    [JsonPropertyName("position")]
    public string Position { get; set; } = string.Empty;

    [JsonPropertyName("team")]
    public string Team { get; set; } = string.Empty;

    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;             // e.g., "R" for rookie

    [JsonPropertyName("jersey")]
    public string Jersey { get; set; } = string.Empty;

    [JsonPropertyName("height")]
    public string Height { get; set; } = string.Empty;             // inches as string

    [JsonPropertyName("weight")]
    public string Weight { get; set; } = string.Empty;             // lbs as string

    [JsonPropertyName("birthdate")]
    public string Birthdate { get; set; } = string.Empty;          // Unix timestamp string

    [JsonPropertyName("college")]
    public string College { get; set; } = string.Empty;

    [JsonPropertyName("draft_year")]
    public string DraftYear { get; set; } = string.Empty;

    [JsonPropertyName("draft_round")]
    public string DraftRound { get; set; } = string.Empty;

    [JsonPropertyName("draft_pick")]
    public string DraftPick { get; set; } = string.Empty;

    [JsonPropertyName("draft_team")]
    public string DraftTeam { get; set; } = string.Empty;

    [JsonPropertyName("espn_id")]
    public string EspnId { get; set; } = string.Empty;

    [JsonPropertyName("rotoworld_id")]
    public string RotoworldId { get; set; } = string.Empty;

    [JsonPropertyName("rotowire_id")]
    public string RotowireId { get; set; } = string.Empty;

    [JsonPropertyName("cbs_id")]
    public string CbsId { get; set; } = string.Empty;

    [JsonPropertyName("sportsdata_id")]
    public string SportsdataId { get; set; } = string.Empty;

    [JsonPropertyName("nfl_id")]
    public string NflId { get; set; } = string.Empty;

    [JsonPropertyName("fleaflicker_id")]
    public string FleaflickerId { get; set; } = string.Empty;

    [JsonPropertyName("stats_global_id")]
    public string StatsGlobalId { get; set; } = string.Empty;

    [JsonPropertyName("twitter_username")]
    public string TwitterUsername { get; set; } = string.Empty;

    // Convenience properties
    [JsonIgnore]
    public int JerseyNumber => int.TryParse(Jersey, out var j) ? j : 0;

    [JsonIgnore]
    public int HeightInches => int.TryParse(Height, out var h) ? h : 0;

    [JsonIgnore]
    public int WeightLbs => int.TryParse(Weight, out var w) ? w : 0;

    [JsonIgnore]
    public DateTimeOffset? BirthDate => long.TryParse(Birthdate, out var ts)
        ? DateTimeOffset.FromUnixTimeSeconds(ts)
        : null;

    [JsonIgnore]
    public bool IsRookie => Status == "R";

    [JsonIgnore]
    public bool IsFreeAgent => Team == "FA";

    [JsonIgnore]
    public bool IsTeamUnit => Position.StartsWith("TM") || new[] { "Def", "ST", "Off", "Coach" }.Contains(Position);
}