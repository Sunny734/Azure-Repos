// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Extensions;

    /// <summary>Check quota availability response properties.</summary>
    public partial class CheckQuotaAvailabilityResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.ICheckQuotaAvailabilityResponsePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AvailabilityStatus" /> property.</summary>
        private string _availabilityStatus;

        /// <summary>Message indicating additional details to add to quota support request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Owned)]
        public string AvailabilityStatus { get => this._availabilityStatus; set => this._availabilityStatus = value; }

        /// <summary>Backing field for <see cref="IsAvailable" /> property.</summary>
        private bool? _isAvailable;

        /// <summary>
        /// True/False indicating whether the quota request be granted based on availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Owned)]
        public bool? IsAvailable { get => this._isAvailable; set => this._isAvailable = value; }

        /// <summary>
        /// Creates an new <see cref="CheckQuotaAvailabilityResponseProperties" /> instance.
        /// </summary>
        public CheckQuotaAvailabilityResponseProperties()
        {

        }
    }
    /// Check quota availability response properties.
    public partial interface ICheckQuotaAvailabilityResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.IJsonSerializable
    {
        /// <summary>Message indicating additional details to add to quota support request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Message indicating additional details to add to quota support request.",
        SerializedName = @"availabilityStatus",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilityStatus { get; set; }
        /// <summary>
        /// True/False indicating whether the quota request be granted based on availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True/False indicating whether the quota request be granted based on availability.",
        SerializedName = @"isAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsAvailable { get; set; }

    }
    /// Check quota availability response properties.
    internal partial interface ICheckQuotaAvailabilityResponsePropertiesInternal

    {
        /// <summary>Message indicating additional details to add to quota support request.</summary>
        string AvailabilityStatus { get; set; }
        /// <summary>
        /// True/False indicating whether the quota request be granted based on availability.
        /// </summary>
        bool? IsAvailable { get; set; }

    }
}