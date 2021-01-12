using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class EmbedVideoModel : JsonModel
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }
    }
}
