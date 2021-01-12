using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Rest
{
    internal sealed class ModifyCurrentUserNickContent : JsonRequestContent
    {
        [JsonProperty("nick")]
        public Optional<string> Nick { get; set; }
    }
}
