---
title: "Creating Sites"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-FD3A9CC1-6CC2-4009-BD77-44CA779EFF77.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Sites and Parcels in COM", "Sites", "Creating Sites"]
---

# Creating Sites

All sites in a document are held in the `AeccDocument.Sites` collection, an object of type `AeccSites`. The `AeccSites.Add` method creates a new empty site with the specified name.

```
' Create a new site.
Dim oSites As AeccSites
Set oSites = oAeccDocument.Sites
Dim oSite As AeccSite
Set oSite = oSites.Add("Sample Site")
```

**Parent topic:** [Sites](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-FEE92E28-2985-4694-8055-2925582789BE.htm)