﻿using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models
{
    internal sealed class MessageActivityModel : JsonModel
    {
        [JsonProperty("type")]
        public MessageActivityType Type { get; set; }

        [JsonProperty("party_id")]
        public Optional<string> PartyId { get; set; }
    }
}
