using System;

namespace SkyDiscord
{
    /// <summary>
    ///     Provides utilities related to the SkyDiscord library.
    /// </summary>
    public static partial class Library
    {
        /// <summary>
        ///     SkyDiscord build's version.
        /// </summary>
        public static readonly Version Version = typeof(Library).Assembly.GetName().Version;

        // TODO: set at compile-time
        ///// <summary>
        /////     SkyDiscord build's date.
        ///// </summary>
        //public static readonly DateTimeOffset BuiltAt;

        /// <summary>
        ///     SkyDiscord's repository url.
        /// </summary>
        public const string RepositoryUrl = "https://github.com/Quahu/SkyDiscord";

        /// <summary>
        ///     SkyDiscord's user agent.
        /// </summary>
        public static readonly string UserAgent = $"SkyDiscordBot ({RepositoryUrl}, {Version.ToString(3)})";
    }
}