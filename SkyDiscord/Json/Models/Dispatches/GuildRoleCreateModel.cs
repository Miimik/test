using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models.Dispatches
{
    internal sealed class GuildRoleCreateModel : JsonModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("role")]
        public RoleModel Role { get; set; }
    }
}
