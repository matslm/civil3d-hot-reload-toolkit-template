---
title: Autodesk.Aec.DatabaseServices.GridAssembly
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GridAssembly
---

# Autodesk.Aec.DatabaseServices.GridAssembly

## Summary
Represents a grid assembly.

## Properties

### SupportsInstanceBasedGridDefinition
Returns true if GridAssembly supports instance based grid definitions, false otherwise.

**Returns:** Returns true if GridAssembly supports instance based grid definitions, false otherwise.

### SupportsStyleBasedGridDefinition
Returns true if GridAssembly supports style based grid definitions, false otherwise.

**Returns:** Returns true if GridAssembly supports style based grid definitions, false otherwise.

### GridDefinitionLocation
Gets or sets the grid definition location.

**Returns:** The grid definition location.

### GridAssemblyDefinition
Gets or sets the grid assembly definition for this grid assembly.

**Returns:** Grid assembly definition for this grid assembly or null if none is available.

### ComponentSet
Gets or sets the component set for this grid assembly.

**Returns:** The Component Set for this grid assembly or null if none is available.

### BaseCurveRadius
Gets the base curve radius.

**Returns:** The base curve radius.

### XAxisLength
Gets the X axis length.

**Returns:** The X axis length.

### YAxisLength
Gets the Y axis length.

**Returns:** The Y axis length.

### YAxisOffset
Gets the Y axis offset.

**Returns:** The Y axis offset.

### StartMiterAngle
Gets the starting miter angle. If HasStartMiterAngle returns false, this property returns zero.

**Returns:** The starting miter angle.

**Remarks:**
If HasStartMiterAngle returns false, this property always returns zero indicating there is no active miter angle.

### EndMiterAngle
Gets the ending miter angle. If HasEndMiterAngle returns false, this property will returns zero.

**Returns:** The starting miter angle.

**Remarks:**
If HasEndMiterAngle returns false, this property always returns zero indicating there is no active miter angle.

### SupportsInterference
Gets the supports interference state.

**Returns:** true if the grid assembly supports interferences, false otherwise.

### Interferences
Gets the grid assembly interferences.

**Returns:** The grid assembly interferences.

### NestedGridCellMergeData
Gets the nested grid cell merge data collection.

**Returns:** The grid nested grid cell merge data collection.

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

### CellCount
Gets the cell count.

**Returns:** The cell count.

### EdgeCount
Gets the edge count.

**Returns:** The edge count.

### HasClippingBoundary
Gets state of clipping boundary.

**Returns:** true if grid assembly has clipping boundary, false otherwise.

### HasClippingProfile
Gets state of clipping profile.

**Returns:** true if grid assembly has clipping profile, false otherwise.

### HasClippingRectangle
Gets state of clipping rectangle.

**Returns:** true if grid assembly has clipping rectangle, false otherwise.

### ClippingRectangle
Gets or sets the clipping rectangle.

**Returns:** Clipping rectangle or null if none is available.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Throws exception if there is no clipping boundary or clipping rectangle.

### ClippingProfile
Gets or sets the clipping profile.

**Returns:** Clipping profile or null if none is available.

### EditDepth
Gets or sets the edit depth.

**Returns:** The edit depth.

### CustomLineworkProfile
Returns the custom line work profile.

**Returns:** Custom line work profile or null if none is available.

### InterferencesCount
Gets the number of interferences.

**Remarks:**
This property is mainly provided for UI purposes. Typically you would acquire the collection and work with it.

### IsManualGridDivision
Gets whether this grid assembly has been converted to a manual grid division. The determination is successful only when under edit in place.

**Returns:** True if the assembly is in manual division mode (under in-place edit).

### IsStyleBased
Gets whether this grid assembly is style based.

**Returns:** True if the assembly is style based.

### HasEdgeProfile
Gets whether this grid assembly has any edge profile(s).

**Returns:** True if the assembly has edge profiles, or false otherwise.

## Methods

### #ctor
Initializes a new instance of the GridAssembly class.

### SetGridDirty(System.Boolean)
Sets the dirty value for the grid assembly.

- **`value`**: The dirty value for the grid assembly.

