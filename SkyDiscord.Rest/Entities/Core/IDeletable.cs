using System.Threading.Tasks;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    /// <summary>
    ///     Represents a deletable SkyDiscord entity.
    /// </summary>
    public interface IDeletable : ISkyDiscordEntity
    {
        /// <summary>
        ///     Deletes this entity.
        /// </summary>
        /// <param name="options"> The request options. </param>
        Task DeleteAsync(RestRequestOptions options = null);
    }
}
