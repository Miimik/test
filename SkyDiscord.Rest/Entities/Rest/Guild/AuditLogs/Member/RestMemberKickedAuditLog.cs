using SkyDiscord.Models;

namespace SkyDiscord.Rest.AuditLogs
{
    public sealed class RestMemberKickedAuditLog : RestAuditLog
    {
        internal RestMemberKickedAuditLog(RestDiscordClient client, AuditLogModel log, AuditLogEntryModel entry) : base(client, log, entry)
        { }
    }
}
