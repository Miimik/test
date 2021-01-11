using System.Threading.Tasks;
using Discord.Rest;

namespace Discord
{
    public partial interface IGuildChannel : IChannel, IDeletable
    {
        Task AddOrModifyOverwriteAsync(LocalOverwrite overwrite, RestRequestOptions options = null);

        Task DeleteOverwriteAsync(Snowflake targetId, RestRequestOptions options = null);
    }
}
