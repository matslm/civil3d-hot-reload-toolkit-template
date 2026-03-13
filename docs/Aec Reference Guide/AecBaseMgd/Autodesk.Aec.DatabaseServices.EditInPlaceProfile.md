---
title: Autodesk.Aec.DatabaseServices.EditInPlaceProfile
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > EditInPlaceProfile
---

# Autodesk.Aec.DatabaseServices.EditInPlaceProfile

## Summary
Represents an edit in place profile.

## Properties

### EcsInsertionPoint
Gets or sets the ecs insertion point.

**Returns:** The ecs insertion point.

### InsertionPoint
Gets or sets the insertion point.

**Returns:** The insertion point.

### BaseProfile
Gets or sets the base profile.

**Returns:** The base profile.

### InvalidProfile
Gets or sets the invalid profile.

**Returns:** The invalid profile.

### EditingConstraint
Gets or sets the editing constraint.

**Returns:** The current editing constraint.

### EditingContext
Gets or sets the editing context.

**Returns:** The current editing context.

### UsesInsertionPoint
Gets or sets whether the insertion point should be used.

**Returns:** Boolean value indicates whether the insertion point should be used.

### DrawDefaultGraphics
Gets or sets whether the default graphics should be drawn.

**Returns:** Boolean value indicates whether the default graphics should be drawn.

### UseDefaultGrips
Gets or sets whether the default grips should be used.

**Returns:** Boolean value indicates whether the default grips should be used.

### UseDefaultMenus
Gets or sets whether the default menus should be used.

**Returns:** Boolean value indicates whether the default menus should be used.

### UseMoveGrip
Gets or sets whether the move grip should be used.

**Returns:** Boolean value indicates whether the move grip should be used.

## Methods

### #ctor
Initializes a new instance of the EditInPlaceProfile class.

### SetEcsVertices(Autodesk.AutoCAD.Geometry.Point2dCollection)
Sets the ecs vertices.

- **`points`**: The specified vertices.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetVertices(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.AutoCAD.Geometry.Plane)
Sets the vertices.

- **`points`**: The specified vertices.
- **`plane`**: The specified plane.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddEcsVertex(Autodesk.AutoCAD.Geometry.Point2d)
Adds ecs vertex.

- **`ecsVertex`**: The specified ecs vertex.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveEcsVertex(Autodesk.AutoCAD.Geometry.Point2d)
Removes ecs vertex.

- **`ecsVertex`**: The specified ecs vertex.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddVertex(Autodesk.AutoCAD.Geometry.Point3d)
Adds vertex.

- **`ecsVertex`**: The specified vertex.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveVertex(Autodesk.AutoCAD.Geometry.Point3d)
Removes vertex.

- **`vertex`**: The specified vertex.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
