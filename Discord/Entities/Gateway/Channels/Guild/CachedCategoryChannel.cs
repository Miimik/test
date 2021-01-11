using System.Collections.Generic;
using Discord.Collections;
using Discord.Models;

namespace Discord
{
    public sealed partial class CachedCategoryChannel : CachedGuildChannel, ICategoryChannel
    {
        public IReadOnlyDictionary<Snowflake, CachedNestedChannel> Channels =>
            new ReadOnlyValuePredicateArgumentDictionary<Snowflake, CachedNestedChannel, Snowflake>(
                Guild.NestedChannels, (x, id) => x.CategoryId == id, Id);

        internal CachedCategoryChannel(CachedGuild guild, ChannelModel model) : base(guild, model)
        {
            Update(model);
        }
    }
}
