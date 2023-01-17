// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>Response for mobile networks API service call.</summary>
    public partial class MobileNetworkListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IMobileNetworkListResult,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IMobileNetworkListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IMobileNetworkListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to get the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IMobileNetwork[] _value;

        /// <summary>A list of mobile networks in a resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IMobileNetwork[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="MobileNetworkListResult" /> instance.</summary>
        public MobileNetworkListResult()
        {

        }
    }
    /// Response for mobile networks API service call.
    public partial interface IMobileNetworkListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable
    {
        /// <summary>The URL to get the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The URL to get the next set of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>A list of mobile networks in a resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of mobile networks in a resource group.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IMobileNetwork) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IMobileNetwork[] Value { get; set; }

    }
    /// Response for mobile networks API service call.
    internal partial interface IMobileNetworkListResultInternal

    {
        /// <summary>The URL to get the next set of results.</summary>
        string NextLink { get; set; }
        /// <summary>A list of mobile networks in a resource group.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IMobileNetwork[] Value { get; set; }

    }
}