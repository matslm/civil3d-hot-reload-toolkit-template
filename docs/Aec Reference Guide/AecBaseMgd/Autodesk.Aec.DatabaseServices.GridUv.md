---
title: Autodesk.Aec.DatabaseServices.GridUv
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GridUv
---

# Autodesk.Aec.DatabaseServices.GridUv

## Summary
Represents a grid UV, a bidimensional grid with nodes and cells.

## Properties

### GridType
Gets the grid type.

**Returns:** Returns the grid type.

### NodeCount
Gets the node count of the grid.

**Returns:** Returns the node count of the grid.

### LayoutNodeIds
Gets a collection of node Ids - A node at each grid intersection exists.

**Returns:** Returns a collection of node Ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CellCount
Gets the number of cells.

**Returns:** Returns the number of cells.

### LayoutCellIds
Gets a collection of layout cell ids. A layout cell exists in each closed region of the grid.

**Returns:** Returns a collection of layout cell ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### UAxisLength
Gets or sets the length of U Axis.

**Returns:** Returns the length of U Axis.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### VAxisLength
Gets or sets the length of V Axis.

**Returns:** Returns the length of V Axis.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### USpacing
Gets or sets the spacing along U Axis if mode is Repeat.

**Returns:** Returns the spacing along U Axis.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### VSpacing
Gets or sets the spacing along V Axis if mode is Repeat.

**Returns:** Returns the spacing along V Axis.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### UStartOffset
Gets or sets the offset from the U Axis to the start of the grid .

**Returns:** The offset distance.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### VStartOffset
Gets or sets the offset from V Axis to the start of the grid .

**Returns:** The offset distance.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### UEndOffset
Gets or sets the offset from end of U Axis to end grid.

**Returns:** The offset distance.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### VEndOffset
Gets or sets the offset from end of V Axis to end grid.

**Returns:** The offset distance.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ULayoutMode
Gets or sets the layout mode of the U axis.

**Returns:** The layout mode.

### VLayoutMode
Gets or sets the layout mode of the V axis.

**Returns:** The layout mode.

### UParameters
Get parameters of grid lines along U Axis.

**Returns:** Collection of U parameters.

### VParameters
Get parameters of grid lines along V Axis.

**Returns:** Collection of V parameters.

## Methods

### #ctor
Initializes a new instance of the GridUv class.

### GetLayoutNodeLocation(System.Int32)
Gets layout node location for the node with given id.

- **`nodeId`**: The node id.

**Returns:** Returns the layout node location.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetLayoutNodeCoordinateSystem(System.Int32)
Gets the layout node coordinate system for the given node id.

- **`nodeId`**: The node id.

**Returns:** Returns the layout node coordinate system.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetLayoutCellProfile(System.Int32,Autodesk.AutoCAD.Geometry.Matrix3d@)
Gets profile at cell id.

- **`cellId`**: The cell id.
- **`toWcs`**: The coordinate system of the layout cell (if found).

**Returns:** The layout cell profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Should be handled by the derived classes only.

### GetLayoutGrid2dNodeAt(System.Int32)
Gets node at the index given.

- **`index`**: The index.

**Returns:** Returns the LayoutGrid2dNode at the index given.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetLayoutGrid2dNode(System.Int32)
Gets node that has the given id.

- **`id`**: The node id.

**Returns:** Returns the node that has the given id, or null if not found.

### GetLayoutGrid2dCellAt(System.Int32)
Gets the cell at the given index.

- **`index`**: The index.

**Returns:** Returns the cell at the given index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetLayoutGrid2dCell(System.Int32)
Gets the cell that has the given id.

- **`id`**: The cell id.

**Returns:** Returns the cell that has the given id, or null if not found.

### AppendGridColumn(System.Double)
Adds a node at every intersection of V param with passed in U param.

- **`parameterU`**: The node.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AppendGridRow(System.Double)
Adds a node at every intersection of U param with passed in V param.

- **`parameterV`**: The node.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MoveGridRow(System.Double,System.Double)
Moves all nodes at old V position to new V position.

- **`oldParameter`**: Old V position.
- **`newParameter`**: New V position.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MoveGridColumn(System.Double,System.Double)
Moves all nodes at old U position to new U position.

- **`oldParameter`**: Old U position.
- **`newParameter`**: New U position.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveGridColumn(System.Double)
Remove all nodes that exist with u parameter.

- **`parameterU`**: The u parameter.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveGridRow(System.Double)
Remove all nodes that exist with v parameter.

- **`parameterV`**: The v parameter.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddNode(System.Double,System.Double)
Adds a single node at U and V position.

- **`parameterU`**: U position.
- **`parameterV`**: V position.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### UpdateParameters
Updates grid lines based on mode of each axis.

**Remarks:**
Manual: Any manual nodes that do not fit on the grid are removed; SpaceEvenly: Node positions are spaced to fit new size of the grid; Repeat: Nodes are added or removed to fit inside current grid size.
