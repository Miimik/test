using System.Threading.Tasks;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    public partial interface IGuildChannel : IChannel, IDeletable
    {
        Task AddOrModifyOverwriteAsync(LocalOverwrite overwrite, RestRequestOptions options = null);

        Task DeleteOverwriteAsync(Snowflake targetId, RestRequestOptions options = null);
    }
}
