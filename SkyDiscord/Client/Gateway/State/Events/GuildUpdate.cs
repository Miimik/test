﻿using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Models;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleGuildUpdateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<GuildModel>();
            var guild = GetGuild(model.Id);
            var oldGuild = guild.Clone();
            guild.Update(model);

            return _client._guildUpdated.InvokeAsync(new GuildUpdatedEventArgs(oldGuild, guild));
        }
    }
}
