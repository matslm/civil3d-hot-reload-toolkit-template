---
title: Autodesk.Aec.DatabaseServices.LayoutCurve
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > LayoutCurve
---

# Autodesk.Aec.DatabaseServices.LayoutCurve

## Summary
Represents a layout curve.

## Properties

### CurveId
Gets or sets the curve id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### LayoutMode
Gets or sets the layout mode type.

**Returns:** Returns the layout mode type.

### NodeCount
Gets the node count of the layout curve.

**Returns:** Returns the node count of the layout curve.

### NodePositions
Gets the positions of the nodes on the Layout Curve.

**Returns:** Returns a collection containing the position of the nodes.

### StartOffset
Gets or sets the start offset.

**Returns:** Returns the start offset.

### EndOffset
Gets or sets the end offset.

**Returns:** Returns the end offset.

### Spacing
Gets or sets the spacing between the nodes.

**Returns:** Returns the spacing between the nodes.

## Methods

### #ctor
Initializes a new instance of the LayoutCurve class.

### GetNodePositionAt(System.Int32)
Gets the node position of the given index.

- **`index`**: The index.

**Returns:** Returns the node position of the given index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetLayoutCurveNodeAt(System.Int32)
Gets the LayoutCurveNode at a given index.

- **`index`**: The index.

**Returns:** Returns the LayoutCurveNode at a given index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetLayoutCurveNode(System.Int32)
Gets the LayoutCurveNode that has the given id.

- **`id`**: The id of the node to search for.

**Returns:** Returns the LayoutCurveNode that has the given id, or null if there was no node with the given id on the layout curve.

### SetLayoutNodeLocation(Autodesk.Aec.DatabaseServices.LayoutCurveNode,Autodesk.AutoCAD.Geometry.Point3d)
Sets the location of the LayoutCurveNode on the LayoutCurve.

- **`node`**: The node.
- **`location`**: the location for the node.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveLayoutNodeAt(System.Int32)
Removes the layout node at the given index.

- **`index`**: The index of the node to be removed.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Has no effect on LayoutCurves of mode SpaceOut since the nodes are recreated upon an UpdateParameters.

### RemoveLayoutNode(System.Int32)
Removes the layout node with the given id.

- **`id`**: The id of the node to be removed.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Has no effect on LayoutCurves of mode SpaceOut since the nodes are recreated upon an UpdateParameters.

### AppendLayoutNode(System.Double)
Appends a new layout node on the layout curve at the given position.

- **`position`**: The position of the node.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MoveLayoutNode(System.Double,System.Double)
Moves the layout node from one position to another.

- **`oldParameter`**: The original position of the node.
- **`newParameter`**: The new position of the node.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if there is no position that matches the one given on oldParameter.

### UpdateParameters
Updates the nodes on the layout curve depending on the layout mode type.

**Remarks:**
If layout mode type is Manual, it ensures that all nodes still fit on the curve (removes any that doesn't); if the layout mode type is SpacedOut it ensures that the spacing between the nodes is equidistant; if the layout mode type is Repeat it ensures that there are enough nodes within the layout curve at the spacing specified (can add or removes nodes).
