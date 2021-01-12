using System.Net.Http;
using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Rest
{
    internal interface IRequestContent
    {
        HttpContent Prepare(IJsonSerializer serializer, RestRequestOptions options);
    }
}
