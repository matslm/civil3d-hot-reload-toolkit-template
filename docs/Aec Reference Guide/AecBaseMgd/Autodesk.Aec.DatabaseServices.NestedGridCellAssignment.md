---
title: Autodesk.Aec.DatabaseServices.NestedGridCellAssignment
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > NestedGridCellAssignment
---

# Autodesk.Aec.DatabaseServices.NestedGridCellAssignment

## Summary
Represents a nested grid cell assignment.

## Properties

### Name
Gets or sets the name of the nested grid cell assignment.

**Returns:** A string with the name of the nested grid cell assignment.

### InfillDefinitionId
Gets or sets the infill definition id.

**Returns:** The infill definition id.

### NestedGridDefinition
Gets or sets the nested grid definition associated with this cell.

**Returns:** The nested grid definition associated with this cell, or null if none was associated yet.

### CellSpecifier
Gets or sets the index specifier associated with this cell.

**Returns:** The index specifier associated with this cell, or null if none was associated yet.

### Id
Gets or sets the id of the nested grid cell assignment.

**Returns:** Returns the id of the nested grid cell assignment.

### IsVoid
Gets the memory state of the nested grid cell assignment.

**Returns:** true if its void, false if its allocated.

### ParentGrid
Gets the parent grid.

**Returns:** The parent grid, or null if not found.

## Methods

### #ctor
Initializes a new instance of the NestedGridCellAssignment class.

### SetVoid
Sets the memory state of the nested grid cell assignment to null.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Deletes the existing nested grid definition.
