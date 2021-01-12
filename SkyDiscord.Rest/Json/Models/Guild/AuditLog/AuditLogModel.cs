﻿using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class AuditLogModel : JsonModel
    {
        [JsonProperty("webhooks")]
        public WebhookModel[] Webhooks { get; set; }

        [JsonProperty("users")]
        public UserModel[] Users { get; set; }

        [JsonProperty("integrations")]
        public IntegrationModel[] Integrations { get; set; }

        [JsonProperty("audit_log_entries")]
        public AuditLogEntryModel[] AuditLogEntries { get; set; }
    }
}
