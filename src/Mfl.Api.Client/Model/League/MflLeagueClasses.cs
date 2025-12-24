using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mfl.Api.Model.League;

/*
 * This file contains classes representing the MyFantasyLeague LeagueList JSON structure.
 */

/// <summary>
/// My FantasyLeague League JSON root object
/// </summary>
public class MflLeagueRoot
{
    public string Version { get; set; } = string.Empty;
    public string Encoding { get; set; } = string.Empty;
    public League League { get; set; } = new League();
}

public class League
{
    public string VictoryPointsBuckets { get; set; } = string.Empty;
    public string PlayerLimitUnit { get; set; } = string.Empty;
    public string Id { get; set; } = string.Empty;
    public RosterLimits RosterLimits { get; set; } = new RosterLimits();
    public Starters Starters { get; set; } = new Starters();
    public string SurvivorPoolStartWeek { get; set; } = string.Empty;
    public string RosterSize { get; set; } = string.Empty;
    public string Precision { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string CurrentWaiverType { get; set; } = string.Empty;
    public string VictoryPointsStartWeek { get; set; } = string.Empty;
    public string TaxiSquad { get; set; } = string.Empty;
    public Franchises Franchises { get; set; } = new Franchises();
    public string SurvivorPoolEndWeek { get; set; } = string.Empty;
    public string EndWeek { get; set; } = string.Empty;
    public string LoadRosters { get; set; } = string.Empty;
    public string PartialLineupAllowed { get; set; } = string.Empty;
    public string LastRegularSeasonWeek { get; set; } = string.Empty;
    public string InjuredReserve { get; set; } = string.Empty;
    public string RostersPerPlayer { get; set; } = string.Empty;
    public string VictoryPointsEndWeek { get; set; } = string.Empty;
    public string SurvivorPool { get; set; } = string.Empty;
    public string StartWeek { get; set; } = string.Empty;
    public string H2h { get; set; } = string.Empty;
    public string MobileAlerts { get; set; } = string.Empty;
    public string BaseURL { get; set; } = string.Empty;
    public History History { get; set; } = new History();
    public string BestLineup { get; set; } = string.Empty;
    public string UsesContractYear { get; set; } = string.Empty;
    public string VictoryPointsTie { get; set; } = string.Empty;
    public string DefaultTradeExpirationDays { get; set; } = string.Empty;
    public string VictoryPointsWin { get; set; } = string.Empty;
    public string Lockout { get; set; } = string.Empty;
    public string MaxWaiverRounds { get; set; } = string.Empty;
    public string StandingsSort { get; set; } = string.Empty;
    public string VictoryPointsLoss { get; set; } = string.Empty;
    public string UsesSalaries { get; set; } = string.Empty;
}

public class RosterLimits
{
    [JsonPropertyName("position")]
    public List<PositionLimit> PositionList { get; set; } = [];
}

public class Starters
{
    public string Count { get; set; } = string.Empty;
    [JsonPropertyName("position")]
    public List<PositionLimit> PositionList { get; set; } = [];
}

public class PositionLimit
{
    public string Name { get; set; } = string.Empty;
    public string Limit { get; set; } = string.Empty;
}

public class Franchises
{
    [JsonPropertyName("franchise")]
    public List<Franchise> FranchiseList { get; set; } = [];
    public string Count { get; set; } = string.Empty;
}

public class Franchise
{
    public string WaiverSortOrder { get; set; } = string.Empty;
    public string Id { get; set; } = string.Empty;
    public string Logo { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Sound { get; set; } = string.Empty;
    public string Stadium { get; set; } = string.Empty;
}

public class History
{
    [JsonPropertyName("league")]
    public List<HistoryLeague> HistoryLeagueList { get; set; } = [];
}

public class HistoryLeague
{
    public string Url { get; set; } = string.Empty;
    public string Year { get; set; } = string.Empty;
}
