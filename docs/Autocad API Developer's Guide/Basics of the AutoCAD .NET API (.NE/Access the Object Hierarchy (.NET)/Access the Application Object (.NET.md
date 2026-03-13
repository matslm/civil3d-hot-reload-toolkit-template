---
title: "Access the Application Object (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-89D14077-DCEF-42D3-94F4-434D5AF23D41.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Basics of the AutoCAD .NET API (.NET)", "Access the Object Hierarchy (.NET)", "Access the Application Object (.NET)"]
---

# Access the Application Object (.NET)

The Application object is at the root of the object hierarchy and it provides access to the main window of AutoCAD. For example, the following line of code updates the application:

## C#

```
Autodesk.AutoCAD.ApplicationServices.Application.UpdateScreen();
```

## VB.NET

```
Autodesk.AutoCAD.ApplicationServices.Application.UpdateScreen()
```

## VBA/ActiveX Code Reference

```
ThisDrawing.Application.Update
```

**Parent topic:** [Access the Object Hierarchy (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-1E64D6B9-F522-4245-AACE-FEF35F8A7BD7.htm)

#### Related Concepts

* [Access the Object Hierarchy (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-1E64D6B9-F522-4245-AACE-FEF35F8A7BD7.htm)