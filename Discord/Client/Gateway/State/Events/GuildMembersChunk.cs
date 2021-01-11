﻿using System;
using System.Threading.Tasks;
using Discord.Logging;
using Discord.Models;
using Discord.Models.Dispatches;

namespace Discord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleGuildMembersChunkAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<GuildMembersChunkModel>();
            var guild = GetGuild(model.GuildId);
            Log(LogSeverity.Debug, $"Received a member chunk with {model.Members.Length} members for {guild} ({guild.Id}).");
            if (--guild.ChunksExpected == 0)
            {
                guild.ChunkTcs.SetResult(true);
                GC.Collect();
            }

            guild.Update(model);
            return Task.CompletedTask;
        }
    }
}
