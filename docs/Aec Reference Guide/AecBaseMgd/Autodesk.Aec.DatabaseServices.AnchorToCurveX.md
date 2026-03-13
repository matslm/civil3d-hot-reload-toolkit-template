---
title: Autodesk.Aec.DatabaseServices.AnchorToCurveX
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > AnchorToCurveX
---

# Autodesk.Aec.DatabaseServices.AnchorToCurveX

## Summary
Represents an anchor to a curve in the x direction.

## Properties

### OffsetType
Gets or sets the X offset type.

**Returns:** Returns the X offset type.

**Remarks:**
The part along the curve the anchor is measuring from.

### MeasureToType
Gets or sets the measure to type.

**Returns:** Returns the measure to type.

**Remarks:**
The part of the anchored object the anchor is measuring to.

### OffsetDistance
Gets or sets the offset distance.

**Returns:** Returns the offset distance.

**Remarks:**
The offset distance is along the length of the curve.

## Methods

### #ctor
Initializes a new instance of the AnchorToCurveX class.

### CalculatePosition(Autodesk.AutoCAD.DatabaseServices.Curve,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Point3d@,Autodesk.AutoCAD.Geometry.Vector3d@,Autodesk.AutoCAD.Geometry.Vector3d@,Autodesk.AutoCAD.Geometry.Vector3d@)
Calculates point and orientation on the specified curve.

- **`curve`**: The base curve.
- **`entityLength`**: The length of the anchored object.
- **`insertionOffset`**: The distance from anchor point on the object to the object's insertion point.
- **`position`**: The returned location.
- **`directionX`**: The X direction at this point on the curve.
- **`directionY`**: The Y direction at this point on the curve.
- **`directionZ`**: The Z direction at this point on the curve.

### ReverseParameters
Negates the offset distance and switches the reference point of the curve.
