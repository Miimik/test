using System;
using System.Threading.Tasks;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleGuildSyncAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<GuildSyncModel>();
            var guild = GetGuild(model.Id);
            guild?.Update(model);
            guild.SyncTcs.SetResult(true);
            GC.Collect();
            return Task.CompletedTask;
        }
    }
}
