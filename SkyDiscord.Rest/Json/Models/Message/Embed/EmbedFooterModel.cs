﻿using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class EmbedFooterModel : JsonModel
    {
        [JsonProperty("text", NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("icon_url", NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        [JsonProperty("proxy_icon_url", NullValueHandling.Ignore)]
        public string ProxyIconUrl { get; set; }
    }
}
