using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class PruneModel : JsonModel
    {
        [JsonProperty("pruned")]
        public int? Pruned { get; set; }
    }
}
