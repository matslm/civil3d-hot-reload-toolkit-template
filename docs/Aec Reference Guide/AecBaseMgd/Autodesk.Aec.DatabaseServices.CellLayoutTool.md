---
title: Autodesk.Aec.DatabaseServices.CellLayoutTool
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > CellLayoutTool
---

# Autodesk.Aec.DatabaseServices.CellLayoutTool

## Summary
Represents a cell layout tool. CellLayoutTool builds onto LayoutTool by restricting node layouts to a predefined cell structure.

## Properties

### LayoutCellIds
Gets the layout cell ids.

**Returns:** Returns a collection of layout cell ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

## Methods

### #ctor
Initializes a new instance of the CellLayoutTool class.

### GetClosestLayoutCell(Autodesk.AutoCAD.Geometry.Point3d)
Gets the closest layout cell id to the point given.

- **`location`**: The point location.

**Returns:** Returns the closest layout cell id to the point given.

### GetLayoutCellProfile(System.Int32,Autodesk.AutoCAD.Geometry.Matrix3d@)
Gets the layout cell profile.

- **`cellId`**: The cell id.
- **`toWcs`**: The coordinate system of the layout volume (if found).

**Returns:** The layout cell profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Handled on the derived classes.

### GetLayoutCellCentroid(System.Int32)
Gets the centroid of the cell layout.

- **`cellId`**: The cell id to get the centroid for.

**Returns:** Returns the centroid of the cell layout.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
