---
title: Autodesk.Aec.DatabaseServices.MultiViewBlockViewDefinitionCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > MultiViewBlockViewDefinitionCollection
---

# Autodesk.Aec.DatabaseServices.MultiViewBlockViewDefinitionCollection

## Summary
Represents a collection of MultiViewBlockViewDefinitions.

## Properties

### Count
Returns the number of MultiViewBlockViewDefinitions available on this collection.

**Returns:** Returns the number of MultiViewBlockViewDefinitions available on this collection.

### Item(System.Int32)
Gets or sets the MultiViewBlockViewDefinition at the given index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### CopyTo(Autodesk.Aec.DatabaseServices.MultiViewBlockViewDefinition[],System.Int32)
Copies the collection to the array.

- **`array`**: The MultiViewBlockViewDefinition array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Add(Autodesk.Aec.DatabaseServices.MultiViewBlockViewDefinition)
Adds a MultiViewBlockViewDefinition to the collection.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Contains(Autodesk.Aec.DatabaseServices.MultiViewBlockViewDefinition)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### IndexOf(Autodesk.Aec.DatabaseServices.MultiViewBlockViewDefinition)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.DatabaseServices.MultiViewBlockViewDefinition)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Remove(Autodesk.Aec.DatabaseServices.MultiViewBlockViewDefinition)
Removes the specified item from the collection.

- **`value`**: The item to remove.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Clear
Removes all items from the collection.
