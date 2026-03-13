---
title: "Use the LayerStateManager to Manage Layer States (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C8A8FDAB-BF53-4B9E-96A7-94D1677E9AA7.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Save and Restore Layer States (.NET)", "Use the LayerStateManager to Manage Layer States (.NET)"]
---

# Use the LayerStateManager to Manage Layer States (.NET)

The
`LayerStateManager` object provides a set of functions for creating and manipulating saved layer states. Use the following
`LayerStateManager` functions for working with layer states:

DeleteLayerState
:   Deletes a saved layer state.

ExportLayerState
:   Exports the specified saved layer state to a LAS file.

ImportLayerState
:   Imports a layer state from the specified LAS file.

ImportLayerStateFromDb
:   Imports a layer state from another database.

RenameLayerState
:   Renames a saved layer state.

RestoreLayerState
:   Restores the specified layer state in the current drawing.

SaveLayerState
:   Saves the specified layer state and its properties.

The
`LayerStateManager` object for a database can be accessed by using the
`LayerManagerState` property of a
`Database` object.

## C#

```
Document acDoc = Application.DocumentManager.MdiActiveDocument;
Database acCurDb = acDoc.Database;
 
LayerStateManager acLyrStMan;
acLyrStMan = acCurDb.LayerStateManager;
```

## VB.NET

```
Dim acDoc As Document = Application.DocumentManager.MdiActiveDocument
Dim acCurDb As Database = acDoc.Database
 
Dim acLyrStMan As LayerStateManager
acLyrStMan = acCurDb.LayerStateManager
```

## VBA/ActiveX Code Reference

After you retrieve the
`LayerStateManager` object, you must associate a database with it before you can access the object's methods. Use the
`SetDatabase` method to associate a database with the
`LayerStateManager.`

```
Dim oLSM As AcadLayerStateManager
Set oLSM = ThisDrawing.Application. _
               GetInterfaceObject("AutoCAD.AcadLayerStateManager.25")
 
oLSM.SetDatabase ThisDrawing.Database
```

**Parent topic:** [Save and Restore Layer States (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-8879211F-CF1A-42E8-AFA5-AE637CAB903A.htm)

#### Related Concepts

* [Save and Restore Layer States (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-8879211F-CF1A-42E8-AFA5-AE637CAB903A.htm)
* [Save Layer States (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-9AFCDEAB-96B1-4F03-B118-C26665BB920F.htm)
* [Rename Layer States (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-EC776934-5880-4BCA-A149-7871E1A8CA68.htm)
* [Delete Layer States (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-FAA21868-C4CB-4070-A546-328AAEEB5B7B.htm)
* [Restore Layer States (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-0C21B797-40E0-472C-91C0-522F3F6EB859.htm)
* [Export and Import Saved Layer States (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-67A027CA-085C-4377-81D2-12DF67A4F76A.htm)