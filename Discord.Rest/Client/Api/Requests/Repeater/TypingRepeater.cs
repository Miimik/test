using System;

namespace Discord.Rest
{
    internal sealed class TypingRepeater : RequestRepeater
    {
        public TypingRepeater(RestDiscordClient client, IMessageChannel channel) : base(
            cancellationToken => client.TriggerTypingAsync(channel.Id, new RestRequestOptionsBuilder()
                .WithCancellationToken(cancellationToken)
                .Build()),
            TimeSpan.FromSeconds(5.5))
        { }
    }
}
