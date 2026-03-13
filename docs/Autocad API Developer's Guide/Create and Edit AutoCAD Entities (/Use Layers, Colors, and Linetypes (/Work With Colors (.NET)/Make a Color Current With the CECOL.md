---
title: "Make a Color Current With the CECOLOR System Variable (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-E50CC1AF-9448-4F30-9A2A-9142AB57163D.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Use Layers, Colors, and Linetypes (.NET)", "Work With Colors (.NET)", "Make a Color Current With the CECOLOR System Variable (.NET)"]
---

# Make a Color Current With the CECOLOR System Variable (.NET)

This example sets the color Red current with the CECOLOR system variable.

## C#

```
Application.SetSystemVariable("CECOLOR", "1");
```

## VB.NET

```
Application.SetSystemVariable("CECOLOR", "1")
```

## VBA/ActiveX Code Reference

```
ThisDrawing.SetVariable "CECOLOR", "1"
```

**Parent topic:** [Work With Colors (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-9B0AA5E9-38DA-4E14-B22D-17923C89D29F.htm)

#### Related Concepts

* [Work With Colors (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-9B0AA5E9-38DA-4E14-B22D-17923C89D29F.htm)