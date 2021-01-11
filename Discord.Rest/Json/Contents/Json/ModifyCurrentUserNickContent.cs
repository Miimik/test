using Discord.Serialization.Json;

namespace Discord.Rest
{
    internal sealed class ModifyCurrentUserNickContent : JsonRequestContent
    {
        [JsonProperty("nick")]
        public Optional<string> Nick { get; set; }
    }
}
