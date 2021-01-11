﻿using Discord.Serialization.Json;

namespace Discord.Models
{
    internal sealed class EmbedAuthorModel : JsonModel
    {
        [JsonProperty("name", NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("icon_url", NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        [JsonProperty("proxy_icon_url", NullValueHandling.Ignore)]
        public string ProxyIconUrl { get; set; }
    }
}
