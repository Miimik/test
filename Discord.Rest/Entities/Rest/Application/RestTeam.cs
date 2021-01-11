using System.Collections.Generic;
using Discord.Collections;
using Discord.Models;

namespace Discord.Rest
{
    public sealed class RestTeam : RestSnowflakeEntity
    {
        public string Name { get; }

        public string IconHash { get; }

        public Snowflake OwnerId { get; }

        public RestTeamMember Owner => Members.GetValueOrDefault(OwnerId);

        public IReadOnlyDictionary<Snowflake, RestTeamMember> Members { get; }

        internal RestTeam(RestDiscordClient client, TeamModel model) : base(client, model.Id)
        {
            Name = model.Name;
            IconHash = model.Icon;
            OwnerId = model.OwnerUserId;
            Members = model.Members.ToReadOnlyDictionary(
                (x, _) => new Snowflake(x.User.Id), (x, @this) => new RestTeamMember(@this, x), this);
        }
    }
}