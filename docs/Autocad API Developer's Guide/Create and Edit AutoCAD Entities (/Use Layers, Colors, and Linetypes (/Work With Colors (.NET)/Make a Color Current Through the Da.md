---
title: "Make a Color Current Through the Database (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-99ADAEB4-A686-498C-9FC3-F21DCCE24C78.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Use Layers, Colors, and Linetypes (.NET)", "Work With Colors (.NET)", "Make a Color Current Through the Database (.NET)"]
---

# Make a Color Current Through the Database (.NET)

This example sets a color current through the
`Database` object with the
`Cecolor` property.

## C#

```
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Colors;
 
[CommandMethod("SetColorCurrent")]
public static void SetColorCurrent()
{
    // Get the current document
    Document acDoc = Application.DocumentManager.MdiActiveDocument;
 
    // Set the current color
    acDoc.Database.Cecolor = Color.FromColorIndex(ColorMethod.ByLayer, 256);
}
```

## VB.NET

```
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Colors
 
<CommandMethod("SetColorCurrent")> _
Public Sub SetColorCurrent()
    '' Get the current document
    Dim acDoc As Document = Application.DocumentManager.MdiActiveDocument

    '' Set the current color
    acDoc.Database.Cecolor = Color.FromColorIndex(ColorMethod.ByLayer, 256)
End Sub
```

**Parent topic:** [Work With Colors (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-9B0AA5E9-38DA-4E14-B22D-17923C89D29F.htm)

#### Related Concepts

* [Work With Colors (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-9B0AA5E9-38DA-4E14-B22D-17923C89D29F.htm)