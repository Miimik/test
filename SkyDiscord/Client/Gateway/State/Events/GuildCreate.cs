﻿using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Logging;
using SkyDiscord.Models;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleGuildCreateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<WebSocketGuildModel>();
            var guild = _guilds.AddOrUpdate(model.Id,
                _ => new CachedGuild(_client, model),
                (_, oldValue) =>
                {
                    oldValue.Update(model);
                    return oldValue;
                });

            if (model.Unavailable.HasValue)
            {
                _client.GetGateway(model.Id).Log(LogSeverity.Information, $"Guild '{guild}' ({guild.Id}) became available.");
                return _client._guildAvailable.InvokeAsync(new GuildAvailableEventArgs(guild));
            }
            else
            {
                if (guild.IsLarge)
                    _ = _client.GetGateway(guild.Id).SendRequestMembersAsync(guild.Id);

                _client.GetGateway(model.Id).Log(LogSeverity.Information, $"Joined guild '{guild}' ({guild.Id}).");
                return _client._joinedGuild.InvokeAsync(new JoinedGuildEventArgs(guild));
            }
        }
    }
}
