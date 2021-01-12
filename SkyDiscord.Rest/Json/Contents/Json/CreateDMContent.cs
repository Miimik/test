using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Rest
{
    internal sealed class CreateDmContent : JsonRequestContent
    {
        [JsonProperty("recipient_id")]
        public ulong RecipientId { get; set; }
    }
}
