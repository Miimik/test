using System.Collections.Generic;
using System.Threading.Tasks;
using SkyDiscord.Rest;

namespace SkyDiscord
{
    public interface IMessagable : ISnowflakeEntity
    {
        Task<RestUserMessage> SendMessageAsync(string content = null, bool textToSpeech = false, LocalEmbed embed = null, LocalMentions mentions = null, RestRequestOptions options = null);

        Task<RestUserMessage> SendMessageAsync(LocalAttachment attachment, string content = null, bool textToSpeech = false, LocalEmbed embed = null, LocalMentions mentions = null, RestRequestOptions options = null);

        Task<RestUserMessage> SendMessageAsync(IEnumerable<LocalAttachment> attachments, string content = null, bool textToSpeech = false, LocalEmbed embed = null, LocalMentions mentions = null, RestRequestOptions options = null);
    }
}