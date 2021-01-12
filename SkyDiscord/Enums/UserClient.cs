using System.Runtime.Serialization;
using SkyDiscord.Serialization.Json;

namespace SkyDiscord
{
    [StringEnum]
    public enum UserClient
    {
        [EnumMember(Value = "desktop")]
        Desktop,

        [EnumMember(Value = "mobile")]
        Mobile,

        [EnumMember(Value = "web")]
        Web
    }
}
