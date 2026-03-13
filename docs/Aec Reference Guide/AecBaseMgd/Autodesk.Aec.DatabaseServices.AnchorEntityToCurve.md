---
title: Autodesk.Aec.DatabaseServices.AnchorEntityToCurve
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > AnchorEntityToCurve
---

# Autodesk.Aec.DatabaseServices.AnchorEntityToCurve

## Summary
Represents an entity to a curve anchor.

## Properties

### AnchorX
Gets the AnchorToCurveX member.

**Returns:** Returns the AnchorToCurveX member.

### AnchorY
Gets the AnchorToCurveY member.

**Returns:** Returns the AnchorToCurveY member.

### AnchorZ
Gets the AnchorToCurveZ member.

**Returns:** Returns the AnchorToCurveZ member.

### FlipX
Gets or sets the flip in X value.

**Returns:** Returns true if flipped in X.

### FlipY
Gets or sets the flip in Y value.

**Returns:** Returns true if flipped in Y.

### FlipZ
Gets or sets the flip in Z value.

**Returns:** Returns true if flipped in Z.

### CurveId
Gets or sets the curve Id.

**Returns:** Returns the curve Id.

### Rotation
Gets or sets the rotation.

**Returns:** Returns the rotation.

### RotationAroundX
Gets or sets the rotation around X.

**Returns:** Returns the rotation around X.

### CurveThickness
Gets the curve thickness of the referenced object.

**Returns:** Returns the curve thickness of the referenced object.

### CurveWidth
Gets the curve width of the referenced object.

**Returns:** Returns the curve width of the referenced object.

### CurveNormal
Gets the curve normal of the referenced object.

**Returns:** Returns the curve normal of the referenced object.

## Methods

### #ctor
Initializes a new instance of the AnchorEntityToCurve class.

### ReverseParameters
Reverses the X parameters, and flips X and Y.

### SwitchAnchoredEnd(Autodesk.Aec.DatabaseServices.Geo)
Changes the end that the anchored object is referencing.

- **`geo`**: The anchored object.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetEntityExtents(Autodesk.Aec.DatabaseServices.Geo)
Calculates the extents of the anchored object.

- **`geo`**: The anchored object.

**Returns:** The extents.

### CalculateCurveThickness(Autodesk.AutoCAD.DatabaseServices.Curve)
Gets the thickness of the specified curve.

- **`curve`**: The curve.

**Returns:** Returns the thickness of the specified curve.

### CalculateCurveWidth(Autodesk.AutoCAD.DatabaseServices.Curve)
Gets the width of the specified curve.

- **`curve`**: The curve.

**Returns:** Returns the width of the specified curve.

### CalculateCurveNormal(Autodesk.AutoCAD.DatabaseServices.Curve)
Gets the normal of the specified curve.

- **`curve`**: The curve.

**Returns:** Returns the normal of the specified curve.
