namespace SkyDiscord
{
    public interface IUnknownGuildChannel : IGuildChannel
    {
        byte Type { get; }
    }
}
