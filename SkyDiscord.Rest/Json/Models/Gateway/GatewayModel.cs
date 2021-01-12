using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal class GatewayModel : JsonModel
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
