---
title: Autodesk.Aec.DatabaseServices.NestedGridInfillDefinition
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > NestedGridInfillDefinition
---

# Autodesk.Aec.DatabaseServices.NestedGridInfillDefinition

## Summary
Represents a nested grid infill definition.

## Properties

### Id
Gets or sets the id of the nested grid infill.

**Returns:** Returns the id of the nested grid infill.

### Name
Gets or sets the name of the nested grid infill.

**Returns:** A string with the name of the nested grid infill.

### SupportsMitre
Gets state of mitre support.

**Returns:** true if it supports mitre, false otherwise.

### LeftOffset
Gets the left offset distance.

**Returns:** The left offset distance.

### RightOffset
Gets the right offset distance.

**Returns:** The right offset distance.

### YOffset
Gets or sets the Y offset.

**Returns:** The Y offset value.

### YAlignment
Gets or sets the Y alignment.

**Returns:** The Y alignment type.

### SupportsMaterials
Gets the state for material support.

**Returns:** true if it supports materials, false otherwise.

### MaterialId
Gets or sets the material id.

**Returns:** The material id.

## Methods

### #ctor
Initializes a new instance of the NestedGridInfillDefinition class.

### ManageAnchoredEntity(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.GridAssemblyCell,Autodesk.Aec.DatabaseServices.AnchorContext,System.Boolean)
Specifies an entity to be managed by the grid.

- **`entity`**: The entity.
- **`cell`**: The cell.
- **`context`**: The anchor context.
- **`styleWasChanged`**: true, if the style was changed.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Must be handled by the derived classes.

### GetOrientation(System.Boolean@,System.Boolean@,System.Boolean@)
Gets the orientation of the grid infill definition.

- **`flipX`**: The returned flip state for the X axis.
- **`flipY`**: The returned flip state for the Y axis.
- **`flipZ`**: The returned flip state for the Z axis.

### SetOrientation(System.Boolean,System.Boolean,System.Boolean)
Sets the orientation of the grid infill definition.

- **`flipX`**: The flip state for the X axis.
- **`flipY`**: The flip state for the Y axis.
- **`flipZ`**: The flip state for the Z axis.
