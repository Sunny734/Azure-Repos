
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------


function Remove-AzMgSpCredential {
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName='ObjectIdWithKeyIdParameterSet', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='ObjectIdWithKeyIdParameterSet', Mandatory)]
        [Alias('Id')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
        [System.String]
        ${ObjectId},

        [Parameter(ParameterSetName='SPNWithKeyIdParameterSet', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
        [System.String]
        ${ServicePrincipalName},

        [Parameter(ParameterSetName='DisplayNameWithKeyIdParameterSet', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
        [System.String]
        ${DisplayName},

        [Parameter(ParameterSetName='ServicePrincipalObjectParameterSet', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphServicePrincipal]
        ${ServicePrincipalObject},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
        [System.String]
        ${KeyId},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
      )
    
    process {
        switch ($PSCmdlet.ParameterSetName) {
            'ObjectIdWithKeyIdParameterSet' {
                $sp = Get-AzMgServicePrincipal -ObjectId $PSBoundParameters['ObjectId']
                if (!$sp) {
                    Write-Error "service principal with id '$($PSBoundParameters['ObjectId'])' does not exist."
                    return
                }
                $null = $PSBoundParameters.Remove('ObjectId')
                break
            }
            'SPNWithKeyIdParameterSet' {
                $sp = Get-AzMgServicePrincipal -ServicePrincipalName $PSBoundParameters['ServicePrincipalName']
                if (!$sp) {
                    Write-Error "service principal with name '$($PSBoundParameters['ServicePrincipalName'])' does not exist."
                    return
                }
                $null = $PSBoundParameters.Remove('ServicePrincipalName')
                break
            }
            'DisplayNameWithKeyIdParameterSet' {
                $sp = Get-AzMgServicePrincipal -DisplayName $PSBoundParameters['DisplayName']
                if (0 -eq $sp.Count) {
                    Write-Error "service principal with display name '$($PSBoundParameters['DisPlayName'])' does not exist."
                    return
                } elseif (1 -eq $sp.Count) {
                    $sp = $sp[0]
                } else {
                    Write-Error "More than one service principal found with display name '$($PSBoundParameters['DisplayName'])'. Please use the Get-AzMgServicePrincipal cmdlet to get the object id of the desired service principal."
                    return
                }
                $null = $PSBoundParameters.Remove('DisplayName')
                break
            }
            'ServicePrincipalObjectParameterSet' {
                $sp = Get-AzMgServicePrincipal -ObjectId $PSBoundParameters['ServicePrincipalObject'].Id
                if (!$sp) {
                    Write-Error "service principal with id '$($PSBoundParameters['ServicePrincipalObject'].Id)' does not exist."
                    return
                }
                $null = $PSBoundParameters.Remove('ServicePrincipalObject')
                break
            }
            default {
                break
            }
        }
        
        if (!$PSBoundParameters['KeyId']) {
            $PSBoundParameters['Id'] = $sp.Id
            $PSBoundParameters['KeyCredentials'] = @()
            MSGraph.internal\Update-AzMgServicePrincipal @PSBoundParameters
            $null = $PSBoundParameters.Remove('KeyCredentials')
            $null = $PSBoundParameters.Remove('Id')
            $PSBoundParameters['ServicePrincipalId'] = $sp.Id
            foreach ($password in $sp.PasswordCredentials) {
                $PSBoundParameters['KeyId'] = $password.KeyId
                MSGraph.internal\Remove-AzMgServicePrincipalPassword @PSBoundParameters
            }
        } else {
            $list = @()
            foreach ($key in $sp.KeyCredentials) {
                if ($key.KeyId -ne $PSBoundParameters['KeyId']) {
                    $list += $key
                }
                if ($list.Count -ne $sp.KeyCredentials.Count) {
                    $null = $PSBoundParameters.Remove('KeyId')
                    $PSBoundParameters['Id'] = $sp.Id
                    $PSBoundParameters['KeyCredentials'] = $list
                    MSGraph.internal\Update-AzMgServicePrincipal @PSBoundParameters
                    return
                }
            }
            foreach ($password in $sp.PasswordCredentials) {
                if ($password.KeyId -eq $PSBoundParameters['KeyId']) {
                    $PSBoundParameters['ServicePrincipalId'] = $sp.Id
                    MSGraph.internal\Remove-AzMgServicePrincipalPassword @PSBoundParameters
                    return
                }
            }
            Write-Error "service principal '$($sp.Id)' does not contains credential with key id: '$($PSBoundParameters['KeyId'])'."
        }
    }
}