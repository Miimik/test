using System.Threading.Tasks;
using Discord.Rest;

namespace Discord
{
    public partial interface IGroupChannel : IPrivateChannel, IDeletable
    {
        Task LeaveAsync(RestRequestOptions options = null);

        Task IDeletable.DeleteAsync(RestRequestOptions options)
            => LeaveAsync(options);
    }
}
