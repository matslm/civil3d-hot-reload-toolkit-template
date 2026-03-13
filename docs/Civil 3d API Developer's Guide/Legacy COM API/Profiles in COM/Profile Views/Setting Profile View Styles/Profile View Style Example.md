---
title: "Profile View Style Example"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-34A759C2-04E7-4325-9E34-439CCA2D0546.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Profiles in COM", "Profile Views", "Setting Profile View Styles", "Profile View Style Example"]
---

# Profile View Style Example

This example takes an existing profile view style and modifies its top axis and title:

```
' Get the first style in the document's collection of styles.
Dim oProfileViewStyle as AeccProfileViewStyle
Set oProfileViewStyle = oDocument.ProfileViewStyles.Item(0)
 
' Adjust the top axis. Put station information here, with
' the title at the far left.
 
With oProfileViewStyle.TopAxis
    .DisplaySyle2d.Visible = True
    ' Modify the text to display meters in decimal
    ' format.
    .MajorTickStyle.Text = "<[Station Value(Um|FD|P1)]> m"
    .MajorTickStyle.Interval = 164.041995
    Dim dPoint(0 To 2) As Double
    dPoint(0) = 0.13
    dPoint(1) = 0#
    .TitleStyle.Offset = dPoint
    .TitleStyle.Text = "Meters"
    .TitleStyle.Position = aeccStart
End With
 
' Adjust the title to show the alignment name.
oProfileViewStyle.GraphStyle.TitleStyle.Text = _
  "Profile View of:<[Parent Alignment(CP)]>"
```

**Parent topic:** [Setting Profile View Styles](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-83172353-453C-4E95-A5C2-420DD08A5F18.htm)