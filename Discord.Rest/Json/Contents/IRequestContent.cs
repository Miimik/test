using System.Net.Http;
using Discord.Serialization.Json;

namespace Discord.Rest
{
    internal interface IRequestContent
    {
        HttpContent Prepare(IJsonSerializer serializer, RestRequestOptions options);
    }
}
