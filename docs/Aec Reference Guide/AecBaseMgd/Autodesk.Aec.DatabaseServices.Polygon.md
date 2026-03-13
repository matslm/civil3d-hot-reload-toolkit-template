---
title: Autodesk.Aec.DatabaseServices.Polygon
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > Polygon
---

# Autodesk.Aec.DatabaseServices.Polygon

## Summary
Represents a polygon.

## Properties

### GrossArea
Gets the gross area.

**Returns:** Returns the gross area.

**Remarks:**
The gross area is calculated using the outer edge profile.

### InfillArea
Gets the infill area.

**Returns:** Returns the infill area.

**Remarks:**
The infill area is calculated using the inner edge profile.

### EdgePerimeter
Gets the edge perimeter.

**Returns:** Returns the edge perimeter.

**Remarks:**
The edge perimeter is calculated by adding the perimeters of each ring in the outer edge profile.

### InfillPerimeter
Gets the infill perimeter.

**Returns:** Returns the infill perimeter.

**Remarks:**
The infill perimeter is calculated by adding the perimeters of each ring in the inner edge profile.

### HasHiddenEdges
Gets whether this polygon has any hidden edges.

**Returns:** True if the polygon has hidden edges, or false otherwise.

## Methods

### #ctor
Initializes a new instance of the Polygon class.

### SetEcsVertices(Autodesk.AutoCAD.Geometry.Point2dCollection)
Sets the vertices in ECS. The first and last vertices must be the same, forming a closed polygon.

- **`points`**: The vertices in ECS.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
The first and last vertices must be the same, forming a closed polygon.

### SetVertices(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.AutoCAD.Geometry.Plane)
Sets the vertices. The first and last vertices must be the same, forming a closed polygon.

- **`points`**: The vertices.
- **`plane`**: A plane containing the vertices.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
The first and last vertices must be the same, forming a closed polygon.

### AddEcsVertex(Autodesk.AutoCAD.Geometry.Point2d)
Adds a vertex in ECS.

- **`point2d`**: The vertex.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveEcsVertex(Autodesk.AutoCAD.Geometry.Point2d)
Removes a vertex in ECS.

- **`point2d`**: The vertex.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddVertex(Autodesk.AutoCAD.Geometry.Point3d)
Adds a vertex in WCS.

- **`point3d`**: The vertex.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveVertex(Autodesk.AutoCAD.Geometry.Point3d)
Removes a vertex in WCS.

- **`point3d`**: The vertex.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
