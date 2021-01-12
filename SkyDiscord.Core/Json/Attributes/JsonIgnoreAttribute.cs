using System;

namespace SkyDiscord.Serialization.Json
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class JsonIgnoreAttribute : Attribute
    {
        public JsonIgnoreAttribute()
        { }
    }
}
