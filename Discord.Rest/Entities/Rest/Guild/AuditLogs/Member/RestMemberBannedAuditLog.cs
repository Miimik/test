using Discord.Models;

namespace Discord.Rest.AuditLogs
{
    public sealed class RestMemberBannedAuditLog : RestAuditLog
    {
        internal RestMemberBannedAuditLog(RestDiscordClient client, AuditLogModel log, AuditLogEntryModel entry) : base(client, log, entry)
        { }
    }
}
