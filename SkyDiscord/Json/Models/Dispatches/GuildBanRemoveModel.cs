using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models.Dispatches
{
    internal sealed class GuildBanRemoveModel : JsonModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("user")]
        public UserModel User { get; set; }
    }
}
