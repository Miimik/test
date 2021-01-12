using System.Collections.Generic;

namespace SkyDiscord
{
    public abstract class ModifyGuildChannelProperties : ModifyChannelProperties
    {
        public Optional<int> Position { internal get; set; }

        public Optional<IEnumerable<LocalOverwrite>> Overwrites { internal get; set; }

        internal ModifyGuildChannelProperties()
        { }
    }
}
