using Discord.Serialization.Json;

namespace Discord.Models.Dispatches
{
    internal sealed class VoiceServerUpdateModel : JsonModel
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("guild_id")]
        public ulong? GuildId { get; set; }

        [JsonProperty("endpoint")]
        public string Endpoint { get; set; }
    }
}
