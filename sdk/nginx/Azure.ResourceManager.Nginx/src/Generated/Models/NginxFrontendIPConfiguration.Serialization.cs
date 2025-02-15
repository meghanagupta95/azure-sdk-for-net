// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxFrontendIPConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PublicIPAddresses))
            {
                writer.WritePropertyName("publicIPAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in PublicIPAddresses)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PrivateIPAddresses))
            {
                writer.WritePropertyName("privateIPAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateIPAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static NginxFrontendIPConfiguration DeserializeNginxFrontendIPConfiguration(JsonElement element)
        {
            Optional<IList<WritableSubResource>> publicIPAddresses = default;
            Optional<IList<NginxPrivateIPAddress>> privateIPAddresses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIPAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    publicIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("privateIPAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NginxPrivateIPAddress> array = new List<NginxPrivateIPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxPrivateIPAddress.DeserializeNginxPrivateIPAddress(item));
                    }
                    privateIPAddresses = array;
                    continue;
                }
            }
            return new NginxFrontendIPConfiguration(Optional.ToList(publicIPAddresses), Optional.ToList(privateIPAddresses));
        }
    }
}
