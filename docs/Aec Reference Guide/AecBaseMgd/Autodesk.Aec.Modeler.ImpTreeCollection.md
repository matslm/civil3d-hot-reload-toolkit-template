---
title: Autodesk.Aec.Modeler.ImpTreeCollection
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > ImpTreeCollection
---

# Autodesk.Aec.Modeler.ImpTreeCollection

## Summary
Represents a collection of ImpTree.

## Properties

### Item(System.Int32)
Gets or sets the ImpTree at the given index.

- **`index`**: The index.

### Count
Returns the number of ImpTrees available on this collection.

**Returns:** Returns the number of ImpTrees available on this collection.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

### Clear
Removes all items from the collection.

### Add(Autodesk.Aec.Modeler.ImpTree)
Adds the specified item to the collection.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

### IndexOf(Autodesk.Aec.Modeler.ImpTree)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.Modeler.ImpTree)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

### Remove(Autodesk.Aec.Modeler.ImpTree)
Removes the specified item from the collection.

- **`value`**: The item to remove.

### Contains(Autodesk.Aec.Modeler.ImpTree)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### CopyTo(Autodesk.Aec.Modeler.ImpTree[],System.Int32)
Copies the collection to the array.

- **`array`**: The ImpTree array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
