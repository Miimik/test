using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkyDiscord.Rest
{
    public partial interface IRestDiscordClient : IDisposable
    {
        Task<IReadOnlyList<RestVoiceRegion>> GetVoiceRegionsAsync(RestRequestOptions options = null);
    }
}
