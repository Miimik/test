using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class IntegrationAccountModel : JsonModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}