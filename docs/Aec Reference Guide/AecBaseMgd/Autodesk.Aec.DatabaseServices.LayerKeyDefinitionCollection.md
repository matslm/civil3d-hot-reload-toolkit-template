---
title: Autodesk.Aec.DatabaseServices.LayerKeyDefinitionCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > LayerKeyDefinitionCollection
---

# Autodesk.Aec.DatabaseServices.LayerKeyDefinitionCollection

## Summary
Represents a collection of LayerKeyDefinition.

## Properties

### Item(System.Int32)
Gets or sets the LayerKeyDefinition at the given index.

- **`index`**: The index.

### Count
Returns the number of LayerKeyDefinitions available on this collection.

**Returns:** Returns the number of LayerKeyDefinitions available on this collection.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

### Clear
Removes all items from the collection.

### Add(Autodesk.Aec.DatabaseServices.LayerKeyDefinition)
Adds the specified item to the collection.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

### IndexOf(Autodesk.Aec.DatabaseServices.LayerKeyDefinition)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.DatabaseServices.LayerKeyDefinition)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

### Remove(Autodesk.Aec.DatabaseServices.LayerKeyDefinition)
Removes the specified item from the collection.

- **`value`**: The item to remove.

### Contains(Autodesk.Aec.DatabaseServices.LayerKeyDefinition)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### CopyTo(Autodesk.Aec.DatabaseServices.LayerKeyDefinition[],System.Int32)
Copies the collection to the array.

- **`array`**: The LayerKeyDefinition array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
