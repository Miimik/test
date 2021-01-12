using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleGuildEmojisUpdateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<GuildEmojisUpdateModel>();
            var guild = GetGuild(model.GuildId);
            var oldEmojis = guild.Emojis;
            guild.Update(model.Emojis);

            return _client._guildEmojisUpdated.InvokeAsync(new GuildEmojisUpdatedEventArgs(guild, oldEmojis));
        }
    }
}
