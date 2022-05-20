﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Umbraco.Cms.Infrastructure.Serialization;

namespace Umbraco.Cms.Core.Models.Blocks
{
    /// <summary>
    /// Used for deserializing the block grid layout
    /// </summary>
    public class BlockGridLayoutItem
    {
        [JsonProperty("contentUdi", Required = Required.Always)]
        [JsonConverter(typeof(UdiJsonConverter))]
        public Udi ContentUdi { get; set; }

        [JsonProperty("settingsUdi", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UdiJsonConverter))]
        public Udi SettingsUdi { get; set; }

        [JsonProperty("columnSpan", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColumnSpan { get; set; }

        [JsonProperty("rowSpan", NullValueHandling = NullValueHandling.Ignore)]
        public int? RowSpan { get; set; }

        [JsonProperty("areas", NullValueHandling = NullValueHandling.Ignore)]
        public BlockGridLayoutAreaItem[] Areas { get; set; } = Array.Empty<BlockGridLayoutAreaItem>();

        /*
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public JEnumerable<JToken> Children { get; set; }
        */
    }

    public class BlockGridLayoutAreaItem
    {
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public BlockGridLayoutItem[] Items { get; set; } = Array.Empty<BlockGridLayoutItem>();
    }
}
