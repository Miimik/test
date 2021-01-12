﻿namespace SkyDiscord.Events
{
    public sealed class GuildAvailableEventArgs : DiscordEventArgs
    {
        public CachedGuild Guild { get; }

        internal GuildAvailableEventArgs(CachedGuild guild) : base(guild.Client)
        {
            Guild = guild;
        }
    }
}
