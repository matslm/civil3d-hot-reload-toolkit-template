---
title: "Creating a Label Style Object"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-480D36B9-AE97-4F34-8506-18206B59E7D6.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Root Objects and Common Concepts in COM", "Label Styles", "Creating a Label Style Object"]
---

# Creating a Label Style Object

All types of annotation for Autodesk Civil 3D elements are governed by label styles, which are objects of type `AeccLabelStyle`. A label style can include any number of text labels, tick marks, lines, markers, and direction arrows.

The following example creates a new label style object that can be used with points:

```
Dim oLabelStyle As AeccLabelStyle
Set oLabelStyle = oDocument.PointLabelStyles.Add _
  ("New Label Style for Points")
```

**Parent topic:** [Label Styles](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-CB057BA7-7EAE-4915-9B90-8451776C1407.htm)