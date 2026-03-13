---
title: "Installing Custom Subassemblies"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-8F9A5C64-4EBE-433E-89B8-92F776DBACFD.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Creating Custom Subassemblies Using .NET", "Installing Custom Subassemblies"]
---

# Installing Custom Subassemblies

Once you’ve created a custom subassembly, you can install it on other Autodesk Civil 3D users’ machines.

Note:

It’s simpler to create a subassembly package file to distribute to users than to install custom subassemblies manually. See [Exporting Subassemblies Using a Package File](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-B749C4D6-7EAC-42EA-89EB-25178126DF4D.htm).

To install a custom subassembly:

1. Copy the compiled Autodesk Civil 3D subassembly *.dll*  library to its destination directory. By default, libraries are located in *<Autodesk Civil 3D Install Directory>\Sample\Civil 3D API\C3DstockSubAssemblies*.
2. Copy the tool catalog *.atc* files to its destination directory. The tool catalog files are normally located in the directory. For information about creating these, see [Creating a Tool Catalog ATC File](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-40C8020C-6B2F-4C8E-BC44-59CDEDD5C550.htm).
3. Copy optional files such as the image file representing the subassemblies or the help file to their destination directory. Images are normally located in , and help files are normally located in , although these can be any directory as long as the *.atc* file has the correct relative path information. For information about creating help files, see [Creating Subassembly Help Files](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-D08C5392-0E8E-423D-A160-9849F3FDF241.htm)
4. Copy the catalog cover page *.html* file to its destination. Usually this is the same location as the *.atc* file, although it can be any directory as long as the *.atc* file has the correct relative path information. For information about creating cover pages, see [Creating a Tool Catalog Cover Page](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-DAA35D43-162C-419E-931A-AC1D27568B3F.htm).
5. Register the tool catalog using a registry (*.reg*) file. This *.reg* file must have the correct paths to the *.atc* file and the catalog image file from steps 2) and 3). For information about creating registry files, see [Creating a Tool Catalog Registry File](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-7D8F6D79-5662-4793-AB30-769A5C384CFF.htm)

**Parent topic:** [Creating Custom Subassemblies Using .NET](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-E295BF67-F60C-49D3-A918-329D1E4FAFC5.htm)