using System;
using System.Threading.Tasks;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    public partial interface IGuildEmoji : ISnowflakeEntity, ICustomEmoji, IDeletable
    {
        Task ModifyAsync(Action<ModifyGuildEmojiProperties> action, RestRequestOptions options = null);
    }
}
