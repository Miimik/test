using System;
using System.Threading.Tasks;
using Discord.Rest;

namespace Discord
{
    public partial interface IGuildEmoji : ISnowflakeEntity, ICustomEmoji, IDeletable
    {
        Task ModifyAsync(Action<ModifyGuildEmojiProperties> action, RestRequestOptions options = null);
    }
}
