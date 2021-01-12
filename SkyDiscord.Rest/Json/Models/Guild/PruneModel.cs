using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class PruneModel : JsonModel
    {
        [JsonProperty("pruned")]
        public int? Pruned { get; set; }
    }
}
