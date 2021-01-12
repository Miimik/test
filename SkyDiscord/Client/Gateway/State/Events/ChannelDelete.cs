﻿using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Logging;
using SkyDiscord.Models;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleChannelDeleteAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<ChannelModel>();
            CachedChannel channel;
            if (model.GuildId != null)
            {
                var guild = GetGuild(model.GuildId.Value);
                guild._channels.TryRemove(model.Id, out var guildChannel);
                channel = guildChannel;
            }
            else
            {
                _privateChannels.TryRemove(model.Id, out var privateChannel);
                channel = privateChannel;
            }

            if (channel == null)
            {
                _client.Log(LogSeverity.Warning, $"Unknown channel in ChannelDelete. Id: {model.Id}.");
                return Task.CompletedTask;
            }

            return _client._channelDeleted.InvokeAsync(new ChannelDeletedEventArgs(channel));
        }
    }
}
