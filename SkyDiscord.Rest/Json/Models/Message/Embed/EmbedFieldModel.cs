using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class EmbedFieldModel : JsonModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("inline")]
        public bool Inline { get; set; }
    }
}
