using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class OverwriteModel : JsonModel
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("type")]
        public OverwriteTargetType Type { get; set; }

        [JsonProperty("allow")]
        public ulong Allow { get; set; }

        [JsonProperty("deny")]
        public ulong Deny { get; set; }
    }
}
