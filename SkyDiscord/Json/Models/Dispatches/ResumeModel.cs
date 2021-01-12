﻿using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models.Dispatches
{
    internal sealed class ResumeModel : JsonModel
    {
        [JsonProperty("token", NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("session_id", NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        [JsonProperty("seq", NullValueHandling.Ignore)]
        public int? Seq { get; set; }
    }
}
