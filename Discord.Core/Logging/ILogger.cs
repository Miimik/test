using System;
using Discord.Logging.Default;

namespace Discord.Logging
{
    public interface ILogger : IDisposable
    {
        event EventHandler<LogEventArgs> Logged;

        void Log(object sender, LogEventArgs e);

        internal static ILogger CreateDefault() => new DefaultLogger();
    }
}
