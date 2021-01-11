using Discord.Serialization.Json;

namespace Discord.Rest
{
    internal sealed class AddGroupRecipientContent : JsonRequestContent
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("nick")]
        public string Nick { get; set; }
    }
}
