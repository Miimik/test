using Discord.Serialization.Json;

namespace Discord.Models.Dispatches
{
    internal sealed class MessageDeleteBulkModel : JsonModel
    {
        [JsonProperty("ids")]
        public ulong[] Ids { get; set; }

        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }

        [JsonProperty("guild_id")]
        public ulong? GuildId { get; set; }
    }
}
