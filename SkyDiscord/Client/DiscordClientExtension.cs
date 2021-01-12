using System;
using System.Threading.Tasks;

namespace SkyDiscord
{
    public abstract class DiscordClientExtension : IAsyncDisposable
    {
        public DiscordClientBase Client { get; internal set; }

        protected internal abstract ValueTask InitialiseAsync();

        public virtual ValueTask DisposeAsync()
            => default;
    }
}