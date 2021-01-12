using System;

namespace SkyDiscord
{
    public interface IEmoji : IEquatable<IEmoji>
    {
        string Name { get; }

        string ReactionFormat { get; }

        string MessageFormat { get; }
    }
}
