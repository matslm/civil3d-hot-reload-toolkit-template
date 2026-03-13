---
title: "Work With Linetypes (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-81423588-A182-4511-B9D3-115014C96BCE.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Use Layers, Colors, and Linetypes (.NET)", "Work With Linetypes (.NET)"]
---

# Work With Linetypes (.NET)

A linetype is a repeating pattern of dashes, dots, and blank spaces. A complex linetype is a repeating pattern of symbols. To use a linetype you must first load it into your drawing. A linetype definition must exist in a LIN library file before a linetype can be loaded into a drawing. To load a linetype into your drawing, use the member method
`LoadLineTypeFile` of a
`Database` object.

Note: The linetypes used internally by AutoCAD should not be confused with the hardware linetypes provided by some plotters. The two types of dashed lines produce similar results. Do
*not* use both types at the same time, however, because the results can be unpredictable.

## Load a linetype into AutoCAD

This example attempts to load the linetype “CENTER” from the
*acad.lin* file. If the linetype already exists, or the file does not exist, then a message is displayed.

### C#

```
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
 
[CommandMethod("LoadLinetype")]
public static void LoadLinetype()
{
    // Get the current document and database
    Document acDoc = Application.DocumentManager.MdiActiveDocument;
    Database acCurDb = acDoc.Database;

    // Start a transaction
    using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())
    {
        // Open the Linetype table for read
        LinetypeTable acLineTypTbl;
        acLineTypTbl = acTrans.GetObject(acCurDb.LinetypeTableId,
                                         OpenMode.ForRead) as LinetypeTable;

        string sLineTypName = "Center";

        if (acLineTypTbl.Has(sLineTypName) == false)
        {
            // Load the Center Linetype
            acCurDb.LoadLineTypeFile(sLineTypName, "acad.lin");
        }

        // Save the changes and dispose of the transaction
        acTrans.Commit();
    }
}
```

### VB.NET

```
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
 
<CommandMethod("LoadLinetype")> _
Public Sub LoadLinetype()
    '' Get the current document and database
    Dim acDoc As Document = Application.DocumentManager.MdiActiveDocument
    Dim acCurDb As Database = acDoc.Database

    '' Start a transaction
    Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()

        '' Open the Linetype table for read
        Dim acLineTypTbl As LinetypeTable
        acLineTypTbl = acTrans.GetObject(acCurDb.LinetypeTableId, _
                                         OpenMode.ForRead)

        Dim sLineTypName As String = "Center"

        If acLineTypTbl.Has(sLineTypName) = False Then
            '' Load the Center Linetype
            acCurDb.LoadLineTypeFile(sLineTypName, "acad.lin")
        End If

        '' Save the changes and dispose of the transaction
        acTrans.Commit()
    End Using
End Sub
```

### VBA/ActiveX Code Reference

```
Sub LoadLinetype()
    On Error GoTo ERRORHANDLER
 
    Dim linetypeName As String
    linetypeName = "CENTER"
 
    ' Load "CENTER" line type from acad.lin file
    ThisDrawing.Linetypes.Load linetypeName, "acad.lin"
    Exit Sub
 
ERRORHANDLER:
    MsgBox Err.Description
End Sub
```

**Parent topic:** [Use Layers, Colors, and Linetypes (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-758F50B8-A2A0-429C-AC31-88B3A2D1BBBC.htm)

#### Related Concepts

* [Use Layers, Colors, and Linetypes (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-758F50B8-A2A0-429C-AC31-88B3A2D1BBBC.htm)
* [Make a Linetype Active (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-91849E9C-7B67-471D-9925-B55D0B25ABB6.htm)
* [Rename Linetypes (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CF624D9E-67E0-430B-BD14-431633224222.htm)
* [Delete Linetypes (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-380C741C-147D-4289-8C3A-19BF7DDC1CFA.htm)
* [Change Linetype Descriptions (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F0A370D6-0BEB-4EA1-A34B-53C93FEE9C84.htm)
* [Specify Linetype Scale (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-29F800D2-45BC-4910-8C52-3B7E51BFC577.htm)