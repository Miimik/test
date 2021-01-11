﻿using Discord.Serialization.Json;

namespace Discord.Models.Dispatches
{
    internal sealed class WebhooksUpdateModel : JsonModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }
    }
}
