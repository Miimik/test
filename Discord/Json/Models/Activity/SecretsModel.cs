﻿using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class SecretsModel : JsonModel
    {
        [JsonProperty("join", NullValueHandling.Ignore)]
        public string Join { get; set; }

        [JsonProperty("spectate", NullValueHandling.Ignore)]
        public string Spectate { get; set; }

        [JsonProperty("match", NullValueHandling.Ignore)]
        public string Match { get; set; }
    }
}