---
title: Autodesk.Aec.DatabaseServices.NestedGridEdgeAssignment
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > NestedGridEdgeAssignment
---

# Autodesk.Aec.DatabaseServices.NestedGridEdgeAssignment

## Summary
Represents a nested grid edge assignment.

## Properties

### Name
Gets or sets the name of the nested grid edge assignment.

**Returns:** A string with the name of the nested grid edge assignment.

### EdgeSpecifier
Gets or sets the edge specifier.

**Returns:** The edge specifier or null if not found.

### Id
Gets or sets the id of the nested grid edge assignment.

**Returns:** Returns the id of the nested grid edge assignment.

### IsVoid
Gets the memory state of the nested grid edge assignment.

**Returns:** true if it allocated, false otherwise.

### EdgeDefinitionId
Gets or sets the edge definition id.

**Returns:** The edge definition id.

### ParentGrid
Gets the parent grid.

**Returns:** The parent grid, or null if not found.

## Methods

### #ctor
Initializes a new instance of the NestedGridEdgeAssignment class.

### SetVoid
Sets the memory state of the nested grid edge assignment to null.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
