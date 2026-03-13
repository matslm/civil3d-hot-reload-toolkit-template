---
title: "Creating a Profile From a Surface"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-6CDF41AB-561D-44F1-B520-93AD32AADA13.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Profiles in COM", "Profiles", "Creating a Profile From a Surface"]
---

# Creating a Profile From a Surface

A profile is an object consisting of elevations along an alignment. Each alignment contains a collection of profiles in its `AeccAlignment.Profiles` property. The `AeccProfiles.AddFromSurface` creates a new profile and derives its elevation information from the specified surface along the path of the alignment.

```
Dim oProfiles As AeccProfiles
Set oProfiles = oAlignment.Profiles
Dim oProfile As AeccProfile
 
' Add a new profile for the alignment "oAlignment" based
' on the elevations of the surface "oSurface".
Set oProfile = oProfiles.AddFromSurface( _
  "Profile01", _
  aeccExistingGround, _
  oProfileStyle.Name, _
  oSurface.Name, _
  oAlignment.StartingStation, _
  oAlignment.EndingStation, _
  "0")
```

**Parent topic:** [Profiles](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-19F9C9D7-8CCB-481A-83D0-4EA28D29E5C2.htm)