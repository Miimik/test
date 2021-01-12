namespace SkyDiscord
{
    public interface INestedChannel : IGuildChannel
    {
        Snowflake? CategoryId { get; }
    }
}
