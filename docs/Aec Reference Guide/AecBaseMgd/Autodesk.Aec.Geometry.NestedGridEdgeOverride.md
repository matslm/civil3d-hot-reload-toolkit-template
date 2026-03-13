---
title: Autodesk.Aec.Geometry.NestedGridEdgeOverride
hierarchy: AecBaseMgd > Autodesk > Aec > Geometry > NestedGridEdgeOverride
---

# Autodesk.Aec.Geometry.NestedGridEdgeOverride

## Summary
Represents a nested grid edge override.

## Properties

### EdgePath
Gets or sets the edge path.

**Returns:** The edge path.

### EdgeDefinitionId
Gets or sets the edge definition id.

**Returns:** The edge definition id.

### IsVoid
Gets whether this override is void.

**Returns:** True if this override is void, or false otherwise.

### IsStyleBased
Gets or sets whether this override is style based.

**Returns:** True to indicate style based, or false otherwise.

## Methods

### #ctor
Initializes a new instance of the NestedGridEdgeOverride class.

### CopyFrom(Autodesk.AutoCAD.Runtime.RXObject)
Copies another override to this override.

- **`other`**: Input the other override.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetVoid
Sets this override as void.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
