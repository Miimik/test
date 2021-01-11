using System;
using System.Threading.Tasks;
using Discord.Rest;

namespace Discord
{
    public partial interface IVoiceChannel : IGuildChannel
    {
        Task ModifyAsync(Action<ModifyVoiceChannelProperties> action, RestRequestOptions options = null);
    }
}
