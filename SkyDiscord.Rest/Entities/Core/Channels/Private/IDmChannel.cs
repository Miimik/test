using System.Threading.Tasks;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    public interface IDmChannel : IPrivateChannel
    {
        IUser Recipient { get; }

        Task CloseAsync(RestRequestOptions options = null)
            => Client.DeleteOrCloseChannelAsync(Id, options);
    }
}
