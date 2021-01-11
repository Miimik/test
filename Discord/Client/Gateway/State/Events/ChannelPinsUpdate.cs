﻿using System;
using System.Threading.Tasks;
using Discord.Events;
using Discord.Logging;
using Discord.Models;
using Discord.Models.Dispatches;

namespace Discord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleChannelPinsUpdateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<ChannelPinsUpdateModel>();
            DateTimeOffset? oldLastPinTimestamp;
            ICachedMessageChannel channel;
            if (model.GuildId != null)
            {
                var textChannel = GetGuild(model.GuildId.Value).GetTextChannel(model.ChannelId);
                oldLastPinTimestamp = textChannel.LastPinTimestamp;
                textChannel.LastPinTimestamp = model.LastPinTimestamp;
                channel = textChannel;
            }
            else
            {
                var privateChannel = GetPrivateChannel(model.ChannelId);
                if (privateChannel == null)
                {
                    Log(LogSeverity.Warning, $"Discarding a channel pins update for the uncached private channel: {model.ChannelId}.");
                    return Task.CompletedTask;
                }

                oldLastPinTimestamp = privateChannel.LastPinTimestamp;
                privateChannel.LastPinTimestamp = model.LastPinTimestamp;
                channel = privateChannel;
            }

            return _client._channelPinsUpdated.InvokeAsync(new ChannelPinsUpdatedEventArgs(channel, oldLastPinTimestamp));
        }
    }
}
