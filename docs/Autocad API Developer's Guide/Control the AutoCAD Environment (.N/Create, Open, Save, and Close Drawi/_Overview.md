---
title: "Create, Open, Save, and Close Drawings (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-A73E66C5-AE7F-4142-9160-705C04552C4A.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Control the AutoCAD Environment (.NET)", "Create, Open, Save, and Close Drawings (.NET)"]
---

# Create, Open, Save, and Close Drawings (.NET)

The `DocumentCollection`, `DocumentCollectionExtension`, `Document`, and `Database` objects provide access to the AutoCAD® file methods.

## VBA/ActiveX Cross Reference

| VBA/ActiveX Class | .NET API Class |
| --- | --- |
| Documents collection | `DocumentCollection` and `DocumentCollectionExtension` |
| Document | `Document` and `Database` |
| Document.Saved | System.Convert.ToInt16(Application.GetSystemVariable("DBMOD")) |

**Parent topic:** [Control the AutoCAD Environment (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-B9D5DD07-846E-418F-A346-0CEB35E724F7.htm)

#### Related Concepts

* [Control the AutoCAD Environment (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-B9D5DD07-846E-418F-A346-0CEB35E724F7.htm)
* [Create and Open a Drawing (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-330A8DCB-626F-4271-8B89-9773A7631D87.htm)
* [Save and Close a Drawing (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CBB74093-BB22-49CC-B54A-D33D7E92694C.htm)
* [Work With No Documents Open (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CB7D7DC2-C8C1-4EF9-A638-C4C6184BFC85.htm)