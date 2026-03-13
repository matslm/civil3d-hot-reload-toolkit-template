---
title: Autodesk.Aec.DatabaseServices.StreamCollectClipBodies
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > StreamCollectClipBodies
---

# Autodesk.Aec.DatabaseServices.StreamCollectClipBodies

## Summary
Represents a stream that clips the bodies pushed into the stream with the specifed clip body.

## Properties

### BackfaceCullSurfaceHatching
Gets or sets whether BackfaceCullSurfaceHatching should be turned on.

**Returns:** Boolean value indicates whether BackfaceCullSurfaceHatching should be turned on.

### ShrinkwrapProfile
Gets the profile of the shrinkwrap.

### CalculateShrinkwrap
Gets whether the shrinkwrap calculation is turned on.

**Returns:** True if the shrinkwrap calculation is turned on.

## Methods

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database)
Initializes a new instance of the StreamCollectClipBodies class using the specified database.

- **`db`**: The database.

### SetBodyClipVolume(Autodesk.Aec.Modeler.Body)
Sets the body filter. This function makes a copy of the body filter parameter and use the copy while streaming.  Changing the body parameter instance outside the function won't affect the streaming process.

- **`bodyFilter`**: The body filter.

### GetCollectedGraphics
Gets the collected graphics.

### SetCalculateShrinkwrap(System.Boolean,Autodesk.AutoCAD.Geometry.Matrix3d,System.Boolean)
Sets if shrinkwrap needs to be calculated during the streaming.

- **`value`**: True to turn on shrinkwrap.
- **`toShrinkwrapPlane`**: The matrix of shrinkwrap plane.

### SetCalculateShrinkwrap(System.Boolean,Autodesk.AutoCAD.Geometry.Matrix3d)
Sets if shrinkwrap needs to be calculated during the streaming. The shrinkwrap object is always initialized by calling this function.

- **`value`**: True to turn on shrinkwrap.
- **`toShrinkwrapPlane`**: The matrix of shrinkwrap plane.

### SetRetainBodies(System.Boolean)
Sets if the bodies pushed into the stream are retained instead of turned into shells.

- **`value`**: True to retain bodies.

### SetSkipAnnotationObjects(System.Boolean)
Sets whether to skip annotation objects during streaming.

- **`value`**: True to skip annotation objects.
