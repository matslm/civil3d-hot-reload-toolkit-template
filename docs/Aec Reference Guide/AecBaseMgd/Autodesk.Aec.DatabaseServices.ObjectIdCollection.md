---
title: Autodesk.Aec.DatabaseServices.ObjectIdCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ObjectIdCollection
---

# Autodesk.Aec.DatabaseServices.ObjectIdCollection

## Summary
Represents a collection of object ids.

## Properties

### Item(System.Int32)
Gets or sets the ObjectId at the given index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Count
Returns the number of ObjectIds available on this collection.

**Returns:** Returns the number of ObjectIds available on this collection.

## Methods

### #ctor
Initializes a new instance of the ObjectIdCollection.

- **`db`**: The drawing database.

### CopyTo(Autodesk.Aec.DatabaseServices.ObjectId[],System.Int32)
Copies the collection to the array.

- **`array`**: The ObjectId array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### Add(Autodesk.Aec.DatabaseServices.ObjectId)
Adds the specified item to the collection.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

### IndexOf(Autodesk.Aec.DatabaseServices.ObjectId)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.DatabaseServices.ObjectId)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Remove(Autodesk.Aec.DatabaseServices.ObjectId)
Removes the specified item from the collection.

- **`value`**: The item to remove.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Contains(Autodesk.Aec.DatabaseServices.ObjectId)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### Clear
Removes all items from the collection.
