using System.Threading.Tasks;

namespace SkyDiscord.Rest
{
    public partial class RestDiscordClient : IRestDiscordClient
    {
        public Task<RestApplication> GetCurrentApplicationAsync(RestRequestOptions options = null)
            => CurrentApplication.FetchAsync(options);
    }
}
