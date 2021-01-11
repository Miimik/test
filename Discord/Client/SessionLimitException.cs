using System;

namespace Discord
{
    public sealed class SessionLimitException : Exception
    {
        public TimeSpan ResetsAfter { get; }

        internal SessionLimitException(TimeSpan resetsAfter)
        {
            ResetsAfter = resetsAfter;
        }
    }
}