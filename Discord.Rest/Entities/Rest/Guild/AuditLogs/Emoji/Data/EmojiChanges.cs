﻿using Discord.Logging;
using Discord.Models;

namespace Discord.Rest.AuditLogs
{
    public sealed class EmojiChanges
    {
        public AuditLogChange<string> Name { get; }

        internal EmojiChanges(RestDiscordClient client, AuditLogEntryModel model)
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
