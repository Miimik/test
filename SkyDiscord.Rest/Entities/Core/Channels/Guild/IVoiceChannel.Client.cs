using System;
using System.Threading.Tasks;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    public partial interface IVoiceChannel : IGuildChannel
    {
        Task ModifyAsync(Action<ModifyVoiceChannelProperties> action, RestRequestOptions options = null);
    }
}
