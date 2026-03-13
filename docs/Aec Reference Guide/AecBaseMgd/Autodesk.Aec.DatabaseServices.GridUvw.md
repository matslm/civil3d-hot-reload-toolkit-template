---
title: Autodesk.Aec.DatabaseServices.GridUvw
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GridUvw
---

# Autodesk.Aec.DatabaseServices.GridUvw

## Summary
Represents a grid uvw, a tridimensional grid with nodes, cells, and volumes.

## Properties

### VolumeCount
Gets the number of volumes.

**Returns:** Returns the number of volumes.

### LayoutVolumeIds
Gets a collection of volume Ids.

**Returns:** Returns a collection of volume Ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### WAxisLength
Gets or sets the length of W Axis.

**Returns:** Returns the length of W Axis.

### WSpacing
Gets or sets the spacing along W Axis.

**Returns:** Returns the spacing along W Axis.

### WStartOffset
Gets or sets the offset from the W Axis to the start of the grid .

**Returns:** The offset distance.

### WEndOffset
Gets or sets the offset from end of W Axis to end grid.

**Returns:** The offset distance.

### WLayoutMode
Gets or sets the layout mode of the W axis.

**Returns:** The layout mode.

### WParameters
Get parameters of grid lines along W Axis.

**Returns:** Collection of W parameters.

## Methods

### #ctor
Initializes a new instance of the GridUvw class.

### GetLayoutVolumeCentroid(System.Int32)
Gets the centroid of the volume layout.

- **`volumeId`**: The volume id.

**Returns:** The centroid of the layout volume.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Should be handled by the derived classes only.

### GetLayoutVolumeBody(System.Int32,Autodesk.AutoCAD.Geometry.Matrix3d@)
Gets the layout volume body and the coordinate system of the layout volume with the given id.

- **`volumeId`**: The volume id.
- **`toWcs`**: The coordinate system of the layout volume (if found.)

**Returns:** Returns the layout volume body.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Should be handled by the derived classes only.

### GetLayoutVolumeExtent(System.Int32,System.Double@,System.Double@,System.Double@,Autodesk.AutoCAD.Geometry.Matrix3d@)
Gets the layout volume extents (length, width, height, and coordinate system).

- **`volumeId`**: The volume layout id.
- **`length`**: The volume layout length to be returned.
- **`width`**: The volume layout width to be returned.
- **`height`**: The volume layout height to be returned.
- **`toWcs`**: The volume layout coordinate system to be returned.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Should be handled by the derived classes only.

### GetLayoutGrid3dNodeAt(System.Int32)
Gets node at the index given.

- **`index`**: The index.

**Returns:** Returns the LayoutGrid3dNode at the index given.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetLayoutGrid3dNode(System.Int32)
Gets node that has the given id.

- **`id`**: The node id.

**Returns:** Returns the node that has the given id, or null if not found.

### GetLayoutGrid3dCellAt(System.Int32)
Gets the cell at the given index.

- **`index`**: The index.

**Returns:** Returns the cell at the given index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetLayoutGrid3dCell(System.Int32)
Gets the cell that has the given id.

- **`id`**: The cell id.

**Returns:** Returns the cell that has the given id, or null if not found.

### GetLayoutGrid3dVolumeAt(System.Int32)
Gets the volume at the given index.

- **`index`**: The index.

**Returns:** Returns the volume at the given index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetLayoutGrid3dVolume(System.Int32)
Gets the volume that has the given id.

- **`id`**: The volume id.

**Returns:** Returns the volume that has the given id, or null if not found.

### AppendGridLevel(System.Double)
Adds a node at every intersection of V param and U param at the W level.

- **`parameterW`**: The node.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MoveGridLevel(System.Double,System.Double)
Moves all nodes at old W position to new W position.

- **`oldParameter`**: Old W position.
- **`newParameter`**: New W position.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveGridLevel(System.Double)
Remove all nodes that exist with W parameter.

- **`parameterW`**: The W parameter.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddNode(System.Double,System.Double,System.Double)
Adds a single node at U, V, W position.

- **`parameterU`**: U position.
- **`parameterV`**: V position.
- **`parameterW`**: W position.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
