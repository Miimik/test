using Discord.Serialization.Json;

namespace Discord.Models
{
    internal class GatewayModel : JsonModel
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
