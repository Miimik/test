﻿using System.Collections.Generic;
using Discord.Serialization.Json;

namespace Discord.Models.Dispatches
{
    internal sealed class PresenceUpdateModel : JsonModel
    {
        [JsonProperty("user")]
        public UserModel User { get; set; }

        [JsonProperty("roles")]
        public ulong[] Roles { get; set; }

        [JsonProperty("nick")]
        public string Nick { get; set; }

        [JsonProperty("game")]
        public ActivityModel Game { get; set; }

        [JsonProperty("guild_id")]
        public ulong? GuildId { get; set; }

        [JsonProperty("status")]
        public UserStatus Status { get; set; }

        [JsonProperty("client_status")]
        public Dictionary<UserClient, UserStatus> ClientStatus { get; set; }

        [JsonProperty("activities")]
        public ActivityModel[] Activities { get; set; }
    }
}
