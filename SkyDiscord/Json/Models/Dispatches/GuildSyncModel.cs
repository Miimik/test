﻿using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models.Dispatches
{
    internal sealed class GuildSyncModel : JsonModel
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("presences")]
        public PresenceUpdateModel[] Presences { get; set; }

        [JsonProperty("members")]
        public MemberModel[] Members { get; set; }
    }
}
