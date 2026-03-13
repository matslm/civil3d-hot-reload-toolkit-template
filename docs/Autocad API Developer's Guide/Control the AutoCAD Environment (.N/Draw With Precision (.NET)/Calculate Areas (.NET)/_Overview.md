---
title: "Calculate Areas (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-B931C746-6FCF-4E89-9C71-62C2C0C86A9A.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Control the AutoCAD Environment (.NET)", "Draw With Precision (.NET)", "Calculate Areas (.NET)"]
---

# Calculate Areas (.NET)

You can find the area of an arc, circle, ellipse, lightweight polyline, polyline, region, hatch, planar-closed spline or any other entity that is derived from the base type of Curve by using the `Area` property.

If you need to calculate the combined area of more than one object, you can keep a running total as you add or use the Boolean method on a series of regions to obtain a single region representing the desired area. From this single region you can use the `Area` property to obtain its area. The calculated area differs according to the type of object you query.

**Parent topic:** [Draw With Precision (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-6BB4EBCD-8EFD-4EFF-9ABE-010A9B58547C.htm)

#### Related Concepts

* [Draw With Precision (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-6BB4EBCD-8EFD-4EFF-9ABE-010A9B58547C.htm)
* [Calculate a Defined Area (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-E0A39BC4-5C46-40D1-8507-A5F9E8D82E70.htm)