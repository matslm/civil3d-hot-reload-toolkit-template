---
title: Autodesk.Aec.DatabaseServices.AnchorLeaderToNodeVectorCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > AnchorLeaderToNodeVectorCollection
---

# Autodesk.Aec.DatabaseServices.AnchorLeaderToNodeVectorCollection

## Summary
Represents a collection of vectors for the leader to a node anchor.

## Properties

### Item(System.Int32)
Gets or sets an item from the collection at the specified index.

- **`index`**: The index of the item.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Count
Gets the number of items in the collection.

**Returns:** Returns the number of items in the collection.

## Methods

### RemoveAt(System.Int32)
Removes an item from the collection at the specified index.

- **`index`**: The index of the item to remove.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Clear
Removes all items from the collection.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetEnumerator
Gets the enumerator for this collection.

**Returns:** Returns the enumerator for this collection.

### Add(Autodesk.AutoCAD.Geometry.Vector2d)
Adds the specified item to the collection.

- **`value`**: The item to add.

**Returns:** The number of items in the collection.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IndexOf(Autodesk.AutoCAD.Geometry.Vector2d)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

**Remarks:**
Not implemented.

### Insert(System.Int32,Autodesk.AutoCAD.Geometry.Vector2d)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Remove(Autodesk.AutoCAD.Geometry.Vector2d)
Removes the specified item from the collection.

- **`value`**: The item to remove.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Contains(Autodesk.AutoCAD.Geometry.Vector2d)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

**Remarks:**
Not implemented.

### CopyTo(Autodesk.AutoCAD.Geometry.Vector2d[],System.Int32)
Copies the collection to the Vector2d array.

- **`array`**: The Vector2d array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
