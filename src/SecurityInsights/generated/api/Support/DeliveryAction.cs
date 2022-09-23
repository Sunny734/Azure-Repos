// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support
{

    /// <summary>The delivery action of this mail message like Delivered, Blocked, Replaced etc</summary>
    public partial struct DeliveryAction :
        System.IEquatable<DeliveryAction>
    {
        /// <summary>Blocked</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DeliveryAction Blocked = @"Blocked";

        /// <summary>Delivered</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DeliveryAction Delivered = @"Delivered";

        /// <summary>DeliveredAsSpam</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DeliveryAction DeliveredAsSpam = @"DeliveredAsSpam";

        /// <summary>Replaced</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DeliveryAction Replaced = @"Replaced";

        /// <summary>Unknown</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DeliveryAction Unknown = @"Unknown";

        /// <summary>the value for an instance of the <see cref="DeliveryAction" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DeliveryAction</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DeliveryAction" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DeliveryAction(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DeliveryAction"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DeliveryAction(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DeliveryAction</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DeliveryAction e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DeliveryAction (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DeliveryAction && Equals((DeliveryAction)obj);
        }

        /// <summary>Returns hashCode for enum DeliveryAction</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DeliveryAction</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DeliveryAction</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DeliveryAction" />.</param>

        public static implicit operator DeliveryAction(string value)
        {
            return new DeliveryAction(value);
        }

        /// <summary>Implicit operator to convert DeliveryAction to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DeliveryAction" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DeliveryAction e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DeliveryAction</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DeliveryAction e1, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DeliveryAction e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DeliveryAction</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DeliveryAction e1, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DeliveryAction e2)
        {
            return e2.Equals(e1);
        }
    }
}