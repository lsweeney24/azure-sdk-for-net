// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Service Provider Definition. </summary>
    public partial class ServiceProvider
    {
        /// <summary> Initializes a new instance of ServiceProvider. </summary>
        internal ServiceProvider()
        {
        }

        /// <summary> Initializes a new instance of ServiceProvider. </summary>
        /// <param name="properties"> The Properties of a Service Provider Object. </param>
        internal ServiceProvider(ServiceProviderProperties properties)
        {
            Properties = properties;
        }

        /// <summary> The Properties of a Service Provider Object. </summary>
        public ServiceProviderProperties Properties { get; }
    }
}
