﻿using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class AssetsModel : JsonModel
    {
        [JsonProperty("large_image", NullValueHandling.Ignore)]
        public string LargeImage { get; set; }

        [JsonProperty("large_text", NullValueHandling.Ignore)]
        public string LargeText { get; set; }

        [JsonProperty("small_image", NullValueHandling.Ignore)]
        public string SmallImage { get; set; }

        [JsonProperty("small_text", NullValueHandling.Ignore)]
        public string SmallText { get; set; }
    }
}