// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SqlTriggerGetPropertiesResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlTriggerGetPropertiesResource
        /// class.
        /// </summary>
        public SqlTriggerGetPropertiesResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlTriggerGetPropertiesResource
        /// class.
        /// </summary>
        /// <param name="id">Name of the Cosmos DB SQL trigger</param>
        /// <param name="body">Body of the Trigger</param>
        /// <param name="triggerType">Type of the Trigger. Possible values
        /// include: 'Pre', 'Post'</param>
        /// <param name="triggerOperation">The operation the trigger is
        /// associated with. Possible values include: 'All', 'Create',
        /// 'Update', 'Delete', 'Replace'</param>
        /// <param name="_rid">A system generated property. A unique
        /// identifier.</param>
        /// <param name="_ts">A system generated property that denotes the last
        /// updated timestamp of the resource.</param>
        /// <param name="_etag">A system generated property representing the
        /// resource etag required for optimistic concurrency control.</param>
        public SqlTriggerGetPropertiesResource(string id, string body = default(string), string triggerType = default(string), string triggerOperation = default(string), string _rid = default(string), double? _ts = default(double?), string _etag = default(string))
        {
            Id = id;
            Body = body;
            TriggerType = triggerType;
            TriggerOperation = triggerOperation;
            this._rid = _rid;
            this._ts = _ts;
            this._etag = _etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Cosmos DB SQL trigger
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets body of the Trigger
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets type of the Trigger. Possible values include: 'Pre',
        /// 'Post'
        /// </summary>
        [JsonProperty(PropertyName = "triggerType")]
        public string TriggerType { get; set; }

        /// <summary>
        /// Gets or sets the operation the trigger is associated with. Possible
        /// values include: 'All', 'Create', 'Update', 'Delete', 'Replace'
        /// </summary>
        [JsonProperty(PropertyName = "triggerOperation")]
        public string TriggerOperation { get; set; }

        /// <summary>
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "_rid")]
        public string _rid { get; private set; }

        /// <summary>
        /// Gets a system generated property that denotes the last updated
        /// timestamp of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "_ts")]
        public double? _ts { get; private set; }

        /// <summary>
        /// Gets a system generated property representing the resource etag
        /// required for optimistic concurrency control.
        /// </summary>
        [JsonProperty(PropertyName = "_etag")]
        public string _etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
