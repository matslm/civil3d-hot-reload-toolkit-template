---
title: Autodesk.Aec.DatabaseServices.ObjectIdAndBlockReferencePathCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ObjectIdAndBlockReferencePathCollection
---

# Autodesk.Aec.DatabaseServices.ObjectIdAndBlockReferencePathCollection

## Summary
Represents a ObjectId and BlockReferencePath Collection.

## Properties

### Item
Gets or sets the indexed item.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Count
Gets the count.

**Returns:** The count.

## Methods

### #ctor
Initializes a new instance of the ObjectIdAndBlockReferencePathCollection class.

### Add(Autodesk.Aec.DatabaseServices.ObjectIdAndBlockReferencePath)
Add item.

- **`ObjectIdAndBlockReferencePath`**: The id and block reference path.

**Returns:** The added index.

### Add(Autodesk.Aec.DatabaseServices.ObjectIdAndBlockReferencePath,System.Boolean)
Add item.

- **`ObjectIdAndBlockReferencePath`**: The item.
- **`bypassCheck`**: If bypass check.

**Returns:** The added index.

### Append(Autodesk.Aec.DatabaseServices.ObjectIdAndBlockReferencePathCollection)
Append item.

- **`containerToAppend`**: The item.

### Append(Autodesk.Aec.DatabaseServices.ObjectIdAndBlockReferencePathCollection,System.Boolean)
Append item.

- **`containerToAppend`**: The item to append.
- **`bypassCheck`**: If bypass check.

### Remove(Autodesk.Aec.DatabaseServices.ObjectIdAndBlockReferencePath)
Remove item.

- **`blockRefPath`**: The item.

### RemoveAt(System.Int32)
Remove item at certain index.

- **`index`**: The index.

### Clear
Clear all items.

### Contains(Autodesk.Aec.DatabaseServices.ObjectIdAndBlockReferencePath)
If contains certain item.

- **`ObjectIdAndBlockReferencePath`**: The item.

**Returns:** True if it contains, false otherwise.

### IndexOf(Autodesk.Aec.DatabaseServices.ObjectIdAndBlockReferencePath)
Index of certain item.

**Returns:** The index.

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.
