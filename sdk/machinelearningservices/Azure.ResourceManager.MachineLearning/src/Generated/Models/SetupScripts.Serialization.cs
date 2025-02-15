// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class SetupScripts : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Scripts))
            {
                writer.WritePropertyName("scripts"u8);
                writer.WriteObjectValue(Scripts);
            }
            writer.WriteEndObject();
        }

        internal static SetupScripts DeserializeSetupScripts(JsonElement element)
        {
            Optional<MachineLearningScriptsToExecute> scripts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scripts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scripts = MachineLearningScriptsToExecute.DeserializeMachineLearningScriptsToExecute(property.Value);
                    continue;
                }
            }
            return new SetupScripts(scripts.Value);
        }
    }
}
