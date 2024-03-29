// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Resources.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Export resource group template request parameters.
    /// </summary>
    public partial class ExportTemplateRequest
    {
        /// <summary>
        /// Initializes a new instance of the ExportTemplateRequest class.
        /// </summary>
        public ExportTemplateRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportTemplateRequest class.
        /// </summary>
        /// <param name="resources">The IDs of the resources to filter the
        /// export by. To export all resources, supply an array with single
        /// entry '*'.</param>
        /// <param name="options">The export template options. A CSV-formatted
        /// list containing zero or more of the following:
        /// 'IncludeParameterDefaultValue', 'IncludeComments',
        /// 'SkipResourceNameParameterization',
        /// 'SkipAllParameterization'</param>
        public ExportTemplateRequest(IList<string> resources = default(IList<string>), string options = default(string))
        {
            Resources = resources;
            Options = options;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the IDs of the resources to filter the export by. To
        /// export all resources, supply an array with single entry '*'.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<string> Resources { get; set; }

        /// <summary>
        /// Gets or sets the export template options. A CSV-formatted list
        /// containing zero or more of the following:
        /// 'IncludeParameterDefaultValue', 'IncludeComments',
        /// 'SkipResourceNameParameterization', 'SkipAllParameterization'
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public string Options { get; set; }

    }
}
