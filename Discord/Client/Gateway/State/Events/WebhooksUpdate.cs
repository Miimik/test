using System.Threading.Tasks;
using Discord.Events;
using Discord.Models;
using Discord.Models.Dispatches;

namespace Discord
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
