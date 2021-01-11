using Discord.Rest;

namespace Discord
{
    /// <summary>
    ///     Represents a Discord entity.
    /// </summary>
    public interface IDiscordEntity
    {
        /// <summary>
        ///     Gets the client that created this entity.
        /// </summary>
        IRestDiscordClient Client { get; }
    }
}
