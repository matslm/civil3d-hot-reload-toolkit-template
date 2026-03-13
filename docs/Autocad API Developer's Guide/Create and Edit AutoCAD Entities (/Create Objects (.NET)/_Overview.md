---
title: "Create Objects (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DE29EA57-7E55-4AC0-B3B3-68749CA0DC0C.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Create Objects (.NET)"]
---

# Create Objects (.NET)

AutoCAD often offers several different ways to create the same graphical object. While the AutoCAD .NET API does not offer the same combinations of creating objects, it does offer a basic object constructor for each object type but also offers overrides for many of the object constructors as well.

For example, in AutoCAD there are four different ways you can create a circle: (1) by specifying the center and radius, (2) by two points defining the diameter, (3) by three points defining the circumference, or (4) by two tangents and a radius. However, in AutoCAD .NET API there is two creation methods provided to create a circle. One method accepts no parameters, while the second requires a center point, the normal direction for the circle, and a radius.

Note: Objects are created using the New keyword and then appended to the parent object using `Add` or `AppendEntity` based on if you are working with a container (symbol table or dictionary) or a `BlockTableRecord` object.

## Set the default property values for an object

When a new graphical object is created, the following entity property values are assigned the current entity values defined in the database of the current document:

* Color
* Layer
* Linetype
* Linetype scale
* Lineweight
* Plot style name
* Visibility
* Transparency

Note: If the properties of an object need to be set to the default values of the current database, call the `SetDatabaseDefaults` method of the object to be changed.

**Parent topic:** [Create and Edit AutoCAD Entities (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F5601807-2FA9-486F-A212-E693D452D81F.htm)

#### Related Concepts

* [Create and Edit AutoCAD Entities (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F5601807-2FA9-486F-A212-E693D452D81F.htm)
* [Determine the Parent Object (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-FAFA37D8-1C15-408B-8419-DB27225664B6.htm)
* [Create Lines (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-FFD27A95-25BD-48C6-AC7E-277C3358963A.htm)
* [Create Curved Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DF482DCC-2C32-4928-8993-A109C9EB8A3A.htm)
* [Create Point Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-1FA67D6C-09E2-4051-BE77-08463C1C0072.htm)
* [Create Solid-Filled Areas (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-0544EA65-BA88-4BC5-99F4-D9FAF7BE9FE9.htm)
* [Work With Regions (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F4895976-6867-4AFC-A96F-BF522ACE5AC7.htm)
* [Create Hatches (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-26CEE5F5-F141-4256-B652-859F5D1330B0.htm)
* [Use Transactions to Access and Create Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-50FD6118-B2D1-4313-A7D6-830794DFDEFA.htm)
* [Dispose Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-9DFB5767-F8D6-4A88-87D6-9676C0189369.htm)