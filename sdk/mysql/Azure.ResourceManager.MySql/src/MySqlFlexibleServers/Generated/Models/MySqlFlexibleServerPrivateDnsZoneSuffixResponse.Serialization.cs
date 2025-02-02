// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerPrivateDnsZoneSuffixResponse
    {
        internal static MySqlFlexibleServerPrivateDnsZoneSuffixResponse DeserializeMySqlFlexibleServerPrivateDnsZoneSuffixResponse(JsonElement element)
        {
            Optional<string> privateDnsZoneSuffix = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateDnsZoneSuffix"u8))
                {
                    privateDnsZoneSuffix = property.Value.GetString();
                    continue;
                }
            }
            return new MySqlFlexibleServerPrivateDnsZoneSuffixResponse(privateDnsZoneSuffix.Value);
        }
    }
}
