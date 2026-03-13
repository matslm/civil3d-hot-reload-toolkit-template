---
title: "Understand the AutoCAD Object Hierarchy (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-7E64FDE7-C818-4566-ADF8-C40D50D91E32.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Basics of the AutoCAD .NET API (.NET)", "Understand the AutoCAD Object Hierarchy (.NET)"]
---

# Understand the AutoCAD Object Hierarchy (.NET)

An object is the main building block of the AutoCAD .NET API. Each exposed object represents a precise part of AutoCAD. There are many different types of objects in the AutoCAD .NET API. Some of the objects represented in the AutoCAD .NET API are:

* Graphical objects such as lines, arcs, text, and dimensions
* Style settings such as layers, linetypes, and dimension styles
* Organizational structures such as layers, groups, and blocks
* The drawing display such as view and viewport
* Even the drawing and the AutoCAD application

The objects are structured in a hierarchical fashion, with the AutoCAD Application object at the root. This hierarchical structure is often referred to as the Object Model. The following illustration shows the basic relationships between the `Application` object and an entity that is in a `BlockTableRecord`, such as Model space. There are many more objects in the AutoCAD .NET API that are not represented here.

![](../images/GUID-1AA8F78F-DF90-4AA4-A975-A06FBF65231C.png)

**Parent topic:** [Basics of the AutoCAD .NET API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-79A4A44C-DF4C-46CC-B05C-311C8BD226C2.htm)

#### Related Concepts

* [Basics of the AutoCAD .NET API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-79A4A44C-DF4C-46CC-B05C-311C8BD226C2.htm)
* [The Application Object (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-06F95957-9A08-4036-BFB6-541C5B5F3A15.htm)
* [The Document Object (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-A43A20B7-A73A-4BBC-B871-B8E6B9D1006C.htm)
* [The Database Object (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-7313ECA1-4875-4946-82E3-C06A4074F807.htm)
* [Graphical and Non-graphical Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-1ECA7D76-EF28-43E3-A22B-CC2906270A73.htm)
* [The Collection Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-B55EF18D-1619-4475-8C0B-5215C2AD2B52.htm)
* [Non-Native Graphical and Nongraphical Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-4213EB7F-C21F-4361-BF12-176F897F44C8.htm)