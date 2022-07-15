// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    /// <summary>
    /// Error response indicates that the service is not able to process the incoming request. The reason is provided in the error
    /// message.
    /// </summary>
    public partial class ErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorResponseInternal
    {

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetailsInternal)Error).Code; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetails _error;

        /// <summary>The details of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetails Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ErrorDetails()); set => this._error = value; }

        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetailsInternal)Error).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorResponseInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetailsInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetailsInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetails Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorResponseInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ErrorDetails()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorResponseInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetailsInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetailsInternal)Error).Message = value; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorResponseInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetailsInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetailsInternal)Error).Target = value; }

        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetailsInternal)Error).Target; }

        /// <summary>Creates an new <see cref="ErrorResponse" /> instance.</summary>
        public ErrorResponse()
        {

        }
    }
    /// Error response indicates that the service is not able to process the incoming request. The reason is provided in the error
    /// message.
    public partial interface IErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error message indicating why the operation failed.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The target of the particular error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// Error response indicates that the service is not able to process the incoming request. The reason is provided in the error
    /// message.
    internal partial interface IErrorResponseInternal

    {
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>The details of the error.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorDetails Error { get; set; }
        /// <summary>Error message indicating why the operation failed.</summary>
        string Message { get; set; }
        /// <summary>The target of the particular error.</summary>
        string Target { get; set; }

    }
}