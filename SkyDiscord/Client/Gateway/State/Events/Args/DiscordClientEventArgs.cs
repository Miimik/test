using System;

namespace SkyDiscord.Events
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
