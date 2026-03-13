---
title: "Listing Corridors"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-577FD7B5-A3F2-4DAE-9DD9-B6EF5BD1B669.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Corridors", "Corridors", "Listing Corridors"]
---

# Listing Corridors

The collection of all corridors in a document are held in the `CivilDocument.CorridorCollection` property.

The following sample displays the name and the largest possible triangle side of every corridor in a document:

```
public static void ListCorridors()
{
    CivilDocument doc = CivilApplication.ActiveDocument;
    Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
   
    using (Transaction ts = Application.DocumentManager.MdiActiveDocument.
        Database.TransactionManager.StartTransaction())
    {
        foreach (ObjectId objId in doc.CorridorCollection)
        {
            Corridor myCorridor = ts.GetObject(objId, OpenMode.ForRead) as Corridor;
            ed.WriteMessage("Corridor: {0}\nLargest possible triangle side: {1}\n", 
                myCorridor.Name, myCorridor.MaximumTriangleSideLength);
        }
    }
   
}
```

**Parent topic:** [Corridors](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-F99C1FF9-7BBA-4D8F-9EB7-E75D773699C6.htm)