using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class TimestampsModel : JsonModel
    {
        [JsonProperty("start", NullValueHandling.Ignore)]
        public long? Start { get; set; }

        [JsonProperty("end", NullValueHandling.Ignore)]
        public long? End { get; set; }
    }
}
