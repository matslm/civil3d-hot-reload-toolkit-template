---
title: "Creating a Label Style Object"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-95F80FEC-9F9D-495A-99C5-DECCA300E88B.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Root Objects and Common Concepts", "Label Styles", "Creating a Label Style Object"]
---

# Creating a Label Style Object

All types of annotation for Autodesk Civil 3D elements are governed by label styles, which are objects of type `LabelStyle`. A label style can include any number of text labels, tick marks, lines, markers, and direction arrows.

The following example creates a new label style object that can be used with points:

```
CivilDocument doc = CivilApplication.ActiveDocument;
ObjectId labelStyleId;
labelStyleId = doc.Styles.LabelStyles.PointLabelStyles.LabelStyles.Add
    ("New Point Label Style");
```

**Parent topic:** [Label Styles](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-641D7838-292D-43FD-AA50-140B7D9B774F.htm)