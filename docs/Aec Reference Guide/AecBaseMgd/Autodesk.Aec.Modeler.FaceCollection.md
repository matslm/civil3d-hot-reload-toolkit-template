---
title: Autodesk.Aec.Modeler.FaceCollection
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > FaceCollection
---

# Autodesk.Aec.Modeler.FaceCollection

## Summary
Represents a collection of faces.

## Properties

### Item(System.Int32)
Gets or sets the Face at the given index.

- **`index`**: The index.

### Count
Returns the number of Faces available on this collection.

**Returns:** Returns the number of Faces available on this collection.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

### Clear
Removes all items from the collection.

### Add(Autodesk.Aec.Modeler.Face)
Adds the specified item to the collection.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### IndexOf(Autodesk.Aec.Modeler.Face)
Determines the index of the specified item.

- **`item`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.Modeler.Face)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`item`**: The item to insert.

### Remove(Autodesk.Aec.Modeler.Face)
Removes the specified item from the collection.

- **`item`**: The item to remove.

### Contains(Autodesk.Aec.Modeler.Face)
Determines if the collection contains the specified item.

- **`item`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### CopyTo(Autodesk.Aec.Modeler.Face[],System.Int32)
Copies the collection to the array.

- **`array`**: The Face array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
