﻿using Discord.Logging;
using Discord.Models;

namespace Discord.Rest.AuditLogs
{
    public sealed class WebhookChanges
    {
        public AuditLogChange<string> Name { get; }

        public AuditLogChange<WebhookType> Type { get; } // TODO: this might only be create/remove

        public AuditLogChange<string> AvatarHash { get; }

        public AuditLogChange<Snowflake> ChannelId { get; }

        internal WebhookChanges(RestDiscordClient client, AuditLogEntryModel model)
        {
            for (var i = 0; i < model.Changes.Length; i++)
            {
                var change = model.Changes[i];
                switch (change.Key)
                {
                    case "name":
                    {
                        Name = AuditLogChange<string>.Convert(change);
                        break;
                    }

                    case "type":
                    {
                        Type = AuditLogChange<WebhookType>.Convert(change);
                        break;
                    }

                    case "avatar_hash":
                    {
                        AvatarHash = AuditLogChange<string>.Convert(change);
                        break;
                    }

                    case "channel_id":
                    {
                        ChannelId = AuditLogChange<Snowflake>.Convert(change);
                        break;
                    }

                    default:
                    {
                        client.Log(LogSeverity.Error, $"Unknown change key for {nameof(WebhookChanges)}: '{change.Key}'.");
                        break;
                    }
                }
            }
        }
    }
}
