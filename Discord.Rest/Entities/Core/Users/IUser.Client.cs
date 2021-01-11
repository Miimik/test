using System.Threading.Tasks;
using Discord.Rest;

namespace Discord
{
    public partial interface IUser : IMessagable, IMentionable, ITaggable
    {
        Task<RestDmChannel> CreateDmChannelAsync(RestRequestOptions options = null);
    }
}
