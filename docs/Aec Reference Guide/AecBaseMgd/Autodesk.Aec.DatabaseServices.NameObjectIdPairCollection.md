---
title: Autodesk.Aec.DatabaseServices.NameObjectIdPairCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > NameObjectIdPairCollection
---

# Autodesk.Aec.DatabaseServices.NameObjectIdPairCollection

## Summary
Represents a NameObjectIdPair collection.

## Properties

### Item(System.Int32)
Gets or sets the NameObjectIdPair at the given index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Count
Returns the number of items available on this collection.

**Returns:** Returns the number of items available on this collection.

## Methods

### #ctor
Initializes a new instance of the NameObjectIdPairCollection class.

### #ctor(System.Boolean)
Initializes a new instance of the NameObjectIdPairCollection class using the specified parameter.

- **`caseSensitive`**: Flag that indicates whether the collection is case sensitive.

### CopyTo(Autodesk.Aec.DatabaseServices.NameObjectIdPair[],System.Int32)
Copies the collection to the array.

- **`array`**: The NameObjectIdPair array.
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

### Add(Autodesk.Aec.DatabaseServices.NameObjectIdPair)
Adds the specified item to the tail of the collection.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### IndexOf(Autodesk.Aec.DatabaseServices.NameObjectIdPair)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Insert(System.Int32,Autodesk.Aec.DatabaseServices.NameObjectIdPair)
Inserts the specified item into the collection at the specified index. This operation is not supported.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

### Remove(Autodesk.Aec.DatabaseServices.NameObjectIdPair)
Removes the specified item from the collection.

- **`value`**: The item to remove.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Contains(Autodesk.Aec.DatabaseServices.NameObjectIdPair)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Clear
Removes all items from the collection.

### AddAlpha(Autodesk.Aec.DatabaseServices.NameObjectIdPair)
Adds the specified item to the collection at the appropriate position in alphabetic order.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### AddHead(Autodesk.Aec.DatabaseServices.NameObjectIdPair)
Adds the specified item to the head collection.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### RemoveHead()
Removes the first item in the collection.

### RemoveTail()
Removes the last item in the collection.

### Rename(System.String,System.String)
Change the name of specific NameObjectIdPair existing in the collection.

- **`oldName`**: The original name of the NameObjectIdPair.
- **`newName`**: The new name of the NameObjectIdPair.

**Returns:** Flag indicates whether this operation succeeded.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### IndexOf(System.String)
Determines the index of the item matching the specific name.

- **`name`**: specific name.

**Returns:** Returns the index of the item.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### IndexOf(Autodesk.Aec.DatabaseServices.ObjectId)
Determines the index of the item matching the specific object id.

- **`objectId`**: Specific object id.

**Returns:** Returns the index of the item.

### GetMatchFor(Autodesk.Aec.DatabaseServices.ObjectId)
Returns the name of the item matching the specific object id.

- **`objectId`**: Specific object id.

**Returns:** Returns the name of the item. Returns null if no item matches the object id.
