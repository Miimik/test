namespace SkyDiscord.Rest
{
    /// <summary>
    ///     Represents a REST SkyDiscord entity.
    /// </summary>
    public abstract class RestDiscordEntity : ISkyDiscordEntity
    {
        /// <inheritdoc cref="ISkyDiscordEntity.Client"/>
        public RestDiscordClient Client { get; }

        IRestDiscordClient ISkyDiscordEntity.Client => Client;

        internal RestDiscordEntity(RestDiscordClient client)
        {
            Client = client;
        }
    }
}
