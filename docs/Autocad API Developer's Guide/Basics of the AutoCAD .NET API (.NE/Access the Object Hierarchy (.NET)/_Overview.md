---
title: "Access the Object Hierarchy (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-1E64D6B9-F522-4245-AACE-FEF35F8A7BD7.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Basics of the AutoCAD .NET API (.NET)", "Access the Object Hierarchy (.NET)"]
---

# Access the Object Hierarchy (.NET)

While the Application is the root object in the AutoCAD .NET API, you commonly will be working with the database of the current drawing. The
`DocumentManager` property of the
`Application` object allows you to access the current document with the
`MdiActiveDocument` property. From the
`Document` object returned by the
`MdiActiveDocument` property, you can access its database with the
`Database` property.

## C#

```
Application.DocumentManager.MdiActiveDocument.Database.Clayer;
```

## VB.NET

```
Application.DocumentManager.MdiActiveDocument.Database.Clayer
```

## VBA/ActiveX Code Reference

```
ThisDrawing.ActiveLayer
```

**Parent topic:** [Basics of the AutoCAD .NET API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-79A4A44C-DF4C-46CC-B05C-311C8BD226C2.htm)

#### Related Concepts

* [Basics of the AutoCAD .NET API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-79A4A44C-DF4C-46CC-B05C-311C8BD226C2.htm)
* [Reference Objects in the Object Hierarchy (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-034504F8-59F8-4D6D-8777-3EF8A9C251DF.htm)
* [Access the Application Object (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-89D14077-DCEF-42D3-94F4-434D5AF23D41.htm)