﻿using System.Net.Http;
using SkyDiscord.Serialization.Json;

namespace SkyDiscord.Rest
{
    internal sealed class JsonObjectContent : IRequestContent
    {
        public object Model { get; }

        public JsonObjectContent(object model)
        {
            Model = model;
        }

        public HttpContent Prepare(IJsonSerializer serializer, RestRequestOptions options)
            => JsonRequestContent.PrepareFor(Model, serializer, options);
    }
}
