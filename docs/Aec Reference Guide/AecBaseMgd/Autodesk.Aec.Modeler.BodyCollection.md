---
title: Autodesk.Aec.Modeler.BodyCollection
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > BodyCollection
---

# Autodesk.Aec.Modeler.BodyCollection

## Summary
Represents a collection of Body objects.

## Properties

### Item(System.Int32)
Gets or sets the Body at the given index.

- **`index`**: The index.

### Count
Returns the number of Bodies available on this collection.

**Returns:** Returns the number of Bodies available on this collection.

## Methods

### #ctor
Initializes a new instance of the bodycollection class.

### CopyTo(Autodesk.Aec.Modeler.Body[],System.Int32)
Copies the collection to the array.

- **`array`**: The Body array.
- **`index`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### Add(Autodesk.Aec.Modeler.Body)
Adds the specified item to the collection.

- **`value`**: The item.

**Returns:** Returns the index where the item was added.

### IndexOf(Autodesk.Aec.Modeler.Body)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.Modeler.Body)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

### Remove(Autodesk.Aec.Modeler.Body)
Removes the specified item from the collection.

- **`value`**: The item to remove.

### Contains(Autodesk.Aec.Modeler.Body)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### Clear
Removes all items from the collection.
