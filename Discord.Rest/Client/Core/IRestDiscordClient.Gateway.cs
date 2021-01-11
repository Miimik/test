using System;
using System.Threading.Tasks;

namespace Discord.Rest
{
    public partial interface IRestDiscordClient : IDisposable
    {
        Task<string> GetGatewayUrlAsync(RestRequestOptions options = null);

        Task<RestGatewayBotResponse> GetGatewayBotUrlAsync(RestRequestOptions options = null);
    }
}
