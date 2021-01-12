using System;

namespace SkyDiscord
{
    /// <summary>
    ///     Represents a SkyDiscord entity with a unique <see cref="Snowflake"/> ID.
    /// </summary>
    public interface ISnowflakeEntity : ISkyDiscordEntity
    {
        /// <summary>
        ///     Gets the ID of this entity.
        /// </summary>
        Snowflake Id { get; }

        /// <summary>
        ///     Gets the creation date of this entity.
        ///     Short for <see cref="Snowflake.CreatedAt"/> using <see cref="Id"/>.
        /// </summary>
        DateTimeOffset CreatedAt { get; }
    }
}
