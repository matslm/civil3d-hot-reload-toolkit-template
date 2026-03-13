---
title: "Creating a Figure Object"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-A4BAD428-0175-4696-BA9B-10B86D43FF96.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Survey in COM", "Figures", "Creating a Figure Object"]
---

# Creating a Figure Object

A collection of all figures in the survey database are stored in the `AeccSurveyProject.Figures` property. New figures are made using the collection’s `Create` method.

```
Dim oFigure As AeccSurveyFigure
Set oFigure = oSurveyProject.Figures.Create("Figure_01")
```

**Parent topic:** [Figures](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-EF400B43-EE72-4A50-A0D1-8DAA3F6180F3.htm)