using Discord.Serialization.Json;

namespace Discord.Models.Dispatches
{
    internal sealed class GuildRoleDeleteModel : JsonModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("role_id")]
        public ulong RoleId { get; set; }
    }
}
