// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SparkConfigurationListResponseConverter))]
    internal partial class SparkConfigurationListResponse
    {
        internal static SparkConfigurationListResponse DeserializeSparkConfigurationListResponse(JsonElement element)
        {
            IReadOnlyList<SparkConfigurationResource> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SparkConfigurationResource> array = new List<SparkConfigurationResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SparkConfigurationResource.DeserializeSparkConfigurationResource(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SparkConfigurationListResponse(value, nextLink.Value);
        }

        internal partial class SparkConfigurationListResponseConverter : JsonConverter<SparkConfigurationListResponse>
        {
            public override void Write(Utf8JsonWriter writer, SparkConfigurationListResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override SparkConfigurationListResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkConfigurationListResponse(document.RootElement);
            }
        }
    }
}
