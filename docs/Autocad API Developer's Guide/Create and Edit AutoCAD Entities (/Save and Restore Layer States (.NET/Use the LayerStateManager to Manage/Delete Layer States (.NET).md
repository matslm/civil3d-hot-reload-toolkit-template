---
title: "Delete Layer States (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-FAA21868-C4CB-4070-A546-328AAEEB5B7B.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Save and Restore Layer States (.NET)", "Use the LayerStateManager to Manage Layer States (.NET)", "Delete Layer States (.NET)"]
---

# Delete Layer States (.NET)

The
`DeleteLayerState` method removes a saved layer state from a drawing. The following code deletes the layer state saved under the name ColorLinetype.

## C#

```
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
 
[CommandMethod("RemoveLayerState")]
public static void RemoveLayerState()
{
    // Get the current document
    Document acDoc = Application.DocumentManager.MdiActiveDocument;

    LayerStateManager acLyrStMan;
    acLyrStMan = acDoc.Database.LayerStateManager;

    string sLyrStName = "ColorLinetype";

    if (acLyrStMan.HasLayerState(sLyrStName) == true)
    {
        acLyrStMan.DeleteLayerState(sLyrStName);
    }
}
```

## VB.NET

```
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
 
<CommandMethod("RemoveLayerState")> _
Public Sub RemoveLayerState()
    '' Get the current document
    Dim acDoc As Document = Application.DocumentManager.MdiActiveDocument

    Dim acLyrStMan As LayerStateManager
    acLyrStMan = acDoc.Database.LayerStateManager

    Dim sLyrStName As String = "ColorLinetype"

    If acLyrStMan.HasLayerState(sLyrStName) = True Then
        acLyrStMan.DeleteLayerState(sLyrStName)
    End If
End Sub
```

## VBA/ActiveX Code Reference

```
Sub RemoveLayerState()
    Dim oLSM As AcadLayerStateManager
    Set oLSM = ThisDrawing.Application. _
                   GetInterfaceObject("AutoCAD.AcadLayerStateManager.25")
 
    oLSM.SetDatabase ThisDrawing.Database
    oLSM.Delete "ColorLinetype"
End Sub
```

**Parent topic:** [Use the LayerStateManager to Manage Layer States (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C8A8FDAB-BF53-4B9E-96A7-94D1677E9AA7.htm)

#### Related Concepts

* [Use the LayerStateManager to Manage Layer States (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C8A8FDAB-BF53-4B9E-96A7-94D1677E9AA7.htm)