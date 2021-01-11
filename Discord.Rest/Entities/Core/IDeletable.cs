using System.Threading.Tasks;
using Discord.Rest;

namespace Discord
{
    /// <summary>
    ///     Represents a deletable Discord entity.
    /// </summary>
    public interface IDeletable : IDiscordEntity
    {
        /// <summary>
        ///     Deletes this entity.
        /// </summary>
        /// <param name="options"> The request options. </param>
        Task DeleteAsync(RestRequestOptions options = null);
    }
}
