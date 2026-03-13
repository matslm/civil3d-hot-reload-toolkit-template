---
title: Autodesk.Aec.DatabaseServices.NestedGridDivision
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > NestedGridDivision
---

# Autodesk.Aec.DatabaseServices.NestedGridDivision

## Summary
Represents a nested grid division.

## Properties

### DivisionDirection
Gets or sets the grid division direction.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Id
Gets or sets the id of the nested grid division.

**Returns:** Returns the id of the nested grid division.

### Name
Gets or sets the name of the nested grid.

**Returns:** A string with the name of the nested grid.

### StartOffset
Gets or sets the start offset distance.

**Returns:** The start offset distance.

### EndOffset
Gets or sets the end offset distance.

**Returns:** The end offset distance.

## Methods

### #ctor
Initializes a new instance of the NestedGridDivision class.

### GetEdgePositions(System.Double,System.Double,Autodesk.AutoCAD.Geometry.DoubleCollection@,System.Double,Autodesk.Aec.DatabaseServices.GridAssembly)
Gets the edge positions.

- **`startPosition`**: Start position.
- **`endPosition`**: End position.
- **`edgePositions`**: Returned collection of edge positions.
- **`baseCurveRadius`**: Base curve radius.
- **`gridAssembly`**: The grid assembly.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Should be handled by derived classes.
