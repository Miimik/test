using Discord.Serialization.Json;

namespace Discord.Models.Dispatches
{
    internal sealed class GuildRoleCreateModel : JsonModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("role")]
        public RoleModel Role { get; set; }
    }
}
