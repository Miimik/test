using System.Collections.Generic;
using System.Threading.Tasks;
using SkyDiscord.Collections;

namespace SkyDiscord.Rest
{
    public partial class RestDiscordClient : IRestDiscordClient
    {
        public async Task<IReadOnlyList<RestVoiceRegion>> GetVoiceRegionsAsync(RestRequestOptions options = null)
        {
            var models = await ApiClient.ListVoiceRegionsAsync(options).ConfigureAwait(false);
            return models.ToReadOnlyList(this, (x, @this) => new RestVoiceRegion(@this, x));
        }
    }
}
