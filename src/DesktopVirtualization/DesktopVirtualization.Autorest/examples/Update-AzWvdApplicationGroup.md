### Example 1: Create a Windows Virtual Desktop ApplicationGroup by name
```powershell
New-AzWvdApplicationGroup -ResourceGroupName ResourceGroupName `
                          -Name ApplicationGroupName `
                          -FriendlyName 'Friendly Name' `
                          -Description 'Description' `
                          -ShowInFeed:$false
```

```output
Location   Name                 Type
--------   ----                 ----
eastus     ApplicationGroupName Microsoft.DesktopVirtualization/applicationgroups
```

This command creates a Windows Virtual Desktop ApplicationGroup in a Resource Group.

