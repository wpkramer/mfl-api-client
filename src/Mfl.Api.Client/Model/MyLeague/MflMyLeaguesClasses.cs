using Mfl.Api.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mfl.Api.Model.MyLeague;



public class MflMyLeaguesRoot
{
    [JsonPropertyName("leagues")]
    public LeaguesWrapper Leagues { get; set; } = new LeaguesWrapper();
    [JsonPropertyName("version")]
    public string Version { get; set; } = string.Empty;
    [JsonPropertyName("encoding")]
    public string Encoding { get; set; } = string.Empty;
}

public class LeaguesWrapper
{
    // This will be either a single object OR an array — System.Text.Json handles both seamlessly when mapped to List<T>
    [JsonPropertyName("league")]
    [JsonConverter(typeof(SingleOrArrayConverter<MyLeague>))]
    public List<MyLeague> LeagueList { get; set; } = [];
}

public class MyLeague
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    [JsonPropertyName("franchise_name")]
    public string FranchiseName { get; set; } = string.Empty;     // e.g., "BK"
    [JsonPropertyName("franchise_id")]
    public string FranchiseId { get; set; } = string.Empty;       // e.g., "0002"
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
    [JsonPropertyName("league_id")]
    public string LeagueId { get; set; } = string.Empty;          // e.g., "15930"

    // Convenience: extract the base URL if needed (e.g., "www44.myfantasyleague.com")
    [JsonIgnore]
    public string BaseHost => Uri.TryCreate(Url, UriKind.Absolute, out var uri)
        ? uri.Host
        : string.Empty;
}