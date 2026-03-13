---
title: "Creating a Profile View"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-8B62A6B6-32CC-4289-89B0-EFDFDB3B04C8.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Profiles in COM", "Profile Views", "Creating a Profile View"]
---

# Creating a Profile View

A profile view, an object of type `AeccProfileView`, is a graphical display of profiles within a graph. A collection of profile views is contained in each alignment’s `AeccAlignment.ProfileViews` property.

```
Dim dOriginPt(0 To 2) As Double
dOriginPt(0) = 6000 ' X location of profile view
dOriginPt(1) = 3500 ' Y location
dOriginPt(2) = 0 ' Z location
 
' Use the first profile view style in the document. 
Dim oProfileViewStyle As AeccProfileViewStyle
Set oProfileViewStyle = oDocument.ProfileViewStyles.Item(0)
 
Dim oProfileView as AeccProfileView
Set oProfileView = oAlignment.ProfileViews.Add( _
  "Profile Style 01", _
  "0", _
  dOriginPt, _
  oProfileViewStyle, _
  Nothing)  ' "Nothing" means do not include data bands.
```

**Parent topic:** [Profile Views](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-866491CC-CD6A-4693-905E-A066CCA91B14.htm)