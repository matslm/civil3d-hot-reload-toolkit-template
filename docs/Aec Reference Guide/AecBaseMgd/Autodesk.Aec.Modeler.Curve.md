---
title: Autodesk.Aec.Modeler.Curve
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > Curve
---

# Autodesk.Aec.Modeler.Curve

## Summary
Represents a curve.

## Properties

### Type
Gets the curve type.

**Returns:** The curve type.

### Copy
Gets the copy of the curve.

**Returns:** The copy of the curve.

## Methods

### Transform(Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Modeler.TransfType,Autodesk.AutoCAD.Geometry.Vector3d)
Transform from matrix.

- **`matrix`**: The matrix.
- **`transfType`**: The transftype.
- **`stretchVector`**: The stretch vector.

**Returns:** Returns true if the curve was successfully transformed or false if it could not be transformed (e.g. a circle  cannot be stretched in a direction not parallel to its axis).

### Transform(Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Modeler.TransfType)
Transform from matrix.

- **`matrix`**: The matrix.
- **`transfType`**: The transftype.

**Returns:** Returns true if the curve was successfully transformed or false if it could not be transformed (e.g. a circle  cannot be stretched in a direction not parallel to its axis).

### Transform(Autodesk.AutoCAD.Geometry.Matrix3d)
Transform from matrix.

- **`matrix`**: The matrix.

**Returns:** Returns true if the curve was successfully transformed or false if it could not be transformed (e.g. a circle  cannot be stretched in a direction not parallel to its axis).
