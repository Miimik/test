using System.IO;

namespace Discord
{
    public class ModifyGroupChannelProperties : ModifyChannelProperties
    {
        public Optional<Stream> Icon { internal get; set; }

        internal ModifyGroupChannelProperties()
        { }
    }
}
