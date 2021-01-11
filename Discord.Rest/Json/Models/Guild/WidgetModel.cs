﻿using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class WidgetModel : JsonModel
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("channel_id")]
        public ulong? ChannelId { get; set; }
    }
}
