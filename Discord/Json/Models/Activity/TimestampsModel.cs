using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class TimestampsModel : JsonModel
    {
        [JsonProperty("start", NullValueHandling.Ignore)]
        public long? Start { get; set; }

        [JsonProperty("end", NullValueHandling.Ignore)]
        public long? End { get; set; }
    }
}
