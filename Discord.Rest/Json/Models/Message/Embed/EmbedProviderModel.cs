using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class EmbedProviderModel : JsonModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
