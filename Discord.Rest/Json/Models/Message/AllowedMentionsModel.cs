﻿using System.Collections.Generic;
using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class AllowedMentionsModel : JsonModel
    {
        [JsonProperty("parse")]
        public IList<string> Parse { get; set; }

        [JsonProperty("users", NullValueHandling.Ignore)]
        public ulong[] Users { get; set; }

        [JsonProperty("roles", NullValueHandling.Ignore)]
        public ulong[] Roles { get; set; }
    }
}