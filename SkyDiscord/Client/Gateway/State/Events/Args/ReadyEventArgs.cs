using System.Collections.Generic;
using SkyDiscord.Collections;

namespace SkyDiscord.Events
{
    public class ReadyEventArgs : DiscordEventArgs
    {
        public string SessionId { get; }

        public IReadOnlyList<string> Trace { get; }

        internal ReadyEventArgs(DiscordClientBase client, string sessionId, string[] trace) : base(client)
        {
            SessionId = sessionId;
            Trace = trace.ReadOnly();
        }
    }
}
