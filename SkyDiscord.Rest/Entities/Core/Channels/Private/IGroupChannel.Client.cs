using System.Threading.Tasks;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    public partial interface IGroupChannel : IPrivateChannel, IDeletable
    {
        Task LeaveAsync(RestRequestOptions options = null);

        Task IDeletable.DeleteAsync(RestRequestOptions options)
            => LeaveAsync(options);
    }
}
