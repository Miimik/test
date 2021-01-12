namespace SkyDiscord.Serialization
{
    public interface IOptional
    {
        bool HasValue { get; }

        object Value { get; }
    }
}
