using System.Runtime.Serialization;
using SkyDiscord.Serialization.Json;

namespace SkyDiscord
{
    /// <summary>
    ///     Represents various user statuses.
    /// </summary>
    [StringEnum]
    public enum UserStatus
    {
        /// <summary>
        ///     Represents an offline user.
        /// </summary>
        [EnumMember(Value = "offline")]
        Offline,

        /// <summary>
        ///     Represents an invisible user.
        /// </summary>
        [EnumMember(Value = "invisible")]
        Invisible,

        /// <summary>
        ///     Represents an idle user.
        /// </summary>
        [EnumMember(Value = "idle")]
        Idle,

        /// <summary>
        ///     Represents a user who wishes to not be disturbed.
        /// </summary>
        [EnumMember(Value = "dnd")]
        DoNotDisturb,

        /// <summary>
        ///     Represents an online user.
        /// </summary>
        [EnumMember(Value = "online")]
        Online
    }
}
