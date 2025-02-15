// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET. </summary>
    public partial class VirtualNetworkBgpCommunities
    {
        /// <summary> Initializes a new instance of VirtualNetworkBgpCommunities. </summary>
        /// <param name="virtualNetworkCommunity"> The BGP community associated with the virtual network. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkCommunity"/> is null. </exception>
        public VirtualNetworkBgpCommunities(string virtualNetworkCommunity)
        {
            Argument.AssertNotNull(virtualNetworkCommunity, nameof(virtualNetworkCommunity));

            VirtualNetworkCommunity = virtualNetworkCommunity;
        }

        /// <summary> Initializes a new instance of VirtualNetworkBgpCommunities. </summary>
        /// <param name="virtualNetworkCommunity"> The BGP community associated with the virtual network. </param>
        /// <param name="regionalCommunity"> The BGP community associated with the region of the virtual network. </param>
        internal VirtualNetworkBgpCommunities(string virtualNetworkCommunity, string regionalCommunity)
        {
            VirtualNetworkCommunity = virtualNetworkCommunity;
            RegionalCommunity = regionalCommunity;
        }

        /// <summary> The BGP community associated with the virtual network. </summary>
        public string VirtualNetworkCommunity { get; set; }
        /// <summary> The BGP community associated with the region of the virtual network. </summary>
        public string RegionalCommunity { get; }
    }
}
