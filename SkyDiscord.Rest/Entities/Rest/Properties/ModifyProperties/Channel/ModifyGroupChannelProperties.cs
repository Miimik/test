using System.IO;

namespace SkyDiscord
{
    public class ModifyGroupChannelProperties : ModifyChannelProperties
    {
        public Optional<Stream> Icon { internal get; set; }

        internal ModifyGroupChannelProperties()
        { }
    }
}
