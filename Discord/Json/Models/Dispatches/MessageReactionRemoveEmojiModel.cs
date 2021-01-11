using Discord.Serialization.Json;

namespace Discord.Models.Dispatches
{
    internal sealed class MessageReactionRemoveEmojiModel : JsonModel
    {
        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }

        [JsonProperty("message_id")]
        public ulong MessageId { get; set; }

        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("emoji")]
        public EmojiModel Emoji { get; set; }
    }
}
