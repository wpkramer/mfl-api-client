using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mfl.Api.Model.NFL;

/*
 * This file contains classes representing the MyFantasyLeague NFL Schedule JSON structure.
 */



public class NFLAllWeeksRoot
{
    [JsonPropertyName("encoding")]
    public string Encoding { get; set; } = string.Empty;

    [JsonPropertyName("fullNflSchedule")]
    public FullNflSchedule FullNflSchedule { get; set; } = new FullNflSchedule();

    [JsonPropertyName("version")]
    public string Version { get; set; } = string.Empty;
}

public class NFLOneWeekRoot
{
    [JsonPropertyName("encoding")]
    public string Encoding { get; set; } = string.Empty;
    [JsonPropertyName("nflSchedule")]
    public NflSchedule NflSchedule { get; set; } = new NflSchedule();
    [JsonPropertyName("version")]
    public string Version { get; set; } = string.Empty;
}

public partial class FullNflSchedule
{
    [JsonPropertyName("nflSchedule")]
    public List<NflSchedule> NflScheduleWeeks { get; set; } = [];
}


public class NflSchedule
{
    [JsonPropertyName("matchup")]
    public List<Matchup> Matchups { get; set; } = [];

    [JsonPropertyName("lastUpdate")]
    public string LastUpdate { get; set; } = string.Empty;

    [JsonPropertyName("week")]
    public string Week { get; set; } = string.Empty;
}

public class Matchup
{
    [JsonPropertyName("gameSecondsRemaining")]
    public string GameSecondsRemaining { get; set; } = string.Empty;

    [JsonPropertyName("kickoff")]
    public string Kickoff { get; set; } = string.Empty;

    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    [JsonPropertyName("team")]
    public List<Team> Teams { get; set; } = [];
}



public class Team
{
    [JsonPropertyName("rushDefenseRank")]
    public string RushDefenseRank { get; set; } = string.Empty;

    [JsonPropertyName("hasPossession")]
    public string HasPossession { get; set; } = string.Empty;

    [JsonPropertyName("score")]
    public string Score { get; set; } = string.Empty;

    [JsonPropertyName("passOffenseRank")]
    public string PassOffenseRank { get; set; } = string.Empty;

    [JsonPropertyName("inRedZone")]
    public string InRedZone { get; set; } = string.Empty;

    [JsonPropertyName("isHome")]
    public string IsHome { get; set; } = string.Empty;

    [JsonPropertyName("rushOffenseRank")]
    public string RushOffenseRank { get; set; } = string.Empty;

    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("passDefenseRank")]
    public string PassDefenseRank { get; set; } = string.Empty;

    [JsonPropertyName("spread")]
    public string Spread { get; set; } = string.Empty;
}

