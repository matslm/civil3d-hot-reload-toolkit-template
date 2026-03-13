---
title: Autodesk.Aec.DatabaseServices.NestedGridInteriorEdgeAssignmentCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > NestedGridInteriorEdgeAssignmentCollection
---

# Autodesk.Aec.DatabaseServices.NestedGridInteriorEdgeAssignmentCollection

## Summary
Represents a collection of nested grid interior edge assignments.

## Properties

### Count
Returns the number of NestedGridEdgeAssignment available on this collection.

**Returns:** Returns the number of NestedGridEdgeAssignment available on this collection.

### Item(System.Int32)
Gets or sets the nested grid interior edge at the given index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Default
Gets or sets the default interior edge assignment.

**Returns:** The default interior edge assignment, or null if none was set.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### CopyTo(Autodesk.Aec.DatabaseServices.NestedGridEdgeAssignment[],System.Int32)
Copies the collection to the array.

- **`array`**: The NestedGridEdgeAssignment array.
- **`index`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Add(Autodesk.Aec.DatabaseServices.NestedGridEdgeAssignment)
Adds a nested grid interior edge to the collection.

- **`value`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Contains(Autodesk.Aec.DatabaseServices.NestedGridEdgeAssignment)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Not implemented.

### IndexOf(Autodesk.Aec.DatabaseServices.NestedGridEdgeAssignment)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Not implemented.

### Insert(System.Int32,Autodesk.Aec.DatabaseServices.NestedGridEdgeAssignment)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Not implemented.

### Remove(Autodesk.Aec.DatabaseServices.LineWorkAssembly)
Removes the specified item from the collection.

- **`value`**: The item to remove.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Not implemented.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Clear
Removes all items from the collection.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
