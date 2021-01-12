﻿using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleGuildBanAddAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<GuildBanAddModel>();
            var guild = GetGuild(model.GuildId);
            var user = guild._members.TryGetValue(model.User.Id, out var member)
                ? member
                : GetSharedOrUnknownUser(model.User);

            return _client._memberBanned.InvokeAsync(new MemberBannedEventArgs(guild, user));
        }
    }
}
