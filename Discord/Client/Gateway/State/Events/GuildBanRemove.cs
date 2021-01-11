using System.Threading.Tasks;
using Discord.Events;
using Discord.Models;
using Discord.Models.Dispatches;

namespace Discord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleGuildBanRemoveAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<GuildBanRemoveModel>();
            var guild = GetGuild(model.GuildId);
            var user = GetSharedOrUnknownUser(model.User);

            return _client._memberUnbanned.InvokeAsync(new MemberUnbannedEventArgs(guild, user));
        }
    }
}
