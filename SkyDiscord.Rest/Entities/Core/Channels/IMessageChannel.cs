using System;

namespace SkyDiscord
{
    public partial interface IMessageChannel : IChannel, IMessagable
    {
        Snowflake? LastMessageId { get; }

        DateTimeOffset? LastPinTimestamp { get; }
    }
}
