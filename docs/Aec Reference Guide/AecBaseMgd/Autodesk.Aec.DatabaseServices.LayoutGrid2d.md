---
title: Autodesk.Aec.DatabaseServices.LayoutGrid2d
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > LayoutGrid2d
---

# Autodesk.Aec.DatabaseServices.LayoutGrid2d

## Summary
Represents a layout grid 2d. LayoutGrid2d builds onto CellLayoutTool by restricting node layouts to a regular 2d grid structure.

## Properties

### BaseGrid
Gets the base grid.

**Returns:** The base grid, or null if the grid was not defined yet.

### CustomGrid
Gets the custom grid for this layout grid 2d.

### GridType
Gets or sets the grid type.

**Returns:** Returns the grid type.

### BoundaryId
Gets or sets the boundary id.

**Returns:** Returns the boundary id.

### BoundaryHoles
Gets a collection containing the ids of all the holes on the layout grid 2d.

**Returns:** Returns a collection containing the ids of all the holes on the layout grid 2d.

### BoundaryProfile
Gets the boundary profile of the layout grid 2d.

**Returns:** Returns the boundary profile of the layout grid 2d, or null if none was defined yet.

## Methods

### #ctor
Initializes a new instance of the LayoutGrid2d class.

### AppendBoundaryHole(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Appends a boundary hole on the layout grid 2d.

- **`id`**: The id of the boundary hole.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveBoundaryHole(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Removes the boundary hole with given id from the layout grid 2d.

- **`id`**: The id of the boundary hole to be removed.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### OppositeLayoutNode(System.Int32,System.Double,System.Int32@,System.Double@)
Gets the node opposite to the node given.

- **`nodeId`**: The id of the given node.
- **`angleOffset`**: The angle offset of the given node.
- **`oppositeNodeId`**: The id of the opposite node (if found.)
- **`oppositeAngleOffset`**: The angle offset of the opposite node (if found.)

**Returns:** true if it found the node opposite to the node given; false otherwise.
