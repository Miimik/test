﻿using System;

namespace Discord
{
    public partial interface IMessageChannel : IChannel, IMessagable
    {
        Snowflake? LastMessageId { get; }

        DateTimeOffset? LastPinTimestamp { get; }
    }
}
