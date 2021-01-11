using System.Runtime.Serialization;
using Discord.Serialization.Json;

namespace Discord
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
