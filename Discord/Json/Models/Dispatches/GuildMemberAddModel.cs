using Discord.Serialization.Json;

namespace Discord.Models.Dispatches
{
    internal sealed class GuildMemberAddModel : MemberModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }
    }
}
