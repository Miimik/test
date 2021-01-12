using System.Collections.Generic;
using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Rest
{
    internal sealed class BulkDeleteMessagesContent : JsonRequestContent
    {
        [JsonProperty("messages")]
        public IEnumerable<ulong> Messages { get; set; }
    }
}
