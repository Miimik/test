using System.Collections.Generic;

namespace Discord
{
    public partial interface IGroupChannel : IPrivateChannel, IDeletable
    {
        string IconHash { get; }

        Snowflake OwnerId { get; }

        IReadOnlyDictionary<Snowflake, IUser> Recipients { get; }
    }
}
