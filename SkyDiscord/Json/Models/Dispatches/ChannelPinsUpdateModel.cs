using System;
using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models.Dispatches
{
    internal sealed class ChannelPinsUpdateModel : JsonModel
    {
        [JsonProperty("guild_id")]
        public ulong? GuildId { get; set; }

        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }

        [JsonProperty("last_pin_timestamp")]
        public DateTimeOffset? LastPinTimestamp { get; set; }
    }
}
