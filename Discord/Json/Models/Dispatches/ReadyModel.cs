﻿using Discord.Serialization.Json;

namespace Discord.Models.Dispatches
{
    internal sealed class ReadyModel : JsonModel
    {
        [JsonProperty("v", NullValueHandling.Ignore)]
        public int V { get; set; }

        [JsonProperty("user", NullValueHandling.Ignore)]
        public UserModel User { get; set; }

        [JsonProperty("private_channels", NullValueHandling.Ignore)]
        public ChannelModel[] PrivateChannels { get; set; }

        [JsonProperty("guilds", NullValueHandling.Ignore)]
        public WebSocketGuildModel[] Guilds { get; set; }

        [JsonProperty("session_id", NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        [JsonProperty("_trace", NullValueHandling.Ignore)]
        public string[] Trace { get; set; }
    }
}
