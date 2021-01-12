﻿using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class SessionStartLimitModel : JsonModel
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("reset_after")]
        public int ResetAfter { get; set; }
    }
}