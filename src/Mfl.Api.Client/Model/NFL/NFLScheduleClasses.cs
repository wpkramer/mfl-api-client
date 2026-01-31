// grok, Just now there is trouble parsing using the NFLAllWeeks Root,
// the data i am parsing is from https://api.myfantasyleague.com/2025/export?TYPE=nflSchedule&W=ALL&JSON=1
// I think its the last week but haven't spotted the difference, can you assist.


using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;
using System;

namespace Mfl.Api.Model.NFL;


public class MatchupConverter : JsonConverter<List<Matchup>>
{
    public override List<Matchup> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        var list = new List<Matchup>();

        if (reader.TokenType == JsonTokenType.StartArray)
        {
            // Normal array case
            while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
            {
                var matchup = JsonSerializer.Deserialize<Matchup>(ref reader, options);
                if (matchup != null) list.Add(matchup);
            }
        }
        else if (reader.TokenType == JsonTokenType.StartObject)
        {
            // Single object case → wrap in list
            var single = JsonSerializer.Deserialize<Matchup>(ref reader, options);
            if (single != null) list.Add(single);
        }
        else if (reader.TokenType == JsonTokenType.Null)
        {
            // Empty/no matchups → empty list
        }
        else
        {
            throw new JsonException($"Unexpected token type for matchup: {reader.TokenType}");
        }

        return list;
    }

    public override void Write(
        Utf8JsonWriter writer,
        List<Matchup> value,
        JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, options);
    }
}

public class NFLAllWeeksRoot
{
    [JsonPropertyName("encoding")]
    public string Encoding { get; set; } = string.Empty;

    [JsonPropertyName("fullNflSchedule")]
    public FullNflSchedule FullNflSchedule { get; set; } = new ();

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
    public List<NflSchedule> NflSchedule { get; set; } = [];
}


public class NflSchedule
{
    [JsonPropertyName("matchup")]
    [JsonConverter(typeof(MatchupConverter))]
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

