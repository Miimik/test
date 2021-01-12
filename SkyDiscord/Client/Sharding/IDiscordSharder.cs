using Common;
using System.Collections.Generic;

namespace SkyDiscord.Sharding
{
    public interface IDiscordSharder
    {
        event AsynchronousEventHandler<ShardReadyEventArgs> ShardReady;

        internal AsynchronousEvent<ShardReadyEventArgs> _shardReady { get; set; }

        IReadOnlyList<Shard> Shards { get; }

        int GetShardId(Snowflake guildId);
    }
}
