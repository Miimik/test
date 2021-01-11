﻿using System;
using Discord.Serialization.Json;

namespace Discord.Models
{
    internal class MemberModel : JsonModel
    {
        [JsonProperty("user")]
        public UserModel User { get; set; }

        [JsonProperty("nick")]
        public Optional<string> Nick { get; set; }

        [JsonProperty("roles")]
        public Optional<ulong[]> Roles { get; set; }

        [JsonProperty("joined_at", NullValueHandling.Ignore)] // TODO: null?
        public DateTimeOffset JoinedAt { get; set; }

        [JsonProperty("deaf")]
        public bool Deaf { get; set; }

        [JsonProperty("mute")]
        public bool Mute { get; set; }

        [JsonProperty("premium_since")]
        public Optional<DateTimeOffset?> PremiumSince { get; set; }
    }
}
