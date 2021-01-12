using System.Threading.Tasks;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    public partial interface IUser : IMessagable, IMentionable, ITaggable
    {
        Task<RestDmChannel> CreateDmChannelAsync(RestRequestOptions options = null);
    }
}
