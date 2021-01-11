﻿using Discord.Serialization.Json;

namespace Discord.Models.Dispatches
{
    internal sealed class GuildMemberUpdateModel : JsonModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("roles")]
        public Optional<ulong[]> Roles { get; set; }

        [JsonProperty("user")]
        public UserModel User { get; set; }

        [JsonProperty("nick")]
        public Optional<string> Nick { get; set; }
    }
}
