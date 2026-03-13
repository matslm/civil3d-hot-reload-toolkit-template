---
title: Autodesk.Aec.DatabaseServices.AnchorEntityToEntity
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > AnchorEntityToEntity
---

# Autodesk.Aec.DatabaseServices.AnchorEntityToEntity

## Summary
Represents an entity to a entity anchor.

## Properties

### ReferencedEntityId
Gets or sets the Id of the referenced entity.

**Returns:** Returns the Id of the referenced entity.

## Methods

### #ctor
Initializes a new instance of the AnchorEntityToEntity class.

### SetReferencedEntity(Autodesk.Aec.DatabaseServices.Geo)
Sets the referenced entity.

- **`geo`**: The referenced entity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetReferencedEntityOldEcs(Autodesk.AutoCAD.Geometry.Matrix3d)
Sets the Ecs for the referenced entity.

- **`mat`**: The Ecs matrix.
