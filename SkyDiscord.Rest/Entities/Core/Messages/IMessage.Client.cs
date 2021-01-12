﻿using SkyDiscord.Rest;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkyDiscord
{
    public partial interface IMessage : ISnowflakeEntity, IDeletable
    {
        Task AddReactionAsync(IEmoji emoji, RestRequestOptions options = null);

        Task RemoveOwnReactionAsync(IEmoji emoji, RestRequestOptions options = null);

        Task RemoveMemberReactionAsync(Snowflake memberId, IEmoji emoji, RestRequestOptions options = null);

        RestRequestEnumerable<RestUser> GetReactionsEnumerable(IEmoji emoji, int limit, Snowflake? startFromId = null, RestRequestOptions options = null);

        Task<IReadOnlyList<RestUser>> GetReactionsAsync(IEmoji emoji, int limit = 100, Snowflake? startFromId = null, RestRequestOptions options = null);

        Task ClearReactionsAsync(IEmoji emoji = null, RestRequestOptions options = null);
    }
}
