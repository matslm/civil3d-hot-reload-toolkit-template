---
title: Autodesk.Aec.DatabaseServices.EntityCollectorFilter
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > EntityCollectorFilter
---

# Autodesk.Aec.DatabaseServices.EntityCollectorFilter

## Summary
Represents a entity collector filter.

## Properties

### CheckRecurseBlock
Gets or sets the boolean value if recursively checks block.

**Returns:** The boolean value if recursively checks block.

## Methods

### Create(System.IntPtr,System.Boolean)
Creates a new instance of the EntityCollectorFilter class.

- **`unmanagedPointer`**: The native class pointer.
- **`autoDelete`**: The boolean value if deletes the native pointer.

### #ctor
Initializes a new instance of the EntityCollectorFilter class.

### AllowEntity(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.Aec.DatabaseServices.EntityCollectorData&)
Checks if the specified entity is allowed.

- **`entity`**: The specified entity.
- **`dataToAdd`**: The data to be added.

**Returns:** The boolean value if the specified entity is allowed.

### AllowEntity(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.Aec.DatabaseServices.EntityCollectorData&)
Checks if the specified entity is allowed.

- **`entity`**: The specified entity.
- **`idArrayBlockReferencePath`**: The block reference path.
- **`dataToAdd`**: The data to be added.

**Returns:** The boolean value if the specified entity is allowed.

### RecurseBlock(Autodesk.AutoCAD.DatabaseServices.BlockReference,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
TellS if the block reference should be recursively checked.  Default implementation is to return the same value as if allowEntity is called.

- **`blockReference`**: The specified block reference.
- **`idArrayBlockReferencePath`**: The block ref path of the block reference.

**Returns:** The boolean value if the specified block reference should be recursively checked.
