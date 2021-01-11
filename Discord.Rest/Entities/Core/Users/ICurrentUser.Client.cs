using System;
using System.Threading.Tasks;
using Discord.Rest;

namespace Discord
{
    public partial interface ICurrentUser : IUser
    {
        Task ModifyAsync(Action<ModifyCurrentUserProperties> action, RestRequestOptions options = null);
    }
}
