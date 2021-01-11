using Discord.Serialization.Json;

namespace Discord.Rest
{
    internal sealed class ModifyPositionsContent
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }
}
