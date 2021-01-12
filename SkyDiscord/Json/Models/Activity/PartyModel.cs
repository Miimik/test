using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class PartyModel : JsonModel
    {
        [JsonProperty("id", NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("size", NullValueHandling.Ignore)]
        public int[] Size { get; set; }
    }
}