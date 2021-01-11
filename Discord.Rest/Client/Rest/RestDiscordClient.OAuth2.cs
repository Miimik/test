using System.Threading.Tasks;

namespace Discord.Rest
{
    public partial class RestDiscordClient : IRestDiscordClient
    {
        public Task<RestApplication> GetCurrentApplicationAsync(RestRequestOptions options = null)
            => CurrentApplication.FetchAsync(options);
    }
}
