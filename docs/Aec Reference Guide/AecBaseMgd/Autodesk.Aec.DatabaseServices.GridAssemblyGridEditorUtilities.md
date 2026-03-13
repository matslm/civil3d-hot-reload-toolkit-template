---
title: Autodesk.Aec.DatabaseServices.GridAssemblyGridEditorUtilities
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GridAssemblyGridEditorUtilities
---

# Autodesk.Aec.DatabaseServices.GridAssemblyGridEditorUtilities

## Summary
Represents a grid assembly grid editor utilities.

## Methods

### Create
Creates a wrapper class for GridAssemblyGridEditorUtilities.

### #ctor
Initializes a new instance of the GridAssemblyGridEditorUtilities class.

### GetGridDivisionId(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the grid division id.

- **`id`**: The object id.

**Returns:** The grid division id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if not able to open the in place grid editor for the given id.

### GetCellExtents(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.Geometry.BoundBox2d@)
Gets the cell extents.

- **`id`**: The object id.
- **`cellExtents`**: The returned cell extents.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if not able to open the in place grid editor for the given id.

### GetEditableGrid(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.GridAssembly,Autodesk.Aec.DatabaseServices.GridAssemblyEditableGridData)
Gets the editable grid assembly.

- **`id`**: The object id.
- **`gridAssembly`**: The returned editable grid assembly.
- **`editableGridData`**: The returned editable grid data.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if not able to open the in place grid editor for the given id, or if the in place grid editor does not have a grid editor component.

### GetEditableGrid(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.GridAssemblyEditableGridData)
Gets the editable grid assembly.

- **`id`**: The object id of a grid assembly.
- **`editableGridData`**: The returned editable grid data.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if not able to open the grid assembly for the given id, or if the in place grid editor does not have a grid editor component.

### Clone
Clones the wrapped object.

### Dispose(System.Boolean)
Deletes the unmanaged object.

- **`disposing`**: unused.

**Returns:** void.
