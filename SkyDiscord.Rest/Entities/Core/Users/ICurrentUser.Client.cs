using System;
using System.Threading.Tasks;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    public partial interface ICurrentUser : IUser
    {
        Task ModifyAsync(Action<ModifyCurrentUserProperties> action, RestRequestOptions options = null);
    }
}
