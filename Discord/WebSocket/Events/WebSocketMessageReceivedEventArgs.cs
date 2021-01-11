using System;
using System.IO;

namespace Discord.WebSocket
{
    internal sealed class WebSocketMessageReceivedEventArgs : EventArgs
    {
        public Stream Stream { get; }

        public WebSocketMessageReceivedEventArgs(Stream stream)
        {
            Stream = stream;
        }
    }
}
