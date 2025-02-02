// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.MixedReality.RemoteRendering
{
    public partial class RemoteRenderingServiceError
    {
        internal static RemoteRenderingServiceError DeserializeRemoteRenderingServiceError(JsonElement element)
        {
            string code = default;
            string message = default;
            Optional<IReadOnlyList<RemoteRenderingServiceError>> details = default;
            Optional<string> target = default;
            Optional<RemoteRenderingServiceError> innerError = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RemoteRenderingServiceError> array = new List<RemoteRenderingServiceError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeRemoteRenderingServiceError(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innerError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    innerError = DeserializeRemoteRenderingServiceError(property.Value);
                    continue;
                }
            }
            return new RemoteRenderingServiceError(code, message, Optional.ToList(details), target.Value, innerError.Value);
        }
    }
}
