---
title: "Create Lines (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-FFD27A95-25BD-48C6-AC7E-277C3358963A.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Create Objects (.NET)", "Create Lines (.NET)"]
---

# Create Lines (.NET)

The line is the most basic object in AutoCAD. You can create a variety of lines—single lines, and multiple line segments with and without arcs. In general, you draw lines by specifying coordinate points. Lines when created, inherit the current settings from the drawing database, such as layer, linetype and color.

To create a line, you create a new instance of one of the following objects:

Line
:   Creates a line.

Polyline
:   Creates a 2D lightweight polyline.

MLine
:   Creates a multiline.

Polyline2D
:   Creates a 2D polyline.

Polyline3D
:   Creates a 3D polyline.

Note: Polyline2D objects are the legacy polyline objects that were in AutoCAD prior to Release 14, and the Polyline object represents the new optimized polyline that was introduced with AutoCAD Release 14.

**Parent topic:** [Create Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DE29EA57-7E55-4AC0-B3B3-68749CA0DC0C.htm)

#### Related Concepts

* [Create Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DE29EA57-7E55-4AC0-B3B3-68749CA0DC0C.htm)
* [Create a Line Object (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-47E8A12E-2ED4-4E78-ADA3-AAC9B4223C3C.htm)
* [Create a Polyline Object (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-EC036F5A-1F02-40D3-B348-4193BA58CF0C.htm)