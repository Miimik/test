﻿using System;
using Newtonsoft.Json;

namespace Discord.Serialization.Json.Default
{
    internal sealed class SnowflakeConverter : JsonConverter
    {
        public override bool CanConvert(Type typeToConvert)
            => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            => new Snowflake(Convert.ToUInt64(reader.Value));

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            => writer.WriteValue(((Snowflake) value).RawValue);
    }
}
