using System;

namespace SkyDiscord
{
    public enum TokenType : byte
    {
        Bearer,

        Bot,

        [Obsolete("User tokens and logins are not supported.")]
        User
    }
}
