---
title: "Define Commands and AutoLISP Functions (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-6F28B00B-36BE-4D32-998E-39B62A69E52F.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Basics of the AutoCAD .NET API (.NET)", "Define Commands and AutoLISP Functions (.NET)"]
---

# Define Commands and AutoLISP Functions (.NET)

Commands and AutoLISP® functions can be defined with the AutoCAD .NET API through the use of two attributes: `CommandMethod` and `LispFunction`. You place one of the two attributes before the method that should be called when the command or AutoLISP function is executed in AutoCAD.

Methods used for commands should not be defined with arguments. However, a method used to define an AutoLISP function should be defined with a single argument of the `ResultBuffer` object type.

**Parent topic:** [Basics of the AutoCAD .NET API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-79A4A44C-DF4C-46CC-B05C-311C8BD226C2.htm)

#### Related Concepts

* [Basics of the AutoCAD .NET API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-79A4A44C-DF4C-46CC-B05C-311C8BD226C2.htm)
* [Command Definition (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F77E8FE0-8034-4704-93BD-F717608F8223.htm)
* [AutoLISP Function Definition (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-3B2760FE-A0DC-4229-AEBE-5CC83290BA95.htm)