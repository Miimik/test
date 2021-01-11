﻿namespace Discord.Serialization.Json
{
    public interface IJsonElement
    {
        bool IsArray { get; }

        T ToType<T>();
    }
}
