---
title: Autodesk.Aec.DatabaseServices.AnchorToCurveY
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > AnchorToCurveY
---

# Autodesk.Aec.DatabaseServices.AnchorToCurveY

## Summary
Represents an anchor to a curve in the y direction.

## Properties

### OffsetDistance
Gets or sets the Y offset distance.

**Returns:** Returns the Y offset distance.

### OffsetType
Gets or sets the Y offset type.

**Returns:** Returns the Y offset type.

**Remarks:**
The edge of curve (with width) that anchor measures from.

### MeasureToType
Gets or sets the measure to type.

**Returns:** Returns the measure to type.

**Remarks:**
The part along the curve width the anchor is measuring from.

## Methods

### #ctor
Initializes a new instance of the AnchorToCurveY class.

### CalculateYOffset(System.Double,System.Double,System.Double)
Calculates the Y offset on the base curve.

- **`curveThickness`**: The width of the curve.
- **`entityThickness`**: The width of the object.
- **`insertionOffset`**: The offset from the object's insertion point to its anchor point.

**Returns:** The distance off the base curve.
