﻿using Discord.Models;

namespace Discord
{
    /// <summary>
    ///     Represents a user's streaming activity.
    /// </summary>
    public sealed class StreamingActivity : Activity
    {
        public string Url { get; }

        internal StreamingActivity(ActivityModel model) : base(model)
        {
            Url = model.Url;
        }
    }
}
