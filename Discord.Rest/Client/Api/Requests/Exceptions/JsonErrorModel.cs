using Discord.Rest;
using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class JsonErrorModel : JsonModel
    {
        [JsonProperty("code")]
        public JsonErrorCode Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
