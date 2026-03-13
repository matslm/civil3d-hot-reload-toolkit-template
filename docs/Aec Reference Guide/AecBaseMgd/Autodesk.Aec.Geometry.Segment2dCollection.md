---
title: Autodesk.Aec.Geometry.Segment2dCollection
hierarchy: AecBaseMgd > Autodesk > Aec > Geometry > Segment2dCollection
---

# Autodesk.Aec.Geometry.Segment2dCollection

## Summary
Represents a segment 2d collection.

## Properties

### Item(System.Int32)
Gets or sets the Segment2d at the given index.

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

### CopyTo(Autodesk.Aec.Geometry.Segment2d[],System.Int32)
Copies the collection to an array.

- **`array`**: The Segment2d array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
