namespace Discord
{
    public interface IUnknownGuildChannel : IGuildChannel
    {
        byte Type { get; }
    }
}
