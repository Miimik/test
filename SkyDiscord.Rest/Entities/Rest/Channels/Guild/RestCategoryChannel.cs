using SkyDiscord.Models;

namespace SkyDiscord.Rest
{
    public sealed partial class RestCategoryChannel : RestGuildChannel, ICategoryChannel
    {
        internal RestCategoryChannel(RestDiscordClient client, ChannelModel model) : base(client, model)
        {
            Update(model);
        }
    }
}
