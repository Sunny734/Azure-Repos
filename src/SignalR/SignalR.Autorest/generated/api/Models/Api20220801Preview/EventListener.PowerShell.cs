// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.PowerShell;

    /// <summary>A setting defines which kinds of events should be sent to which endpoint.</summary>
    [System.ComponentModel.TypeConverter(typeof(EventListenerTypeConverter))]
    public partial class EventListener
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.EventListener"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListener" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListener DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EventListener(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.EventListener"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListener" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListener DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EventListener(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.EventListener"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EventListener(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Filter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListenerInternal)this).Filter = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListenerFilter) content.GetValueForProperty("Filter",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListenerInternal)this).Filter, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.EventListenerFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("Endpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListenerInternal)this).Endpoint = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListenerEndpoint) content.GetValueForProperty("Endpoint",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListenerInternal)this).Endpoint, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.EventListenerEndpointTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.EventListener"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EventListener(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Filter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListenerInternal)this).Filter = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListenerFilter) content.GetValueForProperty("Filter",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListenerInternal)this).Filter, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.EventListenerFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("Endpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListenerInternal)this).Endpoint = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListenerEndpoint) content.GetValueForProperty("Endpoint",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListenerInternal)this).Endpoint, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.EventListenerEndpointTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EventListener" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EventListener" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IEventListener FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// A setting defines which kinds of events should be sent to which endpoint.
    [System.ComponentModel.TypeConverter(typeof(EventListenerTypeConverter))]
    public partial interface IEventListener

    {

    }
}