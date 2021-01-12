using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleGuildMemberAddAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<GuildMemberAddModel>();
            var guild = GetGuild(model.GuildId);
            var member = AddMember(guild, model, model.User);

            return _client._memberJoined.InvokeAsync(new MemberJoinedEventArgs(member));
        }
    }
}
