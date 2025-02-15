// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Service data flow direction. </summary>
    public readonly partial struct SdfDirection : IEquatable<SdfDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SdfDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SdfDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UplinkValue = "Uplink";
        private const string DownlinkValue = "Downlink";
        private const string BidirectionalValue = "Bidirectional";

        /// <summary> Traffic flowing from the UE to the data network. </summary>
        public static SdfDirection Uplink { get; } = new SdfDirection(UplinkValue);
        /// <summary> Traffic flowing from the data network to the UE. </summary>
        public static SdfDirection Downlink { get; } = new SdfDirection(DownlinkValue);
        /// <summary> Traffic flowing both to and from the UE. </summary>
        public static SdfDirection Bidirectional { get; } = new SdfDirection(BidirectionalValue);
        /// <summary> Determines if two <see cref="SdfDirection"/> values are the same. </summary>
        public static bool operator ==(SdfDirection left, SdfDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SdfDirection"/> values are not the same. </summary>
        public static bool operator !=(SdfDirection left, SdfDirection right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SdfDirection"/>. </summary>
        public static implicit operator SdfDirection(string value) => new SdfDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SdfDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SdfDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
