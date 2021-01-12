﻿using SkyDiscord.Rest;
using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class JsonErrorModel : JsonModel
    {
        [JsonProperty("code")]
        public JsonErrorCode Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
