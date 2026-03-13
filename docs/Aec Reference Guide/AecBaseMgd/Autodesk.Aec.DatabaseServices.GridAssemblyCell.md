---
title: Autodesk.Aec.DatabaseServices.GridAssemblyCell
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GridAssemblyCell
---

# Autodesk.Aec.DatabaseServices.GridAssemblyCell

## Summary
Represents a grid assembly cell.

## Properties

### NestingPath
Gets the nesting path.

**Returns:** A collection with the ids of the nesting path.

### CellAssignmentId
Gets or sets the cell assignment id.

**Returns:** The cell assignment id.

### GrossStartX
Gets or sets the gross start X.

**Returns:** The gross start X.

### GrossStartY
Gets or sets the gross start Y.

**Returns:** The gross start Y.

### GrossEndX
Gets or sets the gross end X.

**Returns:** The gross end X.

### GrossEndY
Gets or sets the gross end Y.

**Returns:** The gross end Y.

### IsLeafCell
Gets or sets leaf cell state.

**Returns:** Returns true if cell is a leaf cell, false otherwise.

### IsOverridden
Gets or sets the overridden state.

**Returns:** true if it is overridden, false otherwise.

### AtEntityStart
Gets or sets entity at start state.

**Returns:** true if entity is located at start, false otherwise.

### AtEntityEnd
Gets or sets entity at end state.

**Returns:** true if entity is located at end, false otherwise.

### IsVoid
Gets or sets the memory state of the grid assembly cell.

**Returns:** true if its void, false if its allocated.

### WasTransfered
Gets or sets the transferred state.

**Returns:** true if the cell was transferred, false otherwise.

### InfillOverrideId
Gets or sets the infill override id.

**Returns:** The infill override id.

### HasNetProfile
Gets the has net profile state.

**Returns:** true if there is a net profile, false otherwise.

### NetCellProfile
Gets or sets the net profile.

**Returns:** The net profile, or null if none was set.

### NetStartX
Gets or sets the net start X value.

**Returns:** The net start X value.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
This property is only allowed if there is no net cell profile defined. Trying to use it when there is a net cell profile will throw an exception.

### NetStartY
Gets or sets the net start Y value.

**Returns:** The net start Y value.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
This property is only allowed if there is no net cell profile defined. Trying to use it when there is a net cell profile will throw an exception.

### NetEndX
Gets or sets the net end X value.

**Returns:** The net end X value.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
This property is only allowed if there is no net cell profile defined. Trying to use it when there is a net cell profile will throw an exception.

### NetEndY
Gets or sets the net end Y value.

**Returns:** The net end Y value.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
This property is only allowed if there is no net cell profile defined. Trying to use it when there is a net cell profile will throw an exception.

### ContainedEntityId
Gets or sets the id of the contained entity.

**Returns:** The id of the contained entity.

## Methods

### #ctor
Initializes a new instance of the GridAssemblyCell class.

### GetInfillDefinition(Autodesk.Aec.DatabaseServices.GridAssemblyComponentSet,Autodesk.Aec.DatabaseServices.GridAssemblyDefinition)
Gets the infill definition.

- **`componentSet`**: The component set.
- **`gridDefinition`**: The grid definition.

**Returns:** The infill definition.

### IntersectsCutPlane(System.Double)
Returns true if the given elevation intersects the cut plane.

- **`elevation`**: The elevation.

**Returns:** true if the given elevation intersects the cut plane, false otherwise.
