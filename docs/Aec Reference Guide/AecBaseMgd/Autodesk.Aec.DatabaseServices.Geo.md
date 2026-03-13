---
title: Autodesk.Aec.DatabaseServices.Geo
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > Geo
---

# Autodesk.Aec.DatabaseServices.Geo

## Summary
Represents a geo.

## Properties

### Location
Gets or sets the location.

**Returns:** Returns the location.

### Direction
Gets or sets the direction.

**Returns:** Returns the direction.

### Rotation
Gets or sets the rotation.

**Returns:** Returns the rotation.

### Normal
Gets or sets the normal.

**Returns:** Returns the normal.

### XDir
Gets the X direction.

**Returns:** Returns the X direction.

### YDir
Gets the Y direction.

**Returns:** Returns the Y direction.

### ZDir
Gets the Z direction.

**Returns:** Returns the Z direction.

### GeoEcs
Gets or sets the ECS of the Geo.

**Returns:** Returns the ECS of the Geo.

### GeoEcsIsDirty
Gets or sets the dirty value for the ECS of the Geo.

**Returns:** Returns the dirty value for the ECS of the Geo.

### CanBeAnchored
Gets the value that determines if the geo can be anchored.

**Returns:** Returns the value that determines if the geo can be anchored.

### AnchorId
Gets the AnchorId.

**Returns:** Returns the AnchorId.

### IsAnchored
Gets whther the geo derived object is anchored.

**Returns:** Returns the value that determines if the geo is anchored.

## Methods

### UpdateGeoEcs(System.Boolean)
Updates the ECS of the geo.

- **`forceUpdate`**: false to update only if the dirty flag is set.

### TranslateBy(Autodesk.AutoCAD.Geometry.Vector3d)
Translates the geo by the specified offset.

- **`offset`**: The offset.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MoveInXY(Autodesk.AutoCAD.Geometry.Vector3d)
Moves the geo in X and Y.

- **`offset`**: The offset.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MoveInZ(System.Double)
Moves the geo in Z.

- **`distance`**: The distance.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### OnGeoEcsModified(Autodesk.AutoCAD.Geometry.Matrix3d)
Called when the ECS of the geo is modified.

- **`previousEcs`**: The previous ECS.

### SetAnchor(Autodesk.Aec.DatabaseServices.Anchor)
Takes ownership of a new Anchor object and adds it to the database.

- **`newAnchor`**: The anchor.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### UpdateFromAnchor(Autodesk.Aec.DatabaseServices.Anchor)
Updates the geo position from the specified anchor.

- **`anchor`**: The anchor.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ReleaseAnchor
Releases the anchor.
