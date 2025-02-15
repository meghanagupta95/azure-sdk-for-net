// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    internal partial class RoleDefinitionListResult
    {
        internal static RoleDefinitionListResult DeserializeRoleDefinitionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<AuthorizationRoleDefinitionData>> value = default;
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
                    List<AuthorizationRoleDefinitionData> array = new List<AuthorizationRoleDefinitionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizationRoleDefinitionData.DeserializeAuthorizationRoleDefinitionData(item));
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
            return new RoleDefinitionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
