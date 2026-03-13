---
title: "Assign the Hatch Pattern Type and Name (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-75E9A9E0-338F-4F77-9C3C-0F756AC31BE4.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Create Objects (.NET)", "Create Hatches (.NET)", "Assign the Hatch Pattern Type and Name (.NET)"]
---

# Assign the Hatch Pattern Type and Name (.NET)

AutoCAD supplies a solid-fill and more than fifty industry-standard hatch patterns. Hatch patterns highlight a particular feature or area of a drawing. For example, patterns can help differentiate the components of a 3D object or represent the materials that make up an object.

You can use a pattern supplied with AutoCAD or one from an external pattern library.

To specify a unique pattern, you must specify both a pattern type and name for the Hatch object. The pattern type specifies where to look up the pattern name. When entering the pattern type, use one of the following constants:

HatchPatternType.PreDefined
:   Selects the pattern name from those defined in the  *acad.pat*  or  *acadiso.pat*  files.

HatchPatternType.UserDefined
:   Defines a pattern of lines using the current linetype.

HatchPatternType.CustomDefined
:   Selects the pattern name from a PAT other than the  *acad.pat*  or  *acadiso.pat*  files.

When entering the pattern name, use a name that is valid for the file specified by the pattern type.

**Parent topic:** [Create Hatches (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-26CEE5F5-F141-4256-B652-859F5D1330B0.htm)

#### Related Concepts

* [Create Hatches (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-26CEE5F5-F141-4256-B652-859F5D1330B0.htm)