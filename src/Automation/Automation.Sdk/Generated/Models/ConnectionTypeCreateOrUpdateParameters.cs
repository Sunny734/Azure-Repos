// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update connection type operation.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ConnectionTypeCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionTypeCreateOrUpdateParameters class.
        /// </summary>
        public ConnectionTypeCreateOrUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionTypeCreateOrUpdateParameters class.
        /// </summary>

        /// <param name="name">Gets or sets the name of the connection type.
        /// </param>

        /// <param name="isGlobal">Gets or sets a Boolean value to indicate if the connection type is global.
        /// </param>

        /// <param name="fieldDefinitions">Gets or sets the field definitions of the connection type.
        /// </param>
        public ConnectionTypeCreateOrUpdateParameters(string name, System.Collections.Generic.IDictionary<string, FieldDefinition> fieldDefinitions, bool? isGlobal = default(bool?))

        {
            this.Name = name;
            this.IsGlobal = isGlobal;
            this.FieldDefinitions = fieldDefinitions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets or sets the name of the connection type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets gets or sets a Boolean value to indicate if the connection
        /// type is global.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isGlobal")]
        public bool? IsGlobal {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the field definitions of the connection type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.fieldDefinitions")]
        public System.Collections.Generic.IDictionary<string, FieldDefinition> FieldDefinitions {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (this.FieldDefinitions == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "FieldDefinitions");
            }

            if (this.FieldDefinitions != null)
            {
                foreach (var valueElement in this.FieldDefinitions.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
        }
    }
}