﻿using System;
using System.Threading.Tasks;

namespace Discord.Rest
{
    public sealed partial class RestCurrentUser : RestUser, ICurrentUser
    {
        public Task ModifyAsync(Action<ModifyCurrentUserProperties> action, RestRequestOptions options = null)
            => Client.ModifyCurrentUserAsync(action, options);
    }
}