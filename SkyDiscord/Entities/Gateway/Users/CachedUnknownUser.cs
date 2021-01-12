﻿using System;
using SkyDiscord.Models;
using SkyDiscord.Models.Dispatches;

namespace SkyDiscord
{
    public sealed class CachedUnknownUser : CachedUser
    {
        public override Presence Presence => null;

        internal override CachedSharedUser SharedUser => throw new InvalidOperationException("An unknown user has no shared user tied to it.");

        internal CachedUnknownUser(DiscordClientBase client, UserModel model) : base(client, model)
        {
            Update(model);
        }

        internal override void Update(PresenceUpdateModel model)
            => throw new InvalidOperationException();
    }
}
