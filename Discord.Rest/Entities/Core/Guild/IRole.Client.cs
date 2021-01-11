using System;
using System.Threading.Tasks;
using Discord.Rest;

namespace Discord
{
    public partial interface IRole : ISnowflakeEntity, IMentionable, IDeletable
    {
        Task ModifyAsync(Action<ModifyRoleProperties> action, RestRequestOptions options = null);
    }
}
