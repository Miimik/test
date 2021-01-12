﻿using System.Threading.Tasks;
using SkyDiscord.Events;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleInviteCreateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<InviteCreateModel>();
            CachedGuild guild = null;
            CachedChannel channel;
            CachedUser inviter = null;
            if (model.GuildId != null)
            {
                guild = GetGuild(model.GuildId.Value);
                channel = guild.GetChannel(model.ChannelId);

                if (model.Inviter.HasValue)
                    inviter = guild.GetMember(model.Inviter.Value.Id);
            }
            else
            {
                channel = GetPrivateChannel(model.ChannelId);

                if (model.Inviter.HasValue)
                    inviter = GetUser(model.Inviter.Value.Id);
            }

            if (inviter == null && model.Inviter.HasValue)
                inviter = new CachedUnknownUser(_client, model.Inviter.Value);

            return _client._inviteCreated.InvokeAsync(new InviteCreatedEventArgs(
                _client, guild, new SnowflakeOptional<CachedChannel>(channel, model.ChannelId),
                inviter, model.Code, model.Temporary, model.MaxUses, model.MaxAge, model.CreatedAt));
        }
    }
}
