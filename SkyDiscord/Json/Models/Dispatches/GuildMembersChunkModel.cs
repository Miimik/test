﻿using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models.Dispatches
{
    internal sealed class GuildMembersChunkModel : JsonModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("members")]
        public MemberModel[] Members { get; set; }

        [JsonProperty("presences")]
        public PresenceUpdateModel[] Presences { get; set; }
    }
}
