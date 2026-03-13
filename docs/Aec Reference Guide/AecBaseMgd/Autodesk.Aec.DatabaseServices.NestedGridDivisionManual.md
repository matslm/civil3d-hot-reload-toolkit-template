---
title: Autodesk.Aec.DatabaseServices.NestedGridDivisionManual
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > NestedGridDivisionManual
---

# Autodesk.Aec.DatabaseServices.NestedGridDivisionManual

## Summary
Represents a nested grid division manual.

## Properties

### ManualEdgeDefinitionCount
Gets the manual edge definition count.

**Returns:** The manual edge definition count.

## Methods

### #ctor
Initializes a new instance of the NestedGridDivisionManual class.

### ManualEdgeDefinitionAt(System.Int32)
Gets the manual edge definition at the given index.

- **`index`**: The given index.

**Returns:** The manual edge definition at the given index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### AddManualEdgeDefinition(Autodesk.Aec.DatabaseServices.NestedGridDivisionManualEdgeDefinition)
Adds the manual edge definition to this NestedGridDivisionManual.

- **`edgeDefinition`**: The manual edge definition.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
This method transfers ownership of the object wrapped by the NestedGridDivisionManualEdgeDefinition to the NestedGridDivisionManual.

### RemoveManualEdgeDefinitionAt(System.Int32)
Removes the manual edge definition at the given index.

- **`index`**: The given index.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
