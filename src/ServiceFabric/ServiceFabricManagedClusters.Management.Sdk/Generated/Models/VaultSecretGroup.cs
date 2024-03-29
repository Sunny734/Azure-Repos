// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies set of certificates that should be installed onto the virtual
    /// machines.
    /// </summary>
    public partial class VaultSecretGroup
    {
        /// <summary>
        /// Initializes a new instance of the VaultSecretGroup class.
        /// </summary>
        public VaultSecretGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultSecretGroup class.
        /// </summary>

        /// <param name="sourceVault">The relative URL of the Key Vault containing all of the certificates in
        /// VaultCertificates.
        /// </param>

        /// <param name="vaultCertificates">The list of key vault references in SourceVault which contain certificates.
        /// </param>
        public VaultSecretGroup(SubResource sourceVault, System.Collections.Generic.IList<VaultCertificate> vaultCertificates)

        {
            this.SourceVault = sourceVault;
            this.VaultCertificates = vaultCertificates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the relative URL of the Key Vault containing all of the
        /// certificates in VaultCertificates.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceVault")]
        public SubResource SourceVault {get; set; }

        /// <summary>
        /// Gets or sets the list of key vault references in SourceVault which contain
        /// certificates.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vaultCertificates")]
        public System.Collections.Generic.IList<VaultCertificate> VaultCertificates {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.SourceVault == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SourceVault");
            }
            if (this.VaultCertificates == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "VaultCertificates");
            }

            if (this.VaultCertificates != null)
            {
                foreach (var element in this.VaultCertificates)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}