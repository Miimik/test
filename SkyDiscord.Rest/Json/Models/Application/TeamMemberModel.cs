﻿using SkyDiscord.Rest;
using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class TeamMemberModel : JsonModel
    {
        [JsonProperty("user")]
        public UserModel User { get; set; }

        [JsonProperty("team_id")]
        public ulong TeamId { get; set; }

        [JsonProperty("membership_state")]
        public TeamMembershipState MembershipState { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }
    }
}