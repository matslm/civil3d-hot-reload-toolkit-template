---
title: Autodesk.Aec.DatabaseServices.OverrideCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > OverrideCollection
---

# Autodesk.Aec.DatabaseServices.OverrideCollection

## Summary
Represents a collection of Override.

## Properties

### Item(System.Int32)
Gets or sets the Override at the given index.

- **`index`**: The index.

### Count
Returns the number of Overrides available on this collection.

**Returns:** Returns the number of Overrides available on this collection.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

### Clear
Removes all items from the collection.

### Add(Autodesk.Aec.DatabaseServices.Override)
Adds the specified item to the collection.

- **`value`**: The item.

**Returns:** Returns the index where the item was added.

### #ctor(Autodesk.Aec.DatabaseServices.IOverrideOperation)
Initializes a new instance of the OverrideCollection class.
