using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mfl.Api.Model.PlayerInjury
{
    public class InjuriesRoot
    {
        [JsonPropertyName("version")]
        public string Version { get; set; } = string.Empty;

        [JsonPropertyName("encoding")]
        public string Encoding { get; set; } = string.Empty;

        [JsonPropertyName("injuries")]
        public InjuriesContainer? Injuries { get; set; }
    }

    public class InjuriesContainer
    {
        [JsonPropertyName("week")]
        public string Week { get; set; } = string.Empty;

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; } = string.Empty;

        [JsonPropertyName("injury")]
        public List<Injury> InjuryList { get; set; } = new();
    }

    public class Injury
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        [JsonPropertyName("details")]
        public string Details { get; set; } = string.Empty;

        [JsonPropertyName("exp_return")]
        public string ExpectedReturn { get; set; } = string.Empty;
    }
}