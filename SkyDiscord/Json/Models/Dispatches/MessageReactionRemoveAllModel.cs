using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models.Dispatches
{
    internal sealed class MessageReactionRemoveAllModel : JsonModel
    {
        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }

        [JsonProperty("message_id")]
        public ulong MessageId { get; set; }

        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }
    }
}
