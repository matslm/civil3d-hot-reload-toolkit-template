---
title: Autodesk.Aec.DatabaseServices.ImpObjectCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ImpObjectCollection
---

# Autodesk.Aec.DatabaseServices.ImpObjectCollection

## Summary
Represents a collection of implementation objects.

## Properties

### Item(System.Int32)
Gets or sets the ImpObject at the given index.

- **`index`**: The index.

### Count
Returns the number of ImpObjects available on this collection.

**Returns:** Returns the number of ImpObjects available on this collection.

## Methods

### ImpObjectCollection()
Default constructor for ImpObjectCollection.

### CopyTo(Autodesk.Aec.DatabaseServices.ImpObject[],System.Int32)
Copies the collection to the array.

- **`array`**: The ImpObject array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### Add(Autodesk.Aec.DatabaseServices.ImpObject)
Adds the specified item to the collection.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

### IndexOf(Autodesk.Aec.DatabaseServices.ImpObject)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.DatabaseServices.ImpObject)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

### Remove(Autodesk.Aec.DatabaseServices.ImpObject)
Removes the specified item from the collection.

- **`value`**: The item to remove.

### Contains(Autodesk.Aec.DatabaseServices.ImpObject)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### Clear
Removes all items from the collection.
