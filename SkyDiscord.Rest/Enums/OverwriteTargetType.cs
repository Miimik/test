using System.Runtime.Serialization;
using SkyDiscord.Serialization.Json;

namespace SkyDiscord
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
