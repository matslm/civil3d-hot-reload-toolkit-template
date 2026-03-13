---
title: Autodesk.Aec.Geometry.RingCollection
hierarchy: AecBaseMgd > Autodesk > Aec > Geometry > RingCollection
---

# Autodesk.Aec.Geometry.RingCollection

## Summary
Represents a ring collection.

## Properties

### Item(System.Int32)
Gets or sets the Ring at the given index.

- **`index`**: The index.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Method currently unavailable. Will throw an InvalidOperationException() if used.

### Count
Returns the number of elements in the collection.

## Methods

### DeleteUnmanagedObject()
Disposes the unmanaged object.

### CopyTo
Copies the collection to an array.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### GetEnumerator
Gets the enumerator for the collection.

### CopyTo(Autodesk.Aec.Geometry.Ring[],System.Int32)
Copies the collection to an array.

- **`array`**: The Ring array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
