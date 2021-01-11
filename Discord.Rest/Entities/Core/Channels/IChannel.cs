namespace Discord
{
    public interface IChannel : ISnowflakeEntity
    {
        string Name { get; }
    }
}
