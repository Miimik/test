using Discord.Models;

namespace Discord.Rest
{
    public sealed partial class RestCategoryChannel : RestGuildChannel, ICategoryChannel
    {
        internal RestCategoryChannel(RestDiscordClient client, ChannelModel model) : base(client, model)
        {
            Update(model);
        }
    }
}
