using System;
using System.Net;

namespace SkyDiscord.Rest
{
    public sealed class SkyDiscordHttpException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; }

        public JsonErrorCode? JsonErrorCode { get; }

        public SkyDiscordHttpException(HttpStatusCode httpStatusCode, int? jsonErrorCode, string message) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            JsonErrorCode = (JsonErrorCode?) jsonErrorCode;
        }

        public override string ToString()
            => $"{(int) HttpStatusCode} {HttpStatusCode}: {Message}";
    }
}
