---
title: Autodesk.Aec.DatabaseServices.AnchorToCurveZ
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > AnchorToCurveZ
---

# Autodesk.Aec.DatabaseServices.AnchorToCurveZ

## Summary
Represents an anchor to a curve in the z direction.

## Properties

### OffsetDistance
Gets or sets the Z offset distance.

**Returns:** Returns the Z offset distance.

### OffsetToType
Gets or sets the Z offset to type.

**Returns:** Returns the Z offset to type.

### OffsetFromType
Gets or sets the Z offset from type.

**Returns:** Returns the Z offset from type.

## Methods

### #ctor
Initializes a new instance of the AnchorToCurveZ class.

### CalculateZOffset(System.Double,System.Double,System.Double)
Calculates the offset from the base curve in the Z direction.

- **`curveHeight`**: The height or thickness of curve.
- **`entityHeight`**: The height of anchored object.
- **`insertionOffset`**: The offset from the anchored object's insertion point to the anchor point.

**Returns:** Returns the offset from the base curve in the Z direction.
