using Discord.Models;

namespace Discord.Rest.AuditLogs
{
    public sealed class RestMembersDisconnectedAuditLog : RestAuditLog
    {
        public int Count { get; }

        internal RestMembersDisconnectedAuditLog(RestDiscordClient client, AuditLogModel log, AuditLogEntryModel entry) : base(client, log, entry)
        {
            Count = entry.Options.Count;
        }
    }
}
