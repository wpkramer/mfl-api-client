using System.Collections.Generic;
using System.Text.Json.Serialization;
using Mfl.Api.Common;
namespace Mfl.Api.Model.Adp;

/// <summary>
/// Specifies the available period types for filtering or categorizing data.
/// </summary>
public enum PeriodType
{
    ALL, RECENT, DRAFT, JUNE, JULY, AUG1, AUG15, START, MID, PLAYOFF
}

/// <summary>
/// Specifies the number of franchises in a league for filtering or categorizing data.
/// </summary>
public enum FranchiseCountType
{
    EightOrLess = 8,
    ExactlyTen = 10,
    ExactlyTwelve = 12,
    ExactlyFourteen = 14,
    SixteenOrMore = 16
}

/// <summary>
/// Specifies the scoring format used in fantasy football leagues.
/// </summary>
public enum ScoringType
{
    NotPPR = 0,
    PPR = 1,
    All = -1
}

/// <summary>
/// Specifies the type of league format for a fantasy sports league.
/// </summary>
/// <remarks>Use this enumeration to indicate whether a league is a keeper, redraft, rookie-only, or a combination
/// of rookie and keeper draft. The value determines player retention and draft eligibility rules for the
/// league.</remarks>
public enum KeeperStatus
{
    /// <summary>
    /// Keeper league
    /// </summary>
    K,
    /// <summary>
    /// Redraft league
    /// </summary>
    N,
    /// <summary>
    /// Rookie only draft
    /// </summary>
    R,
    /// <summary>
    /// Rookie and keeper draft
    /// </summary>
    KR
}

/// <summary>
/// Specifies the filter for finding mock drafts, real drafts, or both.
/// </summary>
public enum MockDraftType
{
    Real = 0,
    Mock = 1,
    Both = -1
}

public class MflAdpRoot
{
    [JsonPropertyName("encoding")]
    public string Encoding { get; set; } = string.Empty;

    [JsonPropertyName("version")]
    public string Version { get; set; } = string.Empty;

    [JsonPropertyName("adp")]
    public AdpWrapper Adp { get; set; } = new AdpWrapper();
}

public class AdpWrapper
{
    [JsonPropertyName("timestamp")]
    public string Timestamp { get; set; } = string.Empty;

    [JsonPropertyName("totalPicks")]
    public string TotalPicks { get; set; } = string.Empty;

    [JsonPropertyName("totalDrafts")]
    public string TotalDrafts { get; set; } = string.Empty;

    // Handles both array and potential single object (though real data uses array under "player")
    [JsonPropertyName("player")]
    [JsonConverter(typeof(SingleOrArrayConverter<MflAdpPlayer>))]
    public List<MflAdpPlayer> PlayerList { get; set; } = [];
}

public class MflAdpPlayer
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("averagePick")]
    public string AveragePick { get; set; } = string.Empty;

    [JsonPropertyName("minPick")]
    public string MinPick { get; set; } = string.Empty;

    [JsonPropertyName("maxPick")]
    public string MaxPick { get; set; } = string.Empty;

    [JsonPropertyName("rank")]
    public string Rank { get; set; } = string.Empty;

    [JsonPropertyName("draftSelPct")]
    public string DraftSelPct { get; set; } = string.Empty;

    [JsonPropertyName("draftsSelectedIn")]
    public string DraftsSelectedIn { get; set; } = string.Empty;

    // Convenience properties for sorting/display
    [JsonIgnore]
    public double AdpValue => double.TryParse(AveragePick, out var adp) ? adp : double.MaxValue;

    [JsonIgnore]
    public int DraftCount => int.TryParse(DraftsSelectedIn, out var count) ? count : 0;

    [JsonIgnore]
    public double SelectionPercentage => double.TryParse(DraftSelPct, out var pct) ? pct : 0.0;

    [JsonIgnore]
    public int RankValue => int.TryParse(Rank, out var r) ? r : int.MaxValue;

    [JsonIgnore]
    public int MinPickValue => int.TryParse(MinPick, out var min) ? min : 0;

    [JsonIgnore]
    public int MaxPickValue => int.TryParse(MaxPick, out var max) ? max : 0;
}