using System;

namespace Discord
{
    /// <summary>
    ///     Provides utilities related to the Discord library.
    /// </summary>
    public static partial class Library
    {
        /// <summary>
        ///     Discord build's version.
        /// </summary>
        public static readonly Version Version = typeof(Library).Assembly.GetName().Version;

        // TODO: set at compile-time
        ///// <summary>
        /////     Discord build's date.
        ///// </summary>
        //public static readonly DateTimeOffset BuiltAt;

        /// <summary>
        ///     Discord's repository url.
        /// </summary>
        public const string RepositoryUrl = "https://github.com/Quahu/Discord";

        /// <summary>
        ///     Discord's user agent.
        /// </summary>
        public static readonly string UserAgent = $"DiscordBot ({RepositoryUrl}, {Version.ToString(3)})";
    }
}