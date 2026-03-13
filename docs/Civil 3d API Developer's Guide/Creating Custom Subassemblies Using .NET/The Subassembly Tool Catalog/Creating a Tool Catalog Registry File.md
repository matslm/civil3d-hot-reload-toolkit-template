---
title: "Creating a Tool Catalog Registry File"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-7D8F6D79-5662-4793-AB30-769A5C384CFF.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Creating Custom Subassemblies Using .NET", "The Subassembly Tool Catalog", "Creating a Tool Catalog Registry File"]
---

# Creating a Tool Catalog Registry File

Each subassembly tool catalog needs to be registered in the Windows registry before it can be used by Autodesk Civil 3D. One way to do this is to create a *.reg* file, which is a text file containing the new keys, value names, and values to be added to the registry. Double-clicking on the *.reg* file will modify the registry. After this process, the *.reg* file is no longer needed.

The following is the contents of a *.reg* file that registers the *Autodesk Civil 3D Imperial Corridor Catalog.atc* catalog file. See the table following the sample for descriptions of the contents.

```
1)  REGEDIT4
2)
3)  [HKEY_CURRENT_USER\Software\Autodesk\Autodesk Content Browser\60]
4)
5)  [HKEY_CURRENT_USER\Software\Autodesk\Autodesk Content Browser\60\RegisteredGroups]
6)  
7)  [HKEY_CURRENT_USER\Software\Autodesk\Autodesk Content Browser\60\RegisteredGroups\Roads Group]
8)  "ItemID"="{5BD79109-BC69-41eb-9AC8-7E9CD469C8D3}"
9)  "ItemName"="Roads Group"
10)  
11)  
12)  [HKEY_CURRENT_USER\Software\Autodesk\Autodesk Content Browser\60\RegisteredCatalogs]
13)  
14)  [HKEY_CURRENT_USER\Software\Autodesk\Autodesk Content Browser\60\RegisteredCatalogs\Autodesk Civil 3D Imperial Corridor Catalog]
15)  "ItemID"="{410D0B43-19B3-402f-AB41-05A6E174AA3F}"
16)  "Image"=".\\Images\\AeccRoadway.png"
17)  "Url"="C:\\Documents and Settings\\All Users\\Application Data\\Autodesk\\C3D2010\\enu\\Tool Catalogs\\Road Catalog\\Autodesk Civil 3D Imperial Corridor Catalog.atc"
18)  "DisplayName"="Civil 3D Subassemblies (Imperial Units)"
19)  "Description"="Imperial Units Subassemblies"
20)  "Publisher"="Autodesk"
21)  "ToolTip"="Autodesk Civil 3D Imperial Corridor Catalog"
22)  "GroupType"="{5BD79109-BC69-41eb-9AC8-7E9CD469C8D3}"
23)  
24)  
25)  [HKEY_CURRENT_USER\Software\Autodesk\AutoCAD\R18\ACAD-8000:409\AEC\60\General\Tools]
26)  "ToolContentRoot"="C:\\Documents and Settings\\All Users\\Application Data\\Autodesk\\C3D2010\\enu\\Tool Catalogs\\Road Catalog"
```

| Line Number | Description |
| --- | --- |
| 1 | Identifies the file as a registry edit file. |
| 3-9 | These statements create a Group for the Autodesk Content Browser. The group id name is “Roads Group”. Each group must have a unique GUID for the “ItemID”. The Roads Group is already registered by the Autodesk Civil 3D installation. If you are adding a catalog to this group, you should use the GUID shown in the example. |
| 12 | Identifies the item being registered as an Autodesk catalog for the Autodesk Content Browser. |
| 14-22 | These statements define the Catalog Entry. |
| 15 | “ItemId” must be a unique GUID for this catalog. This must match the GUID for the Catalog ItemID value in the catalog *.atc* file. |
| 16 | “Image” must be a unique GUID for this catalog. This must match the GUID for the Catalog ItemID value in the catalog *.atc* file. |
| 17 | “URL” is a pointer to the catalog .*atc* file that is being registered. |
| 18 | “DisplayName” is the text that displays beneath the catalog icon in the Autodesk Content Browser. |
| 19 | “Description” – description of the tool catalog. |
| 20 | “Publisher” – name of the creator / publisher of the tool catalog. |
| 21 | “ToolTip” – the text that displays for the tooltip when the cursor is hovered over the tool catalog in the Catalog Browser. |
| 22 | “GroupType” – the GUID that defines which the tool catalog belongs to in the Catalog Browser. This GUID must match the one used for the “ItemID” in the group definition. |
| 26 | The directory where the .atc catalog files are located. |

**Parent topic:** [The Subassembly Tool Catalog](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-763AE039-5923-4A29-ABCF-B00392896FB0.htm)