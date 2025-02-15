// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt specific migrate input. </summary>
    public partial class VMwareCbtMigrateInput : MigrateProviderSpecificInput
    {
        /// <summary> Initializes a new instance of VMwareCbtMigrateInput. </summary>
        /// <param name="performShutdown"> A value indicating whether VM is to be shutdown. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="performShutdown"/> is null. </exception>
        public VMwareCbtMigrateInput(string performShutdown)
        {
            Argument.AssertNotNull(performShutdown, nameof(performShutdown));

            PerformShutdown = performShutdown;
            InstanceType = "VMwareCbt";
        }

        /// <summary> A value indicating whether VM is to be shutdown. </summary>
        public string PerformShutdown { get; }
    }
}
