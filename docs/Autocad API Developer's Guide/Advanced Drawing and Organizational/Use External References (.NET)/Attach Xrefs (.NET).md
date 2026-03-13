---
title: "Attach Xrefs (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-D6EE5FE7-C0BC-4E9B-AAE3-3B5A14B870FE.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Advanced Drawing and Organizational Techniques (.NET)", "Use External References (.NET)", "Attach Xrefs (.NET)"]
---

# Attach Xrefs (.NET)

Attaching an xref links one drawing (the reference file, or xref) to the current drawing. When a drawing references an xref, AutoCAD attaches only the xref definition to the drawing, unlike regular blocks, where the block definition and the contents of the block are stored with the current drawing. AutoCAD reads the reference drawing to determine what to display in the current drawing. If the reference file is missing or corrupt, its data is not displayed in the current drawing. Each time you open a drawing, AutoCAD loads all graphical and nongraphical (such as layers, linetypes, and text styles) objects from referenced files. If the VISRETAIN system variable is on, AutoCAD stores any updated xref-dependent layer information in the current drawing.

You can attach as many copies of an xref as you want, and each can have a different position, scale, and rotation. You can also control the dependent layers and linetype properties that are defined in the xref.

To attach an xref, use the
`AttachXref` method. This method requires you to input the path and file name of the drawing to be referenced, and the name of the xref that is used in the current drawing. The
`AttachXref` method returns the
`ObjectId` of the newly created object. The returned
`ObjectId` is used to create a new
`BlockReference` object and define its placement in the drawing. Once the
`BlockReference` object is created, you can adjust its rotation and scale.

For more information on attaching xrefs, see “About Attaching and Detaching Referenced Drawings (Xrefs)” in the product Help system.

## Attach an external reference to a drawing

This example displays all the blocks in the current drawing before and after adding an external reference. This example uses the
*Exterior Elevations.dwg* file found in the
*Sample* directory. If you do not have this file available, or if it is located in a different directory, insert a valid path and file name.

### C#

```
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

[CommandMethod("AttachingExternalReference")]
public void AttachingExternalReference()
{
    // Get the current database and start a transaction
    Database acCurDb;
    acCurDb = Application.DocumentManager.MdiActiveDocument.Database;

    using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())
    {
        // Create a reference to a DWG file
        string PathName = "C:\\AutoCAD\\Sample\\Sheet Sets\\Architectural\\Res\\Exterior Elevations.dwg";
        ObjectId acXrefId = acCurDb.AttachXref(PathName, "Exterior Elevations");

        // If a valid reference is created then continue
        if (!acXrefId.IsNull)
        {
            // Attach the DWG reference to the current space
            Point3d insPt = new Point3d(1, 1, 0);
            using (BlockReference acBlkRef = new BlockReference(insPt, acXrefId))
            {
                BlockTableRecord acBlkTblRec;
                acBlkTblRec = acTrans.GetObject(acCurDb.CurrentSpaceId, OpenMode.ForWrite) as BlockTableRecord;

                acBlkTblRec.AppendEntity(acBlkRef);
                acTrans.AddNewlyCreatedDBObject(acBlkRef, true);
            }
        }

        // Save the new objects to the database
        acTrans.Commit();

        // Dispose of the transaction
    }
}
```

### VB.NET

```
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Geometry

<CommandMethod("AttachingExternalReference")> _
Public Sub AttachingExternalReference()
    ' Get the current database and start a transaction
    Dim acCurDb As Autodesk.AutoCAD.DatabaseServices.Database
    acCurDb = Application.DocumentManager.MdiActiveDocument.Database

    Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()
        ' Create a reference to a DWG file
        Dim PathName As String = "C:\AutoCAD\Sample\Sheet Sets\Architectural\Res\Exterior Elevations.dwg"
        Dim acXrefId As ObjectId = acCurDb.AttachXref(PathName, "Exterior Elevations")

        ' If a valid reference is created then continue
        If Not acXrefId.IsNull Then
            ' Attach the DWG reference to the current space
            Dim insPt As New Point3d(1, 1, 0)
            Using acBlkRef As New BlockReference(insPt, acXrefId)

                Dim acBlkTblRec As BlockTableRecord
                acBlkTblRec = acTrans.GetObject(acCurDb.CurrentSpaceId, OpenMode.ForWrite)

                acBlkTblRec.AppendEntity(acBlkRef)
                acTrans.AddNewlyCreatedDBObject(acBlkRef, True)
            End Using
        End If

        ' Save the new objects to the database
        acTrans.Commit()

        ' Dispose of the transaction
    End Using
End Sub
```

### VBA/ActiveX Code Reference

```
Sub AttachingExternalReference()
    Dim InsertPoint(0 To 2) As Double
    Dim insertedBlock As AcadExternalReference
    Dim PathName As String
 
    ' Define external reference to be inserted
    InsertPoint(0) = 1
    InsertPoint(1) = 1
    InsertPoint(2) = 0
    PathName = "C:\AutoCAD\Sample\Sheet Sets\Architectural\Res\Exterior Elevations.dwg"
 
    ' Add the external reference to the drawing
    Set insertedBlock = ThisDrawing.ActiveLayout.Block. _
    AttachExternalReference(PathName, "Exterior Elevations", InsertPoint, 1, 1, 1, 0, False)
End Sub
```

**Parent topic:** [Use External References (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-563BAE97-48B1-4DCE-9DDA-16D8C6F13E23.htm)

#### Related Concepts

* [Detach Xrefs (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DEAD46A2-BC5B-4313-B84B-AB2B62D66DB2.htm)
* [Reload Xrefs (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-5716B433-01F1-4510-8B46-DDCB6E78C7EF.htm)
* [Use External References (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-563BAE97-48B1-4DCE-9DDA-16D8C6F13E23.htm)
* [Work with Raster Images (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-9C12C46C-FC03-4E41-B27F-06FFD4991A84.htm)
* [Advanced Drawing and Organizational Techniques (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CD733E01-7E42-45E8-AAC9-63B6EC39FF4E.htm)