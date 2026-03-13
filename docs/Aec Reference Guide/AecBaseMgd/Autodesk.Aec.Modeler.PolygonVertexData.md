---
title: Autodesk.Aec.Modeler.PolygonVertexData
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > PolygonVertexData
---

# Autodesk.Aec.Modeler.PolygonVertexData

## Summary
Represents a class of polygon vertex data.

## Properties

### IsArc
Gets to know whether it's an arc or not.

**Returns:** True if it's an arc.

### Type
Gets or sets the type of polygon vertex data.

**Returns:** Returns the type of polygon vertex data.

### Circle
Gets or sets the circle of the polygon vertex data.

**Returns:** Returns the circle of the polygon vertex data.

### Approximation
Gets or sets the approximation of the polygon vertex data.

**Returns:** Returns the approximation of the polygon vertex data.

### IsCenterLeft
Gets or sets to know whether it is center left or not.

**Returns:** True if it is center left.

### Bulge
Gets or sets the bulge.

**Returns:** Returns the bulge.

### Surface
Gets or sets the surface.

**Returns:** Returns the surface.

### Curve
Gets or sets the curve.

**Returns:** Returns the curve.

## Methods

### #ctor(Autodesk.Aec.Modeler.PolygonVertexDataType)
Initializes a new instance of the PolygonVertexData class using the specified type.

- **`type`**: Input the type of PolygonVertexData.

### #ctor(Autodesk.Aec.Modeler.PolygonVertexDataType,Autodesk.AutoCAD.Geometry.CircularArc3d,System.Int32)
Initializes a new instance of the PolygonVertexData class using the specified  type, circle and approximation.

- **`type`**: Input the polygon vertex data type.
- **`circle`**: Input the circle.
- **`approximation`**: Input the approximation of the approximation of the whole 2*pi angle.

### #ctor(Autodesk.Aec.Modeler.PolygonVertexDataType,System.Double,System.Boolean,System.Int32)
Initializes a new instance of the PolygonVertexData class using the specified ?.

- **`type`**: Input the polygon vertex data type.
- **`radius`**: Input the radius.
- **`isCenterLeft`**: True if sets it to be center left.
- **`approximation`**: Input the approximation of the approximation of the whole 2*pi angle.

### #ctor(Autodesk.Aec.Modeler.PolygonVertexDataType,System.Double,System.Int32)
Initializes a new instance of the PolygonVertexData class using the specified ?.

- **`type`**: Input the polygon vertex data type.
- **`bulgeOrRadius`**: Input the value of bulge or radius.
- **`approximation`**: Input the approximation of the approximation of the whole 2*pi angle.

### Clone
Clones the wrapped object.

### DeleteUnmanagedObject
Deletes the unmanaged object.

**Returns:** void.
