// File: MflRulesClasses.cs
// Namespace: Mfl.Api.Model.Rules
// Purpose: Models for MyFantasyLeague (MFL) league rules export JSON

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Mfl.Api.Model.Rules
{
    /// <summary>
    /// Root object returned by MFL's leagueRules export
    /// </summary>
    public class LeagueRulesRoot
    {
        [JsonPropertyName("version")]
        public string Version { get; set; } = "";

        [JsonPropertyName("encoding")]
        public string Encoding { get; set; } = "";

        [JsonPropertyName("rules")]
        public RulesContainer Rules { get; set; } = new();
    }

    /// <summary>
    /// Container for all position-based scoring rules
    /// </summary>
    public class RulesContainer
    {
        [JsonPropertyName("positionRules")]
        public List<PositionRuleGroup> PositionRuleGroups { get; set; } = new();
    }

    /// <summary>
    /// Represents one group of scoring rules applied to one or more positions
    /// (e.g., "QB" or "QB|RB|WR|TE|PK")
    /// </summary>
    public class PositionRuleGroup
    {
        [JsonPropertyName("positions")]
        public string Positions { get; set; } = "";

        [JsonPropertyName("rule")]
        public List<ScoringRule> Rules { get; set; } = new();
    }

    /// <summary>
    /// A single scoring rule (e.g., 300-399 passing yards = 10 points)
    /// </summary>
    public class ScoringRule
    {
        [JsonPropertyName("event")]
        public TextNode Event { get; set; } = new();

        [JsonPropertyName("points")]
        public TextNode Points { get; set; } = new();

        [JsonPropertyName("range")]
        public TextNode Range { get; set; } = new();

        [JsonPropertyName("per")]
        public TextNode? Per { get; set; } // Optional in some rules
    }

    /// <summary>
    /// Helper class for MFL's { "$t": "value" } text node pattern
    /// </summary>
    public class TextNode
    {
        [JsonPropertyName("$t")]
        public string Value { get; set; } = "";

        public override string ToString() => Value;
    }
}