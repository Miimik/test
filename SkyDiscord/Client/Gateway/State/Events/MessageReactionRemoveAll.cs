﻿using System.Linq;
using System.Threading.Tasks;
using SkyDiscord.Collections;
using SkyDiscord.Events;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleMessageReactionRemoveAllAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<MessageReactionRemoveAllModel>();
            var channel = GetGuild(model.GuildId).GetTextChannel(model.ChannelId);
            var message = channel.GetMessage(model.MessageId);
            var reactions = message?._reactions.ToDictionary(x => x.Key, x => x.Value);
            message?._reactions.Clear();

            var messageOptional = FetchableSnowflakeOptional.Create<CachedMessage, RestMessage, IMessage>(
                model.MessageId, message, RestFetchable.Create((this, model), (tuple, options) =>
                {
                    var (@this, model) = tuple;
                    return @this._client.GetMessageAsync(model.ChannelId, model.MessageId, options);
                }));
            return _client._reactionsCleared.InvokeAsync(new ReactionsClearedEventArgs(
                channel, messageOptional, reactions?.ReadOnly() ?? ReadOnlyDictionary<IEmoji, ReactionData>.Empty));
        }
    }
}
