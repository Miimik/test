using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discord.Rest
{
    public partial interface IRestDiscordClient : IDisposable
    {
        Task<IReadOnlyList<RestVoiceRegion>> GetVoiceRegionsAsync(RestRequestOptions options = null);
    }
}
