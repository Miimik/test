﻿using System;
using System.Threading.Tasks;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    public sealed partial class CachedVoiceChannel : CachedNestedChannel, IVoiceChannel
    {
        public async Task ModifyAsync(Action<ModifyVoiceChannelProperties> action, RestRequestOptions options = null)
        {
            var model = await Client.RestClient.InternalModifyChannelAsync(Id, action, options).ConfigureAwait(false);
            Update(model);
        }
    }
}
