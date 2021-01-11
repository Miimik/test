using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class ReactionModel : JsonModel
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("me")]
        public bool Me { get; set; }

        [JsonProperty("emoji")]
        public EmojiModel Emoji { get; set; }
    }
}