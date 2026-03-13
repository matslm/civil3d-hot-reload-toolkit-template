---
title: Autodesk.Aec.DatabaseServices.EntityReference
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > EntityReference
---

# Autodesk.Aec.DatabaseServices.EntityReference

## Summary
Represents a entity reference.

## Properties

### UseOffset
Gets or sets if use the specified insertion point offset.

**Returns:** Return true, if use the specified insertion point offset. Otherwise, return false.

### InsertionPointOffset
Gets or sets the insertion point offset.

**Returns:** The insertion point offset.

### InsertionPointOfReferredEntity
Gets or sets the insert point of the referred entity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ReferredEntityEcs
Get the Ecs of the referred entity.

**Returns:** The Ecs of the referred entity.

### ReferredEntityEcsInverse
Get the inverse of the referred entity Ecs.

**Returns:** The inverse of the referred entity Ecs.

## Methods

### #ctor
Initializes a new instance of the EntityReference class.

### #ctor(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Initializes a new instance of the EntityReference class using the specified referred entity.

- **`refEnt`**: The object id of the referenced entity.
