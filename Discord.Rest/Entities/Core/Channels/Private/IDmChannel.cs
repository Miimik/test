using System.Threading.Tasks;
using Discord.Rest;

namespace Discord
{
    public interface IDmChannel : IPrivateChannel
    {
        IUser Recipient { get; }

        Task CloseAsync(RestRequestOptions options = null)
            => Client.DeleteOrCloseChannelAsync(Id, options);
    }
}
