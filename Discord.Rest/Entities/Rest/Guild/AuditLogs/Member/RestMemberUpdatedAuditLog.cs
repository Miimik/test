using Discord.Models;

namespace Discord.Rest.AuditLogs
{
    public sealed class RestMemberUpdatedAuditLog : RestAuditLog
    {
        public MemberChanges Changes { get; }

        internal RestMemberUpdatedAuditLog(RestDiscordClient client, AuditLogModel log, AuditLogEntryModel entry) : base(client, log, entry)
        {
            Changes = new MemberChanges(client, entry);
        }
    }
}
