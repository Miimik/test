﻿using Discord.Logging;
using Discord.Models;

namespace Discord.Rest.AuditLogs
{
    public sealed class RestUnknownAuditLog : RestAuditLog
    {
        internal RestUnknownAuditLog(RestDiscordClient client, AuditLogModel log, AuditLogEntryModel entry) : base(client, log, entry)
        {
            Client.Log(LogSeverity.Error, $"Unknown audit log type received: {(int) entry.ActionType}.");
        }
    }
}