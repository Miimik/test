﻿namespace SkyDiscord
{
    public abstract class ModifyChannelProperties
    {
        public Optional<string> Name { internal get; set; }

        internal ModifyChannelProperties()
        { }
    }
}
