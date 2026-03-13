---
title: Autodesk.Aec.DatabaseServices.GridAssemblyDefinition
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GridAssemblyDefinition
---

# Autodesk.Aec.DatabaseServices.GridAssemblyDefinition

## Summary
Represents a grid assembly definition.

## Properties

### SpecificBoundaryEdgeAssignments
Gets the boundary edge assignment components.

**Returns:** The boundary edge assignment components.

### SpecificInteriorEdgeAssignments
Gets the interior edge assignment components.

**Returns:** The interior edge assignment components.

### SpecificCellAssignments
Gets the cell asignments.

**Returns:** The cell asignments.

### Name
Gets or sets the name of the grid assembly definition.

**Returns:** The name of the grid assembly definition.

## Methods

### #ctor
Initializes a new instance of the GridAssemblyDefinition class.

### MaxCellAssignmentId(System.Int16)
Recursively search for the maximum cell id.

- **`maxId`**: The given id.

**Returns:** The maximum cell assignment id.

### MaxEdgeAssignmentId(System.Int16)
Recursively search for the maximum edge id.

- **`maxId`**: The given id.

**Returns:** The maximum edge assignment id.
