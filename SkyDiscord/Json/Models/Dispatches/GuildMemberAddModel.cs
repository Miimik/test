using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models.Dispatches
{
    internal sealed class GuildMemberAddModel : MemberModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }
    }
}
