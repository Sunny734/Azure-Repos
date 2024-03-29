// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Agent details.
    /// </summary>
    public partial class AgentDetails
    {
        /// <summary>
        /// Initializes a new instance of the AgentDetails class.
        /// </summary>
        public AgentDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AgentDetails class.
        /// </summary>

        /// <param name="agentId">The Id of the agent running on the server.
        /// </param>

        /// <param name="machineId">The Id of the machine to which the agent is registered.
        /// </param>

        /// <param name="biosId">The machine BIOS Id.
        /// </param>

        /// <param name="fqdn">The machine FQDN.
        /// </param>

        /// <param name="disks">The disks.
        /// </param>
        public AgentDetails(string agentId = default(string), string machineId = default(string), string biosId = default(string), string fqdn = default(string), System.Collections.Generic.IList<AgentDiskDetails> disks = default(System.Collections.Generic.IList<AgentDiskDetails>))

        {
            this.AgentId = agentId;
            this.MachineId = machineId;
            this.BiosId = biosId;
            this.Fqdn = fqdn;
            this.Disks = disks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the Id of the agent running on the server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "agentId")]
        public string AgentId {get; private set; }

        /// <summary>
        /// Gets the Id of the machine to which the agent is registered.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "machineId")]
        public string MachineId {get; private set; }

        /// <summary>
        /// Gets the machine BIOS Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "biosId")]
        public string BiosId {get; private set; }

        /// <summary>
        /// Gets the machine FQDN.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fqdn")]
        public string Fqdn {get; private set; }

        /// <summary>
        /// Gets the disks.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "disks")]
        public System.Collections.Generic.IList<AgentDiskDetails> Disks {get; private set; }
    }
}