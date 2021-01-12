using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models.Dispatches
{
    internal sealed class WebhooksUpdateModel : JsonModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }
    }
}
