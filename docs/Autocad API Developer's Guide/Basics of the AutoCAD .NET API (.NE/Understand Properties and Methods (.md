---
title: "Understand Properties and Methods (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-BBB96065-DDD4-48EF-9134-D710CFE9F2D8.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Basics of the AutoCAD .NET API (.NET)", "Understand Properties and Methods (.NET)"]
---

# Understand Properties and Methods (.NET)

Each object has associated properties and methods. Properties describe aspects of the individual object, while methods are actions that can be performed on the individual object. Once an object is created, you can query and edit the object through its properties and methods.

For example, a Circle object has a `Center` property. This property represents the point in the world coordinate system (WCS) at the center of that circle. To change the center of the circle, simply set the `Center` property to a new point. The `Circle` object also has a method called `GetOffsetCurves`. This method creates a new object at a specified offset distance from the existing circle.

To see a list of all properties and methods for the `Circle` object, refer to the `Circle` object reference topic or use the Object Browser in Microsoft® Visual Studio®.

**Parent topic:** [Basics of the AutoCAD .NET API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-79A4A44C-DF4C-46CC-B05C-311C8BD226C2.htm)

#### Related Concepts

* [Basics of the AutoCAD .NET API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-79A4A44C-DF4C-46CC-B05C-311C8BD226C2.htm)
* [Access and Search Referenced Libraries with the Object Browser (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-93E37395-0141-4C10-9A75-FA52954C44B1.htm)