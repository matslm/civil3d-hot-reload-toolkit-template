---
title: Autodesk.Aec.DatabaseServices.RXClassToObjectIdCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > RXClassToObjectIdCollection
---

# Autodesk.Aec.DatabaseServices.RXClassToObjectIdCollection

## Summary
Represents a collection of RXClassToObjectIds.

## Properties

### Item
Gets or sets the RXClassToObjectId at the given index.

### Count
Returns the number of RXClassToObjectIds available on this collection.

**Returns:** Returns the number of RXClassToObjectIds available on this collection.

### Item(System.Int32)
Gets or sets the RXClassToObjectId at the given index.

- **`index`**: The index.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

**Remarks:**
Never implemented!

### Clear
Removes all items from the collection.

### Add(Autodesk.Aec.DatabaseServices.RXClassToObjectId)
Adds the specified item to the collection.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

**Remarks:**
Never implemented!

### IndexOf(Autodesk.Aec.DatabaseServices.RXClassToObjectId)
Determines the index of the specified item.

- **`item`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.DatabaseServices.RXClassToObjectId)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`item`**: The item to insert.

**Remarks:**
Never implemented!

### Remove(Autodesk.Aec.DatabaseServices.RXClassToObjectId)
Removes the specified item from the collection.

- **`item`**: The item to remove.

**Remarks:**
Never implemented!

### Contains(Autodesk.Aec.DatabaseServices.RXClassToObjectId)
Determines if the collection contains the specified item.

- **`item`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### CopyTo(Autodesk.Aec.DatabaseServices.RXClassToObjectId[],System.Int32)
Copies the collection to the array.

- **`array`**: The RXClassToObjectId array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Lookup(Autodesk.AutoCAD.Runtime.RXClass)
Gets all object ids of the specified RXClass type.

- **`type`**: Input the type of RXClass.

**Returns:** Returns the collection of all object ids with the specified RXClass type.
