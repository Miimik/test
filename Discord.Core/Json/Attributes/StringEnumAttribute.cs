﻿using System;

namespace Discord.Serialization.Json
{
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
    public class StringEnumAttribute : Attribute
    {
        public StringEnumAttribute()
        { }
    }
}
