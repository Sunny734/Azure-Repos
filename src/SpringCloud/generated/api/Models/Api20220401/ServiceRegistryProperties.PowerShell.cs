// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401
{
    using Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.PowerShell;

    /// <summary>Service Registry properties payload</summary>
    [System.ComponentModel.TypeConverter(typeof(ServiceRegistryPropertiesTypeConverter))]
    public partial class ServiceRegistryProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ServiceRegistryProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServiceRegistryProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ServiceRegistryProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServiceRegistryProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServiceRegistryProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ServiceRegistryProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ServiceRegistryProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServiceRegistryProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequest = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryResourceRequests) content.GetValueForProperty("ResourceRequest",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequest, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ServiceRegistryResourceRequestsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ServiceRegistryProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ServiceRegistryProvisioningState.CreateFrom);
            }
            if (content.Contains("Instance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).Instance = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryInstance[]) content.GetValueForProperty("Instance",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).Instance, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryInstance>(__y, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ServiceRegistryInstanceTypeConverter.ConvertFrom));
            }
            if (content.Contains("ResourceRequestCpu"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequestCpu = (string) content.GetValueForProperty("ResourceRequestCpu",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequestCpu, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceRequestMemory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequestMemory = (string) content.GetValueForProperty("ResourceRequestMemory",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequestMemory, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceRequestInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequestInstanceCount = (int?) content.GetValueForProperty("ResourceRequestInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequestInstanceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ServiceRegistryProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServiceRegistryProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequest = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryResourceRequests) content.GetValueForProperty("ResourceRequest",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequest, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ServiceRegistryResourceRequestsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ServiceRegistryProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ServiceRegistryProvisioningState.CreateFrom);
            }
            if (content.Contains("Instance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).Instance = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryInstance[]) content.GetValueForProperty("Instance",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).Instance, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryInstance>(__y, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.ServiceRegistryInstanceTypeConverter.ConvertFrom));
            }
            if (content.Contains("ResourceRequestCpu"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequestCpu = (string) content.GetValueForProperty("ResourceRequestCpu",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequestCpu, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceRequestMemory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequestMemory = (string) content.GetValueForProperty("ResourceRequestMemory",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequestMemory, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceRequestInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequestInstanceCount = (int?) content.GetValueForProperty("ResourceRequestInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IServiceRegistryPropertiesInternal)this).ResourceRequestInstanceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Service Registry properties payload
    [System.ComponentModel.TypeConverter(typeof(ServiceRegistryPropertiesTypeConverter))]
    public partial interface IServiceRegistryProperties

    {

    }
}