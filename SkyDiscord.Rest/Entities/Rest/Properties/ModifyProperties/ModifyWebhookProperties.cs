using System.IO;

namespace SkyDiscord
{
    public sealed class ModifyWebhookProperties
    {
        public Optional<string> Name { internal get; set; }

        public Optional<Stream> Avatar { internal get; set; }

        public Optional<Snowflake> ChannelId { internal get; set; }

        internal ModifyWebhookProperties()
        { }

        internal bool HasValues
            => Name.HasValue || Avatar.HasValue || ChannelId.HasValue;
    }
}
