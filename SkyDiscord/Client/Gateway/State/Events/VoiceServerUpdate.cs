using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleVoiceServerUpdateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<VoiceServerUpdateModel>();
            if (model.GuildId == null)
                return Task.CompletedTask;

            var guild = GetGuild(model.GuildId.Value);
            return _client._voiceServerUpdated.InvokeAsync(new VoiceServerUpdatedEventArgs(guild, model.Token, model.Endpoint));
        }
    }
}
