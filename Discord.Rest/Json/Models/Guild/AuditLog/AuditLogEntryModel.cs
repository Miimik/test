﻿using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class AuditLogEntryModel : JsonModel
    {
        [JsonProperty("target_id")]
        public ulong? TargetId { get; set; }

        [JsonProperty("changes")]
        public AuditLogChangeModel[] Changes { get; set; }

        [JsonProperty("user_id")]
        public ulong UserId { get; set; }

        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("action_type")]
        public AuditLogType ActionType { get; set; }

        [JsonProperty("options")]
        public AuditLogEntryOptionsModel Options { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
