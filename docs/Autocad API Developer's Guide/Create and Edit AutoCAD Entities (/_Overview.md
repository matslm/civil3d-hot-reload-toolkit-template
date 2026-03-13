---
title: "Create and Edit AutoCAD Entities (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F5601807-2FA9-486F-A212-E693D452D81F.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)"]
---

# Create and Edit AutoCAD Entities (.NET)

You can create a range of objects, from simple lines and circles to spline curves, ellipses, and associative hatch areas. In general, you add objects to a `BlockTableRecord` object using the `AppendEntity` function. Once an object is created, you can change its properties such as layer, color, and linetype.

The drawing database is similar to other database programs, you can think of a Line object in Model space as table record and Model space as its database table. When working with a database, you must open and close records before working with them. The objects stored in the `Database` object are no different, you use the `GetObject` function to retrieve an object from the database and define how you want to work with the object.

#### Related Concepts

* [Open and Close Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-774B7F11-E374-450B-9E2E-CAE02F4AADFE.htm)
* [Create Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DE29EA57-7E55-4AC0-B3B3-68749CA0DC0C.htm)
* [Work With Selection Sets (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DE15FB0E-8669-4D58-9261-DB4CF86F89F3.htm "A selection set can consist of a single object, or it can be a more complex grouping: for example, the set of objects on a certain layer.")
* [Edit Named and 2D Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-E9D01C58-707B-47BD-86C3-0E199E58FB36.htm)
* [Use Layers, Colors, and Linetypes (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-758F50B8-A2A0-429C-AC31-88B3A2D1BBBC.htm)
* [Save and Restore Layer States (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-8879211F-CF1A-42E8-AFA5-AE637CAB903A.htm)
* [Add Text to Drawings (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-0B24EA86-1E83-465F-A6F2-DA7442F0821D.htm)