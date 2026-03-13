---
title: Autodesk.Aec.DatabaseServices.AnchorEntityToGridAssembly
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > AnchorEntityToGridAssembly
---

# Autodesk.Aec.DatabaseServices.AnchorEntityToGridAssembly

## Summary
Represents an entity to a grid assembly anchor.

## Properties

### GridAssemblyId
Gets or sets the Id of the grid assembly.

**Returns:** Returns the Id of the grid assembly.

### GridAssemblyCellId
Gets or sets the Id of the grid assembly cell.

**Returns:** The Id of the grid assembly cell.

### HasSizingOffsets
Gets or sets the value that determines if the anchor has sizing offsets.

**Returns:** Returns the value that determines if the anchor has sizing offsets.

### BottomOffset
Gets or sets the bottom offset.

**Returns:** Returns the bottom offset.

### TopOffset
Gets or sets the top offset.

**Returns:** Returns the top offset.

### LeftOffset
Gets or sets the left offset.

**Returns:** Returns the left offset.

### RightOffset
Gets or sets the right offset.

**Returns:** Returns the right offset.

### AllowVariesFromInfillDefinition
Gets or sets the value that determines if the anchor is allowed to vary from the infill definition.

**Returns:** Returns the value that determines if the anchor is allowed to vary from the infill definition.

### YOffset
Gets or sets the Y offset.

**Returns:** Returns the Y offset.

### YAlignment
Gets or sets the Y alignment.

**Returns:** Returns the Y alignment.

## Methods

### #ctor
Initializes a new instance of the AnchorEntityToGridAssembly class.

### GetOrientation(System.Boolean@,System.Boolean@,System.Boolean@)
Gets the orientation of the anchor.

- **`flipX`**: The flip in X value.
- **`flipY`**: The flip in Y value.
- **`flipZ`**: The flip in Z value.

**Returns:** Returns the orientation of the anchor.

### SetOrientation(System.Boolean,System.Boolean,System.Boolean)
Sets the orientation of the anchor.

- **`flipX`**: The flip in X value.
- **`flipY`**: The flip in Y value.
- **`flipZ`**: The flip in Z value.
