using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Logging;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleMessageDeleteAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<MessageDeleteModel>();
            var channel = model.GuildId != null
                ? GetGuildChannel(model.ChannelId) as ICachedMessageChannel
                : GetPrivateChannel(model.ChannelId);

            if (channel == null)
            {
                Log(LogSeverity.Warning, $"Uncached channel in MessageDeleted. Id: {model.ChannelId}");
                return Task.CompletedTask;
            }

            CachedUserMessage message = null;
            _messageCache?.TryRemoveMessage(channel.Id, model.Id, out message);

            return _client._messageDeleted.InvokeAsync(new MessageDeletedEventArgs(channel,
                new SnowflakeOptional<CachedUserMessage>(message, model.Id)));
        }
    }
}
