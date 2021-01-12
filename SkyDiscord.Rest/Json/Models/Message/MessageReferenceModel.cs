using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class MessageReferenceModel : JsonModel
    {
        [JsonProperty("message_id")]
        public Optional<ulong> MessageId { get; set; }

        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }

        [JsonProperty("guild_id")]
        public Optional<ulong> GuildId { get; set; }
    }
}