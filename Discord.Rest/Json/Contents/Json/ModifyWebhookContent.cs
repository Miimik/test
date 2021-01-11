using System.IO;
using Discord.Serialization.Json;

namespace Discord.Rest
{
    internal sealed class ModifyWebhookContent : JsonRequestContent
    {
        [JsonProperty("name")]
        public Optional<string> Name { get; set; }

        [JsonProperty("avatar")]
        public Optional<Stream> Avatar { get; set; }

        [JsonProperty("channel_id")]
        public Optional<ulong> ChannelId { get; set; }
    }
}
