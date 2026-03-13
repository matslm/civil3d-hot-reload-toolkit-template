---
title: Autodesk.Aec.DatabaseServices.GridAssemblyStyle
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GridAssemblyStyle
---

# Autodesk.Aec.DatabaseServices.GridAssemblyStyle

## Summary
Represents a grid assembly style.

## Properties

### GridAssemblyDefinition
Gets or sets the grid assembly definition.

**Returns:** The grid assembly definition.

### ComponentSet
Gets or sets the grid assembly component set.

**Returns:** The grid assembly component set, or null if none was set.

### NestedGridCellOverrides
Gets the nested grid cell overrides collection.

**Returns:** The grid nested grid cell overrides collection.

### NestedGridEdgeOverrides
Gets the nested grid edge overrides collection.

**Returns:** The grid nested grid edge overrides collection.

### NestedGridEdgeProfileOverrides
Gets the nested grid edge profile overrides collection.

**Returns:** The grid nested grid edge profile overrides collection.

### NestedGridDivisionOverrides
Gets the nested grid division overrides collection.

**Returns:** The grid nested grid division overrides collection.

## Methods

### #ctor
Initializes a new instance of the GridAssemblyStyle class.

### SetFromGridAssemblyEntity(Autodesk.Aec.DatabaseServices.GridAssembly@,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
Sets the grid assembly style based on the data from the grid assembly given.

- **`gridAssembly`**: The given grid assembly (will be modified)
- **`copyMergers`**: The state to copy merge data.
- **`copyCellOverrides`**: The state to copy merge data.
- **`copyEdgeOverrides`**: The state to copy edge overrides.
- **`copyProfileOverrides`**: The state to copy profile overrides.
- **`copyDivisionOverrides`**: The state to copy division overrides.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
This method: copies the grid definition and components from the given grid assembly; and copies over former style based overrides and new instance overrides if any was specified (and removes them from the given grid assembly instance).  Throws exception if grid definition location of the given grid assembly is StyleBased, or if it was unable to get the grid assembly definition or components from the given grid assembly.

### IncrementCellAssignmentId
Increments the cell assignment id, and returns the new value.

**Returns:** The next cell assignment id.

### IncrementEdgeAssignmentId
Increments the edge assignment id, and returns the new value.

**Returns:** The next edge assignment id.

### GetMaterialIds(Autodesk.Aec.DatabaseServices.GridAssemblyComponentType,Autodesk.AutoCAD.Geometry.IntegerCollection@,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@)
Gets the component ids and collection of material ids for a given component type.

- **`component`**: The component type.
- **`componentIds`**: The returned collection of component ids.
- **`materialIdsCollection`**: The returned collection of material ids.
