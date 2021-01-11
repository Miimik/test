namespace Discord
{
    public partial interface IVoiceChannel : INestedChannel
    {
        int MemberLimit { get; }

        int Bitrate { get; }
    }
}
