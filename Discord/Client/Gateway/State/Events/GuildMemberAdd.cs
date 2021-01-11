using System.Threading.Tasks;
using Discord.Events;
using Discord.Models;
using Discord.Models.Dispatches;

namespace Discord
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
