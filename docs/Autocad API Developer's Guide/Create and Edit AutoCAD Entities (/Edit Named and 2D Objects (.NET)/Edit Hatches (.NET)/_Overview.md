---
title: "Edit Hatches (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-6724C1A9-70C7-4C0A-9952-00E06249C6C0.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Edit Named and 2D Objects (.NET)", "Edit Hatches (.NET)"]
---

# Edit Hatches (.NET)

You can edit both hatch boundaries and hatch patterns. If you edit the boundary of an associative hatch, the pattern is updated as long as the editing results in a valid boundary. Associative hatches are updated even if they are on layers that are turned off. You can modify hatch patterns or choose a new pattern for an existing hatch, but associativity can only be set when a hatch is created. You can check to see if a `Hatch` object is associative by using the `Associative` property.

You must re-evaluate a hatch using the `EvaluateHatch` method to see any edits to the hatch.

**Parent topic:** [Edit Named and 2D Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-E9D01C58-707B-47BD-86C3-0E199E58FB36.htm)

#### Related Concepts

* [Edit Named and 2D Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-E9D01C58-707B-47BD-86C3-0E199E58FB36.htm)
* [Edit Hatch Boundaries (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-89CAED67-B3A0-4045-9D8B-9034D67E8D91.htm)
* [Edit Hatch Patterns (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-68CAD757-1857-4250-B92B-430318E5C110.htm)
* [Create a Hatch Object (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-483D7C81-71E6-4775-914E-F4D6B99248ED.htm)