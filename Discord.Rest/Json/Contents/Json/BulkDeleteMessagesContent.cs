using System.Collections.Generic;
using Discord.Serialization.Json;

namespace Discord.Rest
{
    internal sealed class BulkDeleteMessagesContent : JsonRequestContent
    {
        [JsonProperty("messages")]
        public IEnumerable<ulong> Messages { get; set; }
    }
}
