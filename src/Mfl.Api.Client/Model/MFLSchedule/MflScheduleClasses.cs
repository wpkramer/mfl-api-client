using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Mfl.Api.Model.MflSchedule;

public class MflScheduleRoot
{
    public Schedule Schedule { get; set; } = new Schedule();
    public string Version { get; set; } = string.Empty;
    public string Encoding { get; set; } = string.Empty;
}

public class Schedule
{
    [JsonPropertyName("weeklySchedule")]
    public List<WeeklySchedule> WeeklySchedules { get; set; } = [];
}

public class WeeklySchedule
{
    public string Week { get; set; } = string.Empty;

    [JsonPropertyName("matchup")]
    public List<Matchup> Matchups { get; set; } = [];
}

public class Matchup
{
    [JsonPropertyName("franchise")]
    public List<FranchiseResult> Franchises { get; set; } = new List<FranchiseResult>(2);

    // Order-independent: always correct regardless of JSON array order
    [JsonIgnore]
    public FranchiseResult Away => Franchises.First(f => f.IsHome == "0");

    [JsonIgnore]
    public FranchiseResult Home => Franchises.First(f => f.IsHome == "1");

    // Optional: keep a strongly-typed pair for convenience
    [JsonIgnore]
    public (FranchiseResult Away, FranchiseResult Home) Teams => (Away, Home);

    // Optional validation
    [JsonIgnore]
    public bool IsValid => Franchises.Count == 2 &&
                           Franchises.Any(f => f.IsHome == "0") &&
                           Franchises.Any(f => f.IsHome == "1");
}



public class FranchiseResult
{
    public string Id { get; set; } = string.Empty;
    public string Score { get; set; } = string.Empty;
    public string Result { get; set; } = string.Empty;      // "W", "L", "T", or empty if not played
    public string IsHome { get; set; } = string.Empty;     // "1" = home, "0" = away
    public string Spread { get; set; } = string.Empty;     // Only present in later weeks (e.g., "3.5", "-7.6")

    // Convenience properties
    [JsonIgnore]
    public bool IsHomeTeam => IsHome == "1";

    [JsonIgnore]
    public bool IsAwayTeam => IsHome == "0";

    [JsonIgnore]
    public double ScoreValue => double.TryParse(Score, out var s) ? s : 0.0;

    [JsonIgnore]
    public double SpreadValue => double.TryParse(Spread, out var sp) ? sp : 0.0;
}