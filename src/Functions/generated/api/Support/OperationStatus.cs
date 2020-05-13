// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    public partial struct OperationStatus :
        System.IEquatable<OperationStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.OperationStatus Created = @"Created";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.OperationStatus Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.OperationStatus InProgress = @"InProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.OperationStatus Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.OperationStatus TimedOut = @"TimedOut";

        /// <summary>the value for an instance of the <see cref="OperationStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to OperationStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OperationStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new OperationStatus(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type OperationStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.OperationStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type OperationStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is OperationStatus && Equals((OperationStatus)obj);
        }

        /// <summary>Returns hashCode for enum OperationStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="OperationStatus" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private OperationStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for OperationStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to OperationStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OperationStatus" />.</param>

        public static implicit operator OperationStatus(string value)
        {
            return new OperationStatus(value);
        }

        /// <summary>Implicit operator to convert OperationStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="OperationStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.OperationStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum OperationStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.OperationStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.OperationStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum OperationStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.OperationStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.OperationStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}