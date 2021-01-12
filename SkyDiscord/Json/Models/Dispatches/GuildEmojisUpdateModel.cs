﻿using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Models.Dispatches
{
    internal sealed class GuildEmojisUpdateModel : JsonModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("emojis")]
        public EmojiModel[] Emojis { get; set; }
    }
}
