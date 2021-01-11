using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class BanModel : JsonModel
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("user")]
        public UserModel User { get; set; }
    }
}
