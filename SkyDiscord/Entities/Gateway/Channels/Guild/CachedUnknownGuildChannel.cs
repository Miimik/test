using SkyDiscord.Models;

namespace SkyDiscord
{
    public sealed class CachedUnknownGuildChannel : CachedGuildChannel, IUnknownGuildChannel
    {
        public byte Type { get; }

        internal CachedUnknownGuildChannel(CachedGuild guild, ChannelModel model) : base(guild, model)
        {
            Type = (byte) model.Type.Value;
        }
    }
}
