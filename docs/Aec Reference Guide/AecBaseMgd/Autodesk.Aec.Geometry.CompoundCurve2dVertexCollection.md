---
title: Autodesk.Aec.Geometry.CompoundCurve2dVertexCollection
hierarchy: AecBaseMgd > Autodesk > Aec > Geometry > CompoundCurve2dVertexCollection
---

# Autodesk.Aec.Geometry.CompoundCurve2dVertexCollection

## Summary
Represents a compound curve 2d vertex collection.

## Properties

### Item(System.Int32)
Gets or sets the CompoundCurve2dVertex at the given index.

- **`index`**: The index.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Method currently unavailable. Will throw an InvalidOperationException() if used.

### Count
Returns the number of elements in the collection.

## Methods

### #ctor
Initializes a new instance of the CompoundCurve2dVertexCollection class.

### DeleteUnmanagedObject()
Disposes the unmanaged object.

### CopyTo
Copies the collection to an array.

- **`array`**: The array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### GetEnumerator
Gets the enumerator for the collection.

### CopyTo(Autodesk.Aec.Geometry.CompoundCurve2dVertex[],System.Int32)
Copies the collection to an array.

- **`array`**: The CompoundCurve2dVertex array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
