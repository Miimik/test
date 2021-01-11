﻿using System.Collections.Generic;

namespace Discord
{
    public partial interface IGuildChannel : IChannel, IDeletable
    {
        Snowflake GuildId { get; }

        int Position { get; }

        IReadOnlyList<IOverwrite> Overwrites { get; }
    }
}
