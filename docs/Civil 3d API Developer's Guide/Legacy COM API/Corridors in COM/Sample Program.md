---
title: "Sample Program"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-B8E1054A-62FB-44B6-84C8-60E5428127DD.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Corridors in COM", "Sample Program"]
---

# Sample Program

## CorridorSample.dvb

**<installation-directory>\Sample\Civil 3D API\Vba\Corridor\CorridorSample.dvb**

The `CreateCorridorExample` subroutine demonstrates the creation of a simple corridor using the `AeccCorridors.Add` method. Before calling this subroutine, be sure the current document contains at least one assembly. A suitable drawing is the file *Corridor-2b.dwg* located in the *<installation-directory>\Help\Civil 3D Tutorials\Drawings*  directory.

The `GetCorridorInformationExample` subroutine extracts information of all existing corridors, baselines, feature lines, surfaces, assemblies, and subassemblies within the current document and displays the data in an instance of Word. A suitable drawing is the file *Corridor-4b.dwg* located in the *<installation-directory>\Help\Civil Tutorials\Drawings*  directory.

Note:

Microsoft Word must be running before starting this program.

**Parent topic:** [Corridors in COM](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-3C0B2292-8BE3-4403-88AA-D3D63738D3B7.htm)