using Discord.Serialization.Json;

namespace Discord.Rest
{
    internal sealed class CreateDmContent : JsonRequestContent
    {
        [JsonProperty("recipient_id")]
        public ulong RecipientId { get; set; }
    }
}
