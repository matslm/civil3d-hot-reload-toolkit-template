---
title: Autodesk.Aec.DatabaseServices.LayoutTool
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > LayoutTool
---

# Autodesk.Aec.DatabaseServices.LayoutTool

## Summary
Represents a layout tool.

## Properties

### LayoutNodeIds
Gets a collection of node ids associated with this LayoutTool.

**Returns:** Returns a collection of node ids associated with this LayoutTool.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Should be handled by the derived classes only.

## Methods

### #ctor
Initializes a new instance of the LayoutTool class.

### GetClosestLayoutNode(Autodesk.AutoCAD.Geometry.Point3d)
Gets the closest layout node to the location given.

- **`location`**: The location.

**Returns:** Returns the closest layout node.

### GetLayoutNodeLocation(System.Int32)
Gets layout node location for the node with given id.

- **`nodeId`**: The node id.

**Returns:** Returns the layout node location.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Should be handled by the derived classes only.

### GetLayoutNodeCoordinateSystem(System.Int32)
Gets the layout node coordinate system for the given node id.

- **`nodeId`**: The node id.

**Returns:** Returns the layout node coordinate system.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Should be handled by the derived classes only.
