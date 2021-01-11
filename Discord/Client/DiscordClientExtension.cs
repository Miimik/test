using System;
using System.Threading.Tasks;

namespace Discord
{
    public abstract class DiscordClientExtension : IAsyncDisposable
    {
        public DiscordClientBase Client { get; internal set; }

        protected internal abstract ValueTask InitialiseAsync();

        public virtual ValueTask DisposeAsync()
            => default;
    }
}