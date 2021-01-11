﻿using System.Threading.Tasks;
using Discord.Events;
using Discord.Models;

namespace Discord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleVoiceStateUpdateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<VoiceStateModel>();

            if (model.GuildId == null)
                return Task.CompletedTask;

            var guild = GetGuild(model.GuildId.Value);
            var member = GetOrAddMember(guild, model.Member, model.Member.User);
            var oldVoiceState = member.VoiceState?.Clone();
            member.Update(model);

            return _client._voiceStateUpdated.InvokeAsync(new VoiceStateUpdatedEventArgs(member, oldVoiceState));
        }
    }
}
