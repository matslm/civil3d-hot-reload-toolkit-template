---
title: "Overview"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-86293838-5313-47B7-89CB-1FA9DEB08ABA.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Creating Custom Subassemblies Using .NET", "The Subassembly Tool Catalog", "Overview"]
---

# Overview

An Autodesk tool catalog organizes groups of customized subassemblies and makes them available to Autodesk Civil 3D users. Autodesk tool catalogs are defined using xml-formatted files with an *.atc* (Autodesk Tool Catalog) extension. You also need to create a catalog registry file as catalogs must be registered in the Windows registry. Some items within the *.atc* and registry files must contain unique identifiers known as GUIDs (Global Unique Identifiers). New GUIDs can be created using the *GuidGen.exe* utility that is included with many Microsoft development products and is freely available for download from the Microsoft web site.

To create a tool catalog for a subassembly

1. Using Notepad or any other appropriate editor, create a plain ASCII text file named *<Name>Tools Catalog.atc,* where *<Name>* is the name of this new tool catalog. For information about the contents of the file, see [Creating a Tool Catalog ATC File](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-40C8020C-6B2F-4C8E-BC44-59CDEDD5C550.htm).

   Note:

   XML tags in ATC files are case-sensitive. Be sure that your tags match the case of the tags described in this chapter.
2. Save the *.atc* file to the location where your tool catalogs are stored. The default location is .
3. Create any optional files, such as images for icons displayed in the catalog and help files for subassemblies, and place these files in appropriate locations for reference.
4. Using Notepad or any other text editor, create a registry file for the tool catalog with the extension *.reg*. For more information, see [Creating a Tool Catalog Registry File](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-7D8F6D79-5662-4793-AB30-769A5C384CFF.htm).
5. Register the tool catalog by double-clicking on the *.reg* file. Once registered, the subassembly tool catalog will be displayed in the Autodesk Civil 3D Content Browser.

**Parent topic:** [The Subassembly Tool Catalog](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-763AE039-5923-4A29-ABCF-B00392896FB0.htm)