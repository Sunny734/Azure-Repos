// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401
{
    using Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(NginxDeploymentUpdatePropertiesTypeConverter))]
    public partial class NginxDeploymentUpdateProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NginxDeploymentUpdateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NginxDeploymentUpdateProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NginxDeploymentUpdateProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="NginxDeploymentUpdateProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NginxDeploymentUpdateProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Logging"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).Logging = (Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLogging) content.GetValueForProperty("Logging",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).Logging, Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxLoggingTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScalingProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).ScalingProperty = (Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentScalingProperties) content.GetValueForProperty("ScalingProperty",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).ScalingProperty, Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentScalingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).UserProfile = (Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUserProfile) content.GetValueForProperty("UserProfile",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).UserProfile, Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentUserProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnableDiagnosticsSupport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).EnableDiagnosticsSupport = (bool?) content.GetValueForProperty("EnableDiagnosticsSupport",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).EnableDiagnosticsSupport, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LoggingStorageAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).LoggingStorageAccount = (Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxStorageAccount) content.GetValueForProperty("LoggingStorageAccount",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).LoggingStorageAccount, Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxStorageAccountTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScalingPropertyCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).ScalingPropertyCapacity = (int?) content.GetValueForProperty("ScalingPropertyCapacity",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).ScalingPropertyCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("UserProfilePreferredEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).UserProfilePreferredEmail = (string) content.GetValueForProperty("UserProfilePreferredEmail",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).UserProfilePreferredEmail, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).StorageAccountName = (string) content.GetValueForProperty("StorageAccountName",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).StorageAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccountContainerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).StorageAccountContainerName = (string) content.GetValueForProperty("StorageAccountContainerName",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).StorageAccountContainerName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NginxDeploymentUpdateProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Logging"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).Logging = (Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLogging) content.GetValueForProperty("Logging",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).Logging, Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxLoggingTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScalingProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).ScalingProperty = (Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentScalingProperties) content.GetValueForProperty("ScalingProperty",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).ScalingProperty, Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentScalingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).UserProfile = (Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUserProfile) content.GetValueForProperty("UserProfile",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).UserProfile, Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentUserProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnableDiagnosticsSupport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).EnableDiagnosticsSupport = (bool?) content.GetValueForProperty("EnableDiagnosticsSupport",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).EnableDiagnosticsSupport, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LoggingStorageAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).LoggingStorageAccount = (Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxStorageAccount) content.GetValueForProperty("LoggingStorageAccount",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).LoggingStorageAccount, Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxStorageAccountTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScalingPropertyCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).ScalingPropertyCapacity = (int?) content.GetValueForProperty("ScalingPropertyCapacity",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).ScalingPropertyCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("UserProfilePreferredEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).UserProfilePreferredEmail = (string) content.GetValueForProperty("UserProfilePreferredEmail",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).UserProfilePreferredEmail, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).StorageAccountName = (string) content.GetValueForProperty("StorageAccountName",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).StorageAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccountContainerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).StorageAccountContainerName = (string) content.GetValueForProperty("StorageAccountContainerName",((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)this).StorageAccountContainerName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    [System.ComponentModel.TypeConverter(typeof(NginxDeploymentUpdatePropertiesTypeConverter))]
    public partial interface INginxDeploymentUpdateProperties

    {

    }
}