---
title: Autodesk.Aec.DatabaseServices.GridAssemblyEdge
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GridAssemblyEdge
---

# Autodesk.Aec.DatabaseServices.GridAssemblyEdge

## Summary
Represents a grid assembly edge.

## Properties

### NestingPath
Gets the nesting path.

**Returns:** A collection with the ids of the nesting path.

### EdgeAssignmentId
Gets or sets the edge assignment id.

**Returns:** The edge assignment id.

### EdgeId
Gets or sets the edge id.

**Returns:** The edge id.

### IsInternalEdge
Gets or sets the internal edge state.

**Returns:** true if edge is internal, false otherwise.

### IsOverridden
Gets or sets the overridden state.

**Returns:** true if it is overridden, false otherwise.

### HasProfileOverride
Gets or sets the profile override state.

**Returns:** true if it has a profile override, false otherwise.

### IsVoid
Gets or sets the memory state of the grid assembly edge.

**Returns:** true if its void, false if its allocated.

### StartAtEntityStart
Gets or sets the start at entity start state.

**Returns:** true if edge starts at the entity start, false otherwise.

### EndAtEntityStart
Gets or sets the end at entity start state.

**Returns:** true if edge ends at the entity start, false otherwise.

### StartAtEntityEnd
Gets or sets the start at entity end state.

**Returns:** true if edge starts at the entity end, false otherwise.

### EndAtEntityEnd
Gets or sets the end at entity end state.

**Returns:** true if edge ends at the entity end, false otherwise.

### EdgeOverrideId
Gets or sets the edge override id.

**Returns:** The edge override id.

### ProfileOverrideId
Gets or sets the profile override id.

**Returns:** The profile override id.

### EdgeCurve
Gets or sets the edge curve.

**Returns:** The edge curve or null if none was set.

## Methods

### #ctor
Initializes a new instance of the GridAssemblyEdge class.

### GetEdgeDefinition(Autodesk.Aec.DatabaseServices.GridAssemblyComponentSet,Autodesk.Aec.DatabaseServices.GridAssemblyDefinition)
Gets the edge definition.

- **`componentSet`**: The component set.
- **`gridDefinition`**: The grid definition.

**Returns:** The edge definition, or null if not found.

### IntersectsCutPlane(System.Double,Autodesk.Aec.DatabaseServices.NestedGridEdgeDefinition)
Returns true if the given elevation intersects the cut plane.

- **`elevation`**: The elevation.
- **`edgeDefinition`**: The edge definition.

**Returns:** true if the given elevation intersects the cut plane, false otherwise.

**Remarks:**
If the edge is vertical it compares with the elevation. If the edge is horizontal, then it takes in consideration the width of the given edge definition and the given elevation to find out if it intersects the cut plane.
