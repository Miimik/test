using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class EmbedProviderModel : JsonModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
