---
title: Autodesk.Aec.DatabaseServices.StreamVector
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > StreamVector
---

# Autodesk.Aec.DatabaseServices.StreamVector

## Summary
This stream collects all vectors pushed into the stream.  The stream appends the vectors to the array, and to an BlockTableRecord if it is supplied.

## Remarks
It is important to remember that StreamAcad will decompose all geometry pushed into the stream into its simplest form, a line in world coordinates. By default the stream filters out non-visible geometry.  It is the responsibility of the calling routine to create a block table record, if desired, and to close the record once the streaming process is finished.

## Properties

### ApplySurfaceHatching
Gets or sets the ApplySurfaceHatching setting.

**Returns:** The current ApplySurfaceHating setting.

### BackfaceCullSurfaceHatching
Gets or sets whether the BackfaceCullSurfaceHatching is enabled.

**Returns:** Boolean value indicates if BackfaceCullSurfaceHatching is enabled.

### Lines
Gets the collected lines.

## Methods

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database)
Initializes a new instance of the StreamVector class using the specified dababase.

- **`db`**: The specified database.

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.DatabaseServices.BlockTableRecord)
Initializes a new instance of the StreamVector class using the specified database and block record.

- **`db`**: The specified database.
- **`blockRecord`**: The specified block record.
