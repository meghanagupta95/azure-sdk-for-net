// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class NetworkInterfaceIPConfigurationListResult
    {
        internal static NetworkInterfaceIPConfigurationListResult DeserializeNetworkInterfaceIPConfigurationListResult(JsonElement element)
        {
            Optional<IReadOnlyList<NetworkInterfaceIPConfigurationData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NetworkInterfaceIPConfigurationData> array = new List<NetworkInterfaceIPConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkInterfaceIPConfigurationData.DeserializeNetworkInterfaceIPConfigurationData(item));
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
            return new NetworkInterfaceIPConfigurationListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
