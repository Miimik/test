using System.Threading.Tasks;
using Discord.Events;
using Discord.Models;
using Discord.Models.Dispatches;

namespace Discord
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
