---
title: Autodesk.Aec.Modeler.Vertex
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > Vertex
---

# Autodesk.Aec.Modeler.Vertex

## Summary
Represents a vertex.

## Properties

### Point
Gets or sets the point.

**Returns:** The point.

### VertexSurfaceDataCollection
Gets the VertexSurfaceDataCollection.

**Returns:** The VertexSurfaceDataCollection.

## Methods

### #ctor
Initializes a new instance of the Vertex class.

### #ctor(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.Aec.Modeler.Body)
Initializes a new instance of the Vertex class using the specified point and body.

- **`point`**: The point of vertex.
- **`body`**: The body which the vertes is on it.

### Transform(Autodesk.AutoCAD.Geometry.Matrix3d)
Transfer from a matrix.

- **`matrix`**: The matrix.

### Modified
Sets it is modified.

### VertexSurfaceData(Autodesk.Aec.Modeler.Edge)
Gets the vertex surface data.

- **`edge`**: The edge.

**Returns:** The vertex surface data.
