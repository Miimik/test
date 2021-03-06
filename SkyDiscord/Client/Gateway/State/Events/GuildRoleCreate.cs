﻿using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleGuildRoleCreateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<GuildRoleCreateModel>();
            var guild = GetGuild(model.GuildId);
            var role = guild._roles.AddOrUpdate(model.Role.Id, _ => new CachedRole(guild, model.Role), (_, old) =>
            {
                old.Update(model.Role);
                return old;
            });

            return _client._roleCreated.InvokeAsync(new RoleCreatedEventArgs(role));
        }
    }
}
