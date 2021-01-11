namespace Discord
{
    public abstract class CreateNestedChannelProperties : CreateGuildChannelProperties
    {
        public Optional<Snowflake> ParentId { internal get; set; }

        internal CreateNestedChannelProperties()
        { }
    }
}
