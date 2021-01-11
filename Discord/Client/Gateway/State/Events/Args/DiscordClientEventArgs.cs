using System;

namespace Discord.Events
{
    public abstract class DiscordEventArgs : EventArgs
    {
        public DiscordClientBase Client { get; }

        internal DiscordEventArgs(DiscordClientBase client)
        {
            Client = client;
        }
    }
}
