---
title: Autodesk.Aec.DatabaseServices.GridAssemblyEditableGridData
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GridAssemblyEditableGridData
---

# Autodesk.Aec.DatabaseServices.GridAssemblyEditableGridData

## Summary
Represents a grid assembly editable grid data.

## Properties

### GridAssembly
Sets the grid assembly.

**Remarks:**
This method transfers ownership of the object wrapped by the GridAssembly to the GridAssemblyEditableGridData.

### GridDivisionId
Gets or sets the grid division id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AssignmentId
Gets or sets the assignment id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CellExtents
Gets or sets the cell extents.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CellId
Gets the cell id.

**Returns:** The cell id.

### XAxis
Gets the X axis.

**Returns:** The X axis.

### YAxis
Gets the Y axis.

**Returns:** The Y axis.

### XAxisLength
Gets the X axis length.

**Returns:** The X axis length.

### YAxisLength
Gets the Y axis length.

**Returns:** The Y axis length.

### HeightDirection
Gets the height direction.

**Returns:** The height direction.

### HalfHeightDirection
Gets the half height direction.

**Returns:** The half height direction.

### Height
Gets the height.

**Returns:** The height.

### HalfHeight
Gets the half height.

**Returns:** The half height.

### StartPoint
Gets the start point.

**Returns:** The start point.

### EndPoint
Gets the end point.

**Returns:** The end point.

### MidPoint
Gets the midpoint.

**Returns:** The midpoint.

### CenterPoint
Gets the center point.

**Returns:** The center point.

### GridAngle
Gets the grid angle.

**Returns:** The grid angle.

### GridRadius
Gets the grid radius.

**Returns:** The grid radius.

### IsReverse
Gets the reversed state.

**Returns:** true if reversed, false otherwise.

**Remarks:**
On arc grids false means clockwise, true is counter-clockwise.

### StartOffset
Gets or sets the start offset.

### EndOffset
Gets or sets the end offset.

### EdgePositions
Gets the collection of edge positions.

**Returns:** The collection of edge positions.

### NewEdgePositions
Gets the collection of new edge positions.

**Returns:** The collection of new edge positions.

**Remarks:**
A collection of new edge positions may be set by a call to CalculateNewEdgePositions(), SetEdgePositionAt(), or Recalculate().

### GridDivisionDirection
Gets the grid division direction.

**Returns:** The grid division direction.

### DivideByCount
Gets or sets the number of divisions of the grid.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if grid doesn't have fixed number of bays, or if numberDivisions less than or equal to zero.

### BaySize
Gets or sets the bay size.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if grid doesn't have fixed bay sizes, or if size less than or equal to zero.

### DistributionFlags
Gets or sets the distribution flags.

**Returns:** The distribution flags.

**Remarks:**
For grids with fixed bay size.

### EdgeCount
Gets the edge count.

**Returns:** The edge count.

### NewEdgeCount
Gets the new edge count.

**Returns:** The new edge count.

## Methods

### Create(System.IntPtr,System.Boolean)
Creates a wrapper class for GridAssemblyEditableGridData.

### #ctor
Initializes a new instance of the GridAssemblyEditableGridData class.

### Recalculate
Calculates all the data -- from the entity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CalculateNewEdgePositions
Calculates the edge position distances from the grid start point when the grid is being edited.

### EdgePositionAt(System.Int16)
Gets the edge position at the given index.

- **`index`**: The index.

**Returns:** The edge position at the given index.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if no positions were set.

### NewEdgePositionAt(System.Int16)
Gets the new edge position at the given index.

- **`index`**: The index.

**Returns:** The new edge position at the given index.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if no new positions were set.

### EdgePositionFromReferenceAtEdgeIndex(System.Int16)
Gets the edge position from reference at edge with given index.

- **`index`**: The index.

**Returns:** The edge position from reference at edge with given index.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetManualEdgeIndexAt(System.Int32)
Gets the manual edge index at the given index.

- **`index`**: The given index.

**Returns:** The manual edge index at the given index. Returns -1 if given index is invalid.

**Remarks:**
For manual grids.

### SetEdgePositionAt(System.Int16,System.Double)
Sets the position of the edge at the given index.

- **`index`**: The index.
- **`positionFromStart`**: The new position to be used.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Also sets the same position for the new positions collection. Throws exception if index is invalid.

### SetEdgePositionFromReferenceAtEdgeIndex(System.Int16,System.Double)
Sets the edge position from reference at edge with given index.

- **`index`**: The index.
- **`positionFromReference`**: The new position to be used.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
For manual grids. Also sets the same position for the new positions collection.

### Clone
Clones the wrapped object.

### Dispose(System.Boolean)
Deletes the unmanaged object.

- **`disposing`**: unused.

**Returns:** void.
