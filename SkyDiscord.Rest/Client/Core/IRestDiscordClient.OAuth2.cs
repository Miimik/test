using System;
using System.Threading.Tasks;

namespace SkyDiscord.Rest
{
    public partial interface IRestDiscordClient : IDisposable
    {
        Task<RestApplication> GetCurrentApplicationAsync(RestRequestOptions options = null);
    }
}
