namespace Discord
{
    public interface INestedChannel : IGuildChannel
    {
        Snowflake? CategoryId { get; }
    }
}
