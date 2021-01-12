using SkyDiscord.Rest;

namespace SkyDiscord
{
    /// <summary>
    ///     Represents a SkyDiscord entity.
    /// </summary>
    public interface ISkyDiscordEntity
    {
        /// <summary>
        ///     Gets the client that created this entity.
        /// </summary>
        IRestDiscordClient Client { get; }
    }
}
