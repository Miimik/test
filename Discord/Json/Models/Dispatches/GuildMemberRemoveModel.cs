using Discord.Serialization.Json;

namespace Discord.Models.Dispatches
{
    internal sealed class GuildMemberRemoveModel : JsonModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("user")]
        public UserModel User { get; set; }
    }
}
