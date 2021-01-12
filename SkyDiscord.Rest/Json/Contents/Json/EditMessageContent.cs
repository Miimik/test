using SkyDiscord.Models;
using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Rest
{
    internal sealed class EditMessageContent : JsonRequestContent
    {
        [JsonProperty("content")]
        public Optional<string> Content { get; set; }

        [JsonProperty("embed")]
        public Optional<EmbedModel> Embed { get; set; }

        [JsonProperty("flags")]
        public Optional<MessageFlags> Flags { get; set; }
    }
}
