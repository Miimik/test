﻿using System.Threading.Tasks;
using SkyDiscord.Collections;
using SkyDiscord.Events;
using SkyDiscord.Logging;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleMessageDeleteBulkAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<MessageDeleteBulkModel>();
            if (model.GuildId == null)
            {
                Log(LogSeverity.Error, $"MessageDeleteBulk contains a null guild_id. Channel id: {model.ChannelId}.");
                return Task.CompletedTask;
            }

            var guild = GetGuild(model.GuildId.Value);
            var channel = guild.GetTextChannel(model.ChannelId);
            var messages = new SnowflakeOptional<CachedUserMessage>[model.Ids.Length];
            for (var i = 0; i < model.Ids.Length; i++)
            {
                var id = model.Ids[i];
                CachedUserMessage message = null;
                _messageCache?.TryRemoveMessage(channel.Id, id, out message);
                messages[i] = new SnowflakeOptional<CachedUserMessage>(message, id);
            }

            return _client._messagesBulkDeleted.InvokeAsync(new MessagesBulkDeletedEventArgs(channel, messages.ReadOnly()));
        }
    }
}
