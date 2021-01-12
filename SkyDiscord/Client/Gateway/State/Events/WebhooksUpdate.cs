﻿using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleWebhooksUpdateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<WebhooksUpdateModel>();
            return _client._webhooksUpdated.InvokeAsync(new WebhooksUpdatedEventArgs(_client, model.GuildId, model.ChannelId));
        }
    }
}
