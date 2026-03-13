---
title: Autodesk.Aec.DatabaseServices.StreamIntersect
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > StreamIntersect
---

# Autodesk.Aec.DatabaseServices.StreamIntersect

## Summary
Represents a stream for calculating intersections.

## Properties

### GsSelectionMarker
Gets the current GS selection marker.

**Returns:** The current GS selection marker.

## Methods

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database,System.IntPtr)
Initializes a new instance of the StreamIntersect class using the specified database and GS marker type.

- **`db`**: The specified database.
- **`gsMarker`**: The specified GS marker type.

### IntersectWith(Autodesk.Aec.DatabaseServices.StreamIntersect,Autodesk.AutoCAD.Geometry.Point3dCollection)
Intersects the current stream with another stream and stores the intersections in the point collection.

- **`otherPipe`**: The other stream to intersect with.
- **`points`**: The intersections.

**Returns:** The number of intersections.
