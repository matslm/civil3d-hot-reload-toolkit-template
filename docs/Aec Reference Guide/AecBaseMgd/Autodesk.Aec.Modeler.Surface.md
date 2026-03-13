---
title: Autodesk.Aec.Modeler.Surface
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > Surface
---

# Autodesk.Aec.Modeler.Surface

## Summary
Represents a Surface.

## Properties

### Type
Gets the type.

**Returns:** The surface type.

### Copy
Gets the copy.

**Returns:** The copy of surface.

## Methods

### Create(System.IntPtr,System.Boolean)
Creates a wrapper class for Surface.

### Transform(Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Modeler.TransfType,Autodesk.AutoCAD.Geometry.Vector3d)
Transform from matrix.

- **`matrix`**: The matrix.
- **`transfType`**: The transfer type.
- **`stretchVector`**: The stretch vector.

**Returns:** Returns true if the surface was successfully  false if it could not be transformed (e.g. a sphere  cannot be stretched).

### Transform(Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Modeler.TransfType)
Transform from matrix.

- **`matrix`**: The matrix.
- **`transfType`**: The transfer type.

**Returns:** Returns true if the surface was successfully  false if it could not be transformed (e.g. a sphere  cannot be stretched).

### Transform(Autodesk.AutoCAD.Geometry.Matrix3d)
Transform from matrix.

- **`matrix`**: The matrix.

**Returns:** Returns true if the surface was successfully  false if it could not be transformed (e.g. a sphere  cannot be stretched).

### IsEqual(Autodesk.Aec.Modeler.Surface)
Check if another surface is equal to this.

- **`surface`**: The surface.

**Returns:** True if they are equal, false otherwise.

### ContainsPoint(Autodesk.AutoCAD.Geometry.Point3d)
Check if the surface contains some point.

- **`point`**: The point.

**Returns:** True if it contains some point.

### Circle(Autodesk.AutoCAD.Geometry.Plane,Autodesk.AutoCAD.Geometry.LineSegment3d)
Returns the equation of a circle which results from the intersection of the surface with the given plane.

- **`plane`**: The plane to intersect.
- **`line`**: The LineSegment3d is an approximation of the circle we are interested in.

**Returns:** The circle.

### Normal(Autodesk.AutoCAD.Geometry.Point3d)
Gets the outward-pointing unit normal vector to the surface at the given point.

- **`point`**: The given point.

**Returns:** The normal vector.
