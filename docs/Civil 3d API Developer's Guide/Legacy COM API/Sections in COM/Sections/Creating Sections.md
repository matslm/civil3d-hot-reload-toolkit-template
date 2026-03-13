---
title: "Creating Sections"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-3600A6DA-2FA1-4A7D-87B3-A28136CA4D2C.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Sections in COM", "Sections", "Creating Sections"]
---

# Creating Sections

A section is a cross section of one or more surfaces taken along a sample line. You can either create sections one at a time using the `AeccSampleLineGroup.CreateSectionsAtSampleLine` method, or all at once using the `AeccSampleLineGroup.CreateSectionsAtSampleLines` method. These methods will cause an error if the sample line group does not reference any surfaces, or if the surface is not located under the sample lines specified.

```
' Create a section at the first sample line in the sample
' line group.
' oSampleLineGroup is of type AeccSampleLineGroup
 
Dim oSampleLine as AeccSampleLine
Set oSampleLine = oSampleLineGroup.SampleLines(0)
oSampleLineGroup.CreateSectionsAtSampleLine oSampleLine
 
' Create a section for each sample line in the sample
' line group.
oSampleLineGroup.CreateSectionsAtSampleLines
```

**Parent topic:** [Sections](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-42790840-1D3B-411F-AD08-7AF126395E89.htm)