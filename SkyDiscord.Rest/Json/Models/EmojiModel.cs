﻿using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class EmojiModel : JsonModel
    {
        [JsonProperty("id")]
        public ulong? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roles")]
        public Snowflake[] Roles { get; set; }

        [JsonProperty("user")]
        public UserModel User { get; set; }

        [JsonProperty("require_colons")]
        public bool RequireColons { get; set; }

        [JsonProperty("managed")]
        public bool Managed { get; set; }

        [JsonProperty("animated")]
        public bool Animated { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }
    }
}
