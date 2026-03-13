---
title: Autodesk.Aec.DatabaseServices.MultiViewBlockViewInstanceCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > MultiViewBlockViewInstanceCollection
---

# Autodesk.Aec.DatabaseServices.MultiViewBlockViewInstanceCollection

## Summary
Represents a collection of multiview block view instances.

## Properties

### Count
Returns the number of MultiViewBlockViewInstances available on this collection.

**Returns:** Returns the number of MultiViewBlockViewInstances available on this collection.

### Item(System.Int32)
Returns the MultiViewBlockViewInstance at the given index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### CopyTo(Autodesk.Aec.DatabaseServices.MultiViewBlockViewInstance[],System.Int32)
Copies the collection to the array.

- **`array`**: The MultiViewBlockViewInstance array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
