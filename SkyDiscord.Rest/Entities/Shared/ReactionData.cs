using SkyDiscord.Models;

namespace SkyDiscord
{
    public sealed class ReactionData
    {
        public IEmoji Emoji { get; }

        public int Count { get; internal set; }

        public bool HasCurrentUserReacted { get; internal set; }

        internal ReactionData(ReactionModel model)
        {
            Emoji = model.Emoji.ToEmoji();
            Count = model.Count;
            HasCurrentUserReacted = model.Me;
        }
    }
}
