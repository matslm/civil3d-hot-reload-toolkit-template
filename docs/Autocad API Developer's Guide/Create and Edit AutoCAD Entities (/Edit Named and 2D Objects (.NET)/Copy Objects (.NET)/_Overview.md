---
title: "Copy Objects (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-0A20B625-3972-4428-AAF2-545E3D32EE30.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Edit Named and 2D Objects (.NET)", "Copy Objects (.NET)"]
---

# Copy Objects (.NET)

You can create a copy of most non-graphical and graphical objects within the same database. An object can be copied in the same database with the
`Clone` method or properties from one object can be copied to another object using the
`CopyFrom` method. Once an object is copied, you can modify the returned object before adding it to the database. The
`Clone` and
`TransformBy` methods can be used together to replicate many modifying commands, such as COPY, MIRROR, ARRAY, and OFFSET. The
`CopyFrom` method can be used to replicate the MATCHPROP command with objects in the same database.

To copy non-graphical or graphical objects between two drawings, use the
`WblockCloneObjects` method. This method enables you to replicate the COPYBASE, COPYCLIP, and PASTECLIP commands.

Note: Do not use the
`CopyFrom` method to copy objects between two databases.

**Parent topic:** [Edit Named and 2D Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-E9D01C58-707B-47BD-86C3-0E199E58FB36.htm)

#### Related Concepts

* [Edit Named and 2D Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-E9D01C58-707B-47BD-86C3-0E199E58FB36.htm)
* [Copy an Object (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-7EF7D821-473B-4F05-A98C-AEEC9F86A871.htm)
* [Copy Objects Between Databases (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-E02A8AAF-61FF-4C72-8960-0AEEBBEC2594.htm)
* [Transform Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-D4348E23-7ECB-48F6-90B7-FB7EF42DFA8D.htm)