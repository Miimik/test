using Discord.Models;

namespace Discord.Rest.AuditLogs
{
    public sealed class RestOverwriteUpdatedAuditLog : RestAuditLog
    {
        public OverwriteChanges Changes { get; }

        internal RestOverwriteUpdatedAuditLog(RestDiscordClient client, AuditLogModel log, AuditLogEntryModel entry) : base(client, log, entry)
        {
            Changes = new OverwriteChanges(client, entry);
        }
    }
}
