using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Discord.Rest;

namespace Discord
{
    public partial interface ICategoryChannel : IGuildChannel
    {
        Task ModifyAsync(Action<ModifyCategoryChannelProperties> action, RestRequestOptions options = null);

        Task<IReadOnlyList<RestNestedChannel>> GetChannelsAsync(RestRequestOptions options = null);
    }
}
