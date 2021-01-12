using System.IO;
using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Rest
{
    internal sealed class CreateWebhookContent : JsonRequestContent
    {
        [JsonProperty("name", NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("avatar", NullValueHandling.Ignore)]
        public Stream Avatar { get; set; }
    }
}
