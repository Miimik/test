using System.Collections.Generic;
using System.IO;
using Discord.Serialization.Json;

namespace Discord.Rest
{
    internal sealed class CreateGuildEmojiContent : JsonRequestContent
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public Stream Image { get; set; }

        [JsonProperty("roles", NullValueHandling.Ignore)]
        public IReadOnlyList<ulong> RoleIds { get; set; }
    }
}
