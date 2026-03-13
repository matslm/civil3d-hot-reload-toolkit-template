---
title: Autodesk.Aec.DatabaseServices.GridCustom
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GridCustom
---

# Autodesk.Aec.DatabaseServices.GridCustom

## Summary
Represents a grid custom.

## Properties

### LayoutNodeIds
Gets a collection of layout node ids associated with this grid custom.

**Returns:** Returns a collection of layout node ids associated with this grid custom.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### LayoutCellIds
Gets a collection of layout cell ids associated with this grid custom.

**Returns:** Returns a collection of layout cell ids associated with this grid custom.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
A layout cell exists in each closed region of the grid.

### Segments
Gets the custom grid segments.

**Returns:** The custom grid segments.

### NodeCount
Gets the node count.

**Returns:** The node count.

### CellCount
Gets the cell count.

**Returns:** The cell count.

### RequiresUpdate
Gets or sets the update status.

**Returns:** true if the grid requires updating, false otherwise.

### PersistentSolution
Gets or sets the status of the solution.

**Returns:** true if persistent, false otherwise.

### TransientExteriorCell
Gets the transient exterior cell.

**Returns:** The transient exterior cell, or null if none is available.

**Remarks:**
The transient exterior cell is set after an UpdateParameter() call (for non-persistent solutions).

## Methods

### #ctor
Initializes a new instance of the GridCustom class.

### GetLayoutNodeLocation(System.Int32)
Gets the layout node location for the node with given id.

- **`nodeId`**: The node id.

**Returns:** The layout node location for the node with given id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if given id was not found, or if there is no main segment with given id.

### GetLayoutNodeCoordinateSystem(System.Int32)
Gets the layout node coordinate system for the node with given id.

- **`nodeId`**: The node id.

**Returns:** The layout node coordinate system for the node with given id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if given id was not found, or if there is no main segment with given id.

### GetLayoutCellProfile(System.Int32,Autodesk.AutoCAD.Geometry.Matrix3d@)
Gets the layout cell profile and its coordinate system.

- **`cellId`**: The cell id.
- **`profileToWcs`**: The coordinate system of the layout cell profile.

**Returns:** The cell profile, or null if none was available.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if id was not found, or if there are no grid cells available.

### UpdateParameters
Updates all nodes and cells of this grid custom.

### DeleteTransientData
Deletes all transient data (segments, nodes, and cells)

### CustomGridNodeAt(System.Int32)
Gets the node at the given index.

- **`index`**: The index.

**Returns:** The node at the given index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### CustomGridNode(System.Int32)
Gets the node that has the given id.

- **`id`**: The id.

**Returns:** The node that has the given id, or null if none was found.

### CustomGridCellAt(System.Int32)
Gets the cell at the index given.

- **`index`**: The index.

**Returns:** The cell at the index given.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### CustomGridCell(System.Int32)
Gets the cell that has the given id.

- **`id`**: The id.

**Returns:** The cell that has the given id, or null if none was found.
