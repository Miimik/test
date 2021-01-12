﻿using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleMessageReactionRemoveEmojiAsync(PayloadModel payload)
        {
            // TODO: intents will ruin everything
            var model = payload.D.ToType<MessageReactionRemoveEmojiModel>();
            var channel = GetGuild(model.GuildId).GetTextChannel(model.ChannelId);
            var message = channel.GetMessage(model.MessageId);
            var emoji = model.Emoji.ToEmoji();
            ReactionData data = null;
            message?._reactions.TryRemove(emoji, out data);

            var messageOptional = FetchableSnowflakeOptional.Create<CachedMessage, RestMessage, IMessage>(
                model.MessageId, message, RestFetchable.Create((this, model), (tuple, options) =>
                {
                    var (@this, model) = tuple;
                    return @this._client.GetMessageAsync(model.ChannelId, model.MessageId, options);
                }));
            return _client._emojiReactionsCleared.InvokeAsync(new EmojiReactionsClearedEventArgs(
                channel, messageOptional, emoji, data));
        }
    }
}
