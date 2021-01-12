﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    public abstract partial class CachedUser : CachedSnowflakeEntity, IUser
    {
        public Task<RestDmChannel> CreateDmChannelAsync(RestRequestOptions options = null)
            => Client.CreateDmChannelAsync(Id, options);

        public async Task<RestUserMessage> SendMessageAsync(string content = null, bool textToSpeech = false, LocalEmbed embed = null, LocalMentions mentions = null, RestRequestOptions options = null)
        {
            var channel = await CreateDmChannelAsync(options).ConfigureAwait(false);
            return await channel.SendMessageAsync(content, textToSpeech, embed, mentions, options).ConfigureAwait(false);
        }

        public async Task<RestUserMessage> SendMessageAsync(LocalAttachment attachment, string content = null, bool textToSpeech = false, LocalEmbed embed = null, LocalMentions mentions = null, RestRequestOptions options = null)
        {
            var channel = await CreateDmChannelAsync(options).ConfigureAwait(false);
            return await channel.SendMessageAsync(attachment, content, textToSpeech, embed, mentions, options).ConfigureAwait(false);
        }

        public async Task<RestUserMessage> SendMessageAsync(IEnumerable<LocalAttachment> attachments, string content = null, bool textToSpeech = false, LocalEmbed embed = null, LocalMentions mentions = null, RestRequestOptions options = null)
        {
            var channel = await CreateDmChannelAsync(options).ConfigureAwait(false);
            return await channel.SendMessageAsync(attachments, content, textToSpeech, embed, mentions, options).ConfigureAwait(false);
        }
    }
}
