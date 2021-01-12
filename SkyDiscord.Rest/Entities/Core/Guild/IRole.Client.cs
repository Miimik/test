using System;
using System.Threading.Tasks;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    public partial interface IRole : ISnowflakeEntity, IMentionable, IDeletable
    {
        Task ModifyAsync(Action<ModifyRoleProperties> action, RestRequestOptions options = null);
    }
}
