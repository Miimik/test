﻿using Discord.Serialization.Json;

namespace Discord.Models.Dispatches
{
    internal sealed class HelloModel : JsonModel
    {
        [JsonProperty("heartbeat_interval", NullValueHandling.Ignore)]
        public int HeartbeatInterval { get; set; }

        [JsonProperty("_trace", NullValueHandling.Ignore)]
        public string[] Trace { get; set; }
    }
}
