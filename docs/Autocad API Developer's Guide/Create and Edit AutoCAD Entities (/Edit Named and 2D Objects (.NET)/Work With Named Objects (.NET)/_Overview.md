---
title: "Work With Named Objects (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-95B5DDB0-E2D1-4E60-A7E2-AE26959C3D83.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Edit Named and 2D Objects (.NET)", "Work With Named Objects (.NET)"]
---

# Work With Named Objects (.NET)

In addition to the graphical objects used by AutoCAD, there are several types of nongraphical objects stored in a drawing database. These objects have descriptive designations associated with them. For example, blocks, layers, groups, and dimension styles all have a name assigned to them and in most cases can be renamed. The names of symbol table records are displayed in the user interface of AutoCAD, while the object id of an object is used to reference the object in most cases throughout the AutoCAD .NET API.

For example, the object id of a `LayerTableRecord` object is assigned to a graphical object’s Layer property and not the actual name that is assigned to the `LayerTableRecord`. However, the object id of a `LayerTableRecord` object can be obtained from the Layer table using the name of the layer you want to access.

**Parent topic:** [Edit Named and 2D Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-E9D01C58-707B-47BD-86C3-0E199E58FB36.htm)

#### Related Concepts

* [Edit Named and 2D Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-E9D01C58-707B-47BD-86C3-0E199E58FB36.htm)
* [Purge Unreferenced Named Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-288B4394-C51F-48CC-8B8C-A27873CFFDC1.htm)
* [Rename Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DFDAFCC3-6916-4B28-9AD8-BE537322B3DD.htm)