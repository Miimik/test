﻿using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class EmbedImageModel : JsonModel
    {
        [JsonProperty("url", NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("proxy_url", NullValueHandling.Ignore)]
        public string ProxyUrl { get; set; }

        [JsonProperty("height", NullValueHandling.Ignore)]
        public int? Height { get; set; }

        [JsonProperty("width", NullValueHandling.Ignore)]
        public int? Width { get; set; }
    }
}
