﻿using System.Threading.Tasks;
using Discord.Events;
using Discord.Models;
using Discord.Models.Dispatches;

namespace Discord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleGuildRoleDeleteAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<GuildRoleDeleteModel>();
            var guild = GetGuild(model.GuildId);
            guild._roles.TryRemove(model.RoleId, out var role);

            return _client._roleDeleted.InvokeAsync(new RoleDeletedEventArgs(role));
        }
    }
}
