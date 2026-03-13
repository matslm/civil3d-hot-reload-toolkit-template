---
title: Autodesk.Aec.Modeler.CurveCollection
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > CurveCollection
---

# Autodesk.Aec.Modeler.CurveCollection

## Summary
Represents a collection of Curves.

## Properties

### Item(System.Int32)
Gets or sets the Curve at the given index.

- **`index`**: The index.

### Count
Returns the number of Curves available on this collection.

**Returns:** Returns the number of Curves available on this collection.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

### Clear
Removes all items from the collection.

### Add(Autodesk.Aec.Modeler.Curve)
Adds the specified item to the collection.

- **`value`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### IndexOf(Autodesk.Aec.Modeler.Curve)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.Modeler.Curve)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

### Remove(Autodesk.Aec.Modeler.Curve)
Removes the specified item from the collection.

- **`value`**: The item to remove.

### Contains(Autodesk.Aec.Modeler.Curve)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### CopyTo(Autodesk.Aec.Modeler.Curve[],System.Int32)
Copies the collection to the array.

- **`array`**: The Curve array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