### UpdateGridContents
Updates the grid assembly contents.

**Remarks:**
The update will do the following: remove grid definition from style if grid definition is null; reset custom grid profile if one exists; reconstruct the cells and edges.

### GetMinAndMaxElevation(System.Double@,System.Double@,Autodesk.Aec.DatabaseServices.GridAssemblyComponentSet)
Gets the minimum and maximum elevation.

- **`minElevation`**: The returned minimum elevation.
- **`maxElevation`**: The returned maximum elevation.
- **`componentSet`**: The component set.

**Remarks:**
Should be handled by the derived classes only.

### GetRightAndLeftExtents(System.Double@,System.Double@,Autodesk.Aec.DatabaseServices.GridAssemblyComponentSet)
Finds leftmost and rightmost offsets by examining edges and infills.

- **`leftOffset`**: The returned leftmost offset.
- **`rightOffset`**: The returned rightmost offset.
- **`componentSet`**: The component set.

### HasStartMiterAngle(System.Double@)
Gets the state and the start miter angle.

- **`angle`**: If there is a start miter, this parameter will return the start miter angle.

**Returns:** true if there is a start miter, false otherwise.

### SetHasStartMiterAngle(System.Boolean,System.Double)
Sets the state and the start miter angle.

- **`value`**: The state of the start miter angle.
- **`angle`**: The start miter angle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### HasEndMiterAngle(System.Double@)
Gets the state and the end miter angle.

- **`angle`**: If there is an end miter, this parameter will return the end miter angle.

**Returns:** true if there is an end miter, false otherwise.

### SetHasEndMiterAngle(System.Boolean,System.Double)
Sets the state and the end miter angle.

- **`value`**: The state of the end miter angle.
- **`angle`**: The end miter angle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetCellAt(System.Int32)
Gets cell at given index.

- **`index`**: The index.

**Returns:** The cell at given index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetCell(System.Int32)
Returns grid assembly cell for this grid assembly.

- **`cellId`**: The cell's id.

**Returns:** Grid assembly cell for this grid assembly or null if none is available.

### IncrementCellAssignmentId
Increments the cell assignment id, and returns the new value.

**Returns:** The next cell assignment id.

### GetEdgeAt(System.Int32)
Gets the edge at the given index.

- **`index`**: The index.

**Returns:** The edge at the given index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetEdge(System.Int32)
Gets the edge that has the given id.

- **`edgeId`**: The edge id.

**Returns:** Grid assembly edge for this grid assembly or null if not found.

### GetEdge(System.Int32,System.Int32@)
Gets the grid assembly edge for the edge id given, and sets edgeIndex to its index.

- **`edgeId`**: The edge id.
- **`edgeIndex`**: The edge index.

**Returns:** Grid assembly edge for the edge id given, and sets edgeIndex to its index. Returns null if no grid assembly edge was available for the given id.

### GetEdge(Autodesk.AutoCAD.Geometry.IntegerCollection)
Gets edge that has same nesting path as the path given.

- **`path`**: The nesting path.

**Returns:** The edge that has same nesting path as the path given. Returns null if no edge was found on path given.

### GetEdge(Autodesk.AutoCAD.Geometry.IntegerCollection,System.Int32@)
Gets the edge (and edge index) that has same nesting path as the path given.

- **`path`**: The nesting path.
- **`edgeIndex`**: The returned edge index.

**Returns:** The edge and edge index that has same nesting path as the path given. Returns null if no edge was found on path given (edgeIndex will be undetermined in that case).

### IncrementEdgeAssignmentId
Increments the edge assignment id, and returns the new value.

**Returns:** The next edge assignment id.

### RemoveClippingBoundary
Removes the clipping boundary.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetMaterialIds(Autodesk.Aec.DatabaseServices.GridAssemblyComponentType,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@)
Gets collection of material ids.

- **`component`**: The type of component to get the material ids for.
- **`materialIdsCollection`**: The returned collection of material ids.

### GetAnchoredObjectsFor(System.Boolean)
Gets the objects anchored to this grid assembly.

- **`collectRecursive`**: Go recursive if the anchored object is grid assembly. Put true as default.

**Returns:** The collection of ids of the anchored objects.
