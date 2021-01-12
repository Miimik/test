﻿using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Logging;
using SkyDiscord.Models;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleMessageCreateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<MessageModel>();
            ICachedMessageChannel channel;
            CachedUser author;
            CachedGuild guild = null;
            var isWebhook = model.WebhookId.HasValue;
            if (model.GuildId != null)
            {
                guild = GetGuild(model.GuildId.Value);
                channel = guild.GetTextChannel(model.ChannelId);
            }
            else
            {
                channel = GetPrivateChannel(model.ChannelId);
            }

            if (isWebhook)
            {
                author = new CachedUnknownUser(_client, model.Author.Value);
            }
            else
            {
                if (model.GuildId != null)
                {
                    author = model.Author.HasValue && model.Member.HasValue
                        ? GetOrAddMember(guild, model.Member.Value, model.Author.Value)
                        : guild.GetMember(model.Author.Value.Id);
                }
                else
                {
                    author = GetUser(model.Author.Value.Id);
                }
            }

            if (author == null && !isWebhook)
            {
                Log(LogSeverity.Warning, $"Uncached author and/or guild == null in MESSAGE_CREATE.\n{payload.D}");
                return Task.CompletedTask;
            }

            var message = CachedMessage.Create(channel, author, model);
            if (message is CachedUserMessage userMessage)
                _messageCache?.TryAddMessage(userMessage);

            if (guild != null)
                (channel as CachedTextChannel).LastMessageId = message.Id;
            else
                (channel as CachedPrivateChannel).LastMessageId = message.Id;

            return _client._messageReceived.InvokeAsync(new MessageReceivedEventArgs(message));
        }
    }
}
