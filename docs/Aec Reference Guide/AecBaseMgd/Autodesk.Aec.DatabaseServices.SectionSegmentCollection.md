---
title: Autodesk.Aec.DatabaseServices.SectionSegmentCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > SectionSegmentCollection
---

# Autodesk.Aec.DatabaseServices.SectionSegmentCollection

## Summary
Represents a collection of section vertex.

## Properties

### Count
Returns the number of SectionSegments available on this collection.

**Returns:** Returns the number of SectionSegments available on this collection.

### Item(System.Int32)
Gets or sets the SectionSegment at the given index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
This property is invalid for the SectionSegmentCollection got from Section2d.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
This method is invalid for the SectionSegmentCollection got from Section2d.

### CopyTo(Autodesk.Aec.DatabaseServices.SectionSegment[],System.Int32)
Copies the collection to the array.

- **`array`**: The SectionSegment array.
- **`index`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
This method is invalid for the SectionSegmentCollection got from Section2d.

### Add(Autodesk.Aec.DatabaseServices.SectionSegment)
Adds a SectionSegment to the collection.

- **`value`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Not implemented.

### Contains(Autodesk.Aec.DatabaseServices.SectionSegment)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Not implemented.

### IndexOf(Autodesk.Aec.DatabaseServices.SectionSegment)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Not implemented.

### Insert(System.Int32,Autodesk.Aec.DatabaseServices.SectionSegment)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Not implemented.

### Remove(Autodesk.Aec.DatabaseServices.SectionSegment)
Removes the specified item from the collection.

- **`value`**: The item to remove.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Not Implemented.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Not Implemented.

### Clear
Removes all items from the collection.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Not Implemented.
