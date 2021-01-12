using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class GatewayBotModel : GatewayModel
    {
        [JsonProperty("shards")]
        public int Shards { get; set; }

        [JsonProperty("session_start_limit")]
        public SessionStartLimitModel SessionStartLimit { get; set; }
    }
}
