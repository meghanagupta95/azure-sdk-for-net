// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppIPSecurityRestrictionRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("ipAddressRange"u8);
            writer.WriteStringValue(IPAddressRange);
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToString());
            writer.WriteEndObject();
        }

        internal static ContainerAppIPSecurityRestrictionRule DeserializeContainerAppIPSecurityRestrictionRule(JsonElement element)
        {
            string name = default;
            Optional<string> description = default;
            string ipAddressRange = default;
            ContainerAppIPRuleAction action = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddressRange"u8))
                {
                    ipAddressRange = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = new ContainerAppIPRuleAction(property.Value.GetString());
                    continue;
                }
            }
            return new ContainerAppIPSecurityRestrictionRule(name, description.Value, ipAddressRange, action);
        }
    }
}
