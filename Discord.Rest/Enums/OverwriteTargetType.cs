using System.Runtime.Serialization;
using Discord.Serialization.Json;

namespace Discord
{
    [StringEnum]
    public enum OverwriteTargetType : byte
    {
        [EnumMember(Value = "role")]
        Role,

        [EnumMember(Value = "member")]
        Member
    }
}
