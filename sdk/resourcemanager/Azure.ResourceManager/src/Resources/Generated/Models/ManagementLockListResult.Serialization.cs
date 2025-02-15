// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class ManagementLockListResult
    {
        internal static ManagementLockListResult DeserializeManagementLockListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ManagementLockData>> value = default;
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
                    List<ManagementLockData> array = new List<ManagementLockData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagementLockData.DeserializeManagementLockData(item));
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
            return new ManagementLockListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
