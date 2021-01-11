using System.Threading.Tasks;
using Discord.Events;
using Discord.Models;

namespace Discord
{
    internal sealed partial class DiscordClientState
    {
        public Task HandleUserUpdateAsync(PayloadModel payload)
        {
            var model = payload.D.ToType<UserModel>();
            var currentUserBefore = _currentUser.Clone();
            _currentUser.Update(model);

            return _client._userUpdated.InvokeAsync(new UserUpdatedEventArgs(currentUserBefore, _currentUser));
        }
    }
}
