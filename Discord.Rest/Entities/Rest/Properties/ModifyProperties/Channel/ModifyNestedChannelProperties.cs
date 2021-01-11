namespace Discord
{
    public abstract class ModifyNestedChannelProperties : ModifyGuildChannelProperties
    {
        public Optional<Snowflake> CategoryId { internal get; set; }

        internal ModifyNestedChannelProperties()
        { }
    }
}
