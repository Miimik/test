using Discord.Models;

namespace Discord.Rest.AuditLogs
{
    public sealed class RestChannelUpdatedAuditLog : RestAuditLog
    {
        public ChannelChanges Changes { get; }

        internal RestChannelUpdatedAuditLog(RestDiscordClient client, AuditLogModel log, AuditLogEntryModel entry) : base(client, log, entry)
        {
            Changes = new ChannelChanges(client, entry);
        }
    }
}
