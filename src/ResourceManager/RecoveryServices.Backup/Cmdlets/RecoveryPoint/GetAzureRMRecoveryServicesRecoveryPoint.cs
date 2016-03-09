﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models;
using Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.ProviderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, "AzureRMRecoveryServicesRecoveryPoint"), OutputType(typeof(List<AzureRmRecoveryServicesRecoveryPointBase>))]
    class GetAzureRMRecoveryServicesRecoveryPoint : RecoveryServicesBackupCmdletBase
    {
        [Parameter(Mandatory = false, HelpMessage = "", ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public ARSVault Vault { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "", ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public DateTime StartDate { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "", ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public DateTime EndDate { get; set; }

        [Parameter(Position = 0, Mandatory = true, HelpMessage = "", ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public AzureRmRecoveryServicesItemBase Item { get; set; }

        [Parameter(Position = 1, Mandatory = false, HelpMessage = "")]
        [ValidateNotNullOrEmpty]
        public string RecoveryPointId { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            PsBackupProviderManager providerManager = new PsBackupProviderManager(new Dictionary<System.Enum, object>()
            {
                {GetRecoveryPointParams.Vault, Vault},
                {GetRecoveryPointParams.StartDate, StartDate},
                {GetRecoveryPointParams.EndDate, EndDate},
                {GetRecoveryPointParams.Item, Item},
                {GetRecoveryPointParams.RecoveryPointId, RecoveryPointId},
            }, HydraAdapter);

            IPsBackupProvider psBackupProvider = providerManager.GetProviderInstance(ContainerType.AzureVM);
            psBackupProvider.GetRecoveryPoint();
        }

    }
}
