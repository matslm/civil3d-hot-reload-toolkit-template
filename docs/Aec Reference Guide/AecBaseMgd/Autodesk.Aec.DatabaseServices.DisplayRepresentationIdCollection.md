---
title: Autodesk.Aec.DatabaseServices.DisplayRepresentationIdCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplayRepresentationIdCollection
---

# Autodesk.Aec.DatabaseServices.DisplayRepresentationIdCollection

## Summary
Represents a collection of display representation object id.

## Properties

### Item(System.Int32)
Gets or sets the object id at the given index.

- **`index`**: The index.

### Count
Returns the number of display representation ids available on this collection.

**Returns:** Returns the number of display representation ids available on this collection.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

### Clear
Removes all items from the collection.

### Add(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds the specified item to the collection.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

### IndexOf(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Determines the index of the specified item.

- **`item`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`item`**: The item to insert.

### Remove(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Removes the specified item from the collection.

- **`item`**: The item to remove.

### Contains(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Determines if the collection contains the specified item.

- **`item`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### CopyTo(Autodesk.AutoCAD.DatabaseServices.ObjectId[],System.Int32)
Copies the collection to the array.

- **`array`**: The object id array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
