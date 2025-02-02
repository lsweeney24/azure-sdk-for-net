// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Workloads.Models
{
    internal static partial class DiskStorageTypeExtensions
    {
        public static string ToSerialString(this DiskStorageType value) => value switch
        {
            DiskStorageType.PremiumLrs => "Premium_LRS",
            DiskStorageType.StandardLrs => "Standard_LRS",
            DiskStorageType.StandardSsdLrs => "StandardSSD_LRS",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DiskStorageType value.")
        };

        public static DiskStorageType ToDiskStorageType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Premium_LRS")) return DiskStorageType.PremiumLrs;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Standard_LRS")) return DiskStorageType.StandardLrs;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "StandardSSD_LRS")) return DiskStorageType.StandardSsdLrs;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DiskStorageType value.");
        }
    }
}
