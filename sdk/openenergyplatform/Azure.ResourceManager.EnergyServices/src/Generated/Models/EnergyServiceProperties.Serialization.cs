// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EnergyServices.Models
{
    public partial class EnergyServiceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthAppId))
            {
                writer.WritePropertyName("authAppId"u8);
                writer.WriteStringValue(AuthAppId);
            }
            if (Optional.IsCollectionDefined(DataPartitionNames))
            {
                writer.WritePropertyName("dataPartitionNames"u8);
                writer.WriteStartArray();
                foreach (var item in DataPartitionNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static EnergyServiceProperties DeserializeEnergyServiceProperties(JsonElement element)
        {
            Optional<string> dnsName = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> authAppId = default;
            Optional<IList<DataPartitionName>> dataPartitionNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsName"u8))
                {
                    dnsName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authAppId"u8))
                {
                    authAppId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPartitionNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataPartitionName> array = new List<DataPartitionName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataPartitionName.DeserializeDataPartitionName(item));
                    }
                    dataPartitionNames = array;
                    continue;
                }
            }
            return new EnergyServiceProperties(dnsName.Value, Optional.ToNullable(provisioningState), authAppId.Value, Optional.ToList(dataPartitionNames));
        }
    }
}
