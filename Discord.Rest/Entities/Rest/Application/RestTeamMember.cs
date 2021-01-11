using System.Collections.Generic;
using Discord.Collections;
using Discord.Models;

namespace Discord.Rest
{
    public sealed class RestTeamMember : RestUser
    {
        public RestTeam Team { get; }

        public TeamMembershipState MembershipState { get; }

        public IReadOnlyList<string> Permissions { get; }

        internal RestTeamMember(RestTeam team, TeamMemberModel model) : base(team.Client, model.User)
        {
            Team = team;
            MembershipState = model.MembershipState;
            Permissions = model.Permissions.ReadOnly();
        }
    }
}