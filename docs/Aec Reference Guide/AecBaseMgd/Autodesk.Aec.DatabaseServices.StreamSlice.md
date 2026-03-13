---
title: Autodesk.Aec.DatabaseServices.StreamSlice
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > StreamSlice
---

# Autodesk.Aec.DatabaseServices.StreamSlice

## Summary
Represents a stream that slices a collection of entities on a defined plane.

## Methods

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Vector3d)
Initializes a new instance of the StreamSlice class using the specified database and parameters.

- **`db`**: The specified database.
- **`origin`**: The origin.
- **`uDirection`**: The U direction.
- **`vDirection`**: The V direction.

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Plane)
Initializes a new instance of the StreamSlice class using the specified database and plane.

- **`db`**: The specified database.
- **`plane`**: The specified plane.

### GetProfile
Gets the profile.

### SetPlane(Autodesk.AutoCAD.Geometry.Plane)
Sets the plane.

- **`plane`**: The specified plane.

### SetReconstructArcs(System.Boolean)
Sets if arcs need to be reconstructed.

- **`yesNo`**: Indicates if arcs need to be reconstructed.

### SetCopyAttributes(System.Boolean)
Sets if attributes need to be copied.

- **`yesNo`**: Indicates if attributes need to be copied.
