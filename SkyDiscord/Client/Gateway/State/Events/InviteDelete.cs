using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleInviteDeleteAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<InviteDeleteModel>();
            return _client._inviteDeleted.InvokeAsync(new InviteDeletedEventArgs(_client, model.GuildId, model.ChannelId, model.Code));
        }
    }
}
