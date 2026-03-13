---
title: Autodesk.Aec.DatabaseServices.ViewDependentCombinationCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ViewDependentCombinationCollection
---

# Autodesk.Aec.DatabaseServices.ViewDependentCombinationCollection

## Summary
Represents a collection of ViewDependentCombinationCollection.

## Properties

### Item(System.Int32)
Gets or sets the ViewDependentCombination at the given index.

- **`index`**: The index.

### Count
Returns the number of ViewDependentCombinations available on this collection.

**Returns:** Returns the number of ViewDependentCombinations available on this collection.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

### Clear
Removes all items from the collection.

### Add(Autodesk.Aec.DatabaseServices.ViewDependentCombination)
Adds the specified item to the collection.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

### IndexOf(Autodesk.Aec.DatabaseServices.ViewDependentCombination)
Determines the index of the specified item.

- **`item`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.DatabaseServices.ViewDependentCombination)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`item`**: The item to insert.

### Remove(Autodesk.Aec.DatabaseServices.ViewDependentCombination)
Removes the specified item from the collection.

- **`item`**: The item to remove.

### Contains(Autodesk.Aec.DatabaseServices.ViewDependentCombination)
Determines if the collection contains the specified item.

- **`item`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### CopyTo(Autodesk.Aec.DatabaseServices.ViewDependentCombination[],System.Int32)
Copies the collection to the array.

- **`array`**: The ViewDependentCombination array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
