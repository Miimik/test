﻿using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleGuildMemberUpdateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<GuildMemberUpdateModel>();
            var guild = GetGuild(model.GuildId);
            var member = guild.GetMember(model.User.Id);
            CachedMember oldMember;
            if (member != null)
            {
                oldMember = member.Clone();
                member.Update(model);
            }
            else
            {
                oldMember = null;
                member = AddMember(guild, new MemberModel
                {
                    Nick = model.Nick,
                    Roles = model.Roles
                }, model.User, true);
            }

            return _client._memberUpdated.InvokeAsync(new MemberUpdatedEventArgs(oldMember, member));
        }
    }
}
