---
title: Autodesk.Aec.DatabaseServices.StreamExplode
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > StreamExplode
---

# Autodesk.Aec.DatabaseServices.StreamExplode

## Summary
Represents a stream that is used in the Explode() method of Autodesk.Aec.DatabaseServices.Entity.  All geometry and objects passing through the stream are converted to AutoCAD primitive entities (line, arc, circle, blockref, etc...) at the highest level possible. If an entity is sent through the stream, it will be cloned and added to model space.  Package exploded entities will add all new entities to an anonymous block reference and append it to the current space.

## Properties

### IsVisualExplode
Gets or sets if it is visual explode.

**Returns:** The value indicates if it is visual explode.

### UseFaceAndEdgeParamsWhileDrawingMesh
Gets or sets if face and edge parameters are used while drawing the mesh.

## Methods

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.DatabaseServices.DBObjectCollection)
Initializes a new instance of the StreamExplode class using the specified database and entity set.

- **`db`**: The specified database.
- **`entitySet`**: The specified entity set.

### PackageExplodedEntities
Packages exploded entities. This function is used for standard AutoCAD explode.

### PackageExplodedEntitiesAndReturnBlockId
Packages exploded entities to an anoynymous block and return the object id of the newly created anonymous block. This function is used for standard AutoCAD explode.

**Returns:** The object id of the newly created anonymous block. Returns a null object id if there's no block created.

- **Exception `T:System.NullReferenceException`**: System.NullReferenceException.

### AddExplodedEntitiesToCurrentSpace
Adds exploded entities to the current space. This function is used for AEC explode command.

### ResetEntityArrays
Resets the entity arrays. This function allows the pipe to be reused for the next explode.

### SetLocalTransform(Autodesk.AutoCAD.Geometry.Matrix3d)
Sets the local transform matrix.

- **`matrix`**: The specified matrix.

### SetForBoundarySearch(System.Boolean)
Sets the stream for boundary search.

- **`value`**: The value indicates if it is for boundary search.
