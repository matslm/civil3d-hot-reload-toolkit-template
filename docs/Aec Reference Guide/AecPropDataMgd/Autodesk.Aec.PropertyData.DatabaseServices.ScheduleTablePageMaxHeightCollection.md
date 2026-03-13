---
title: Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTablePageMaxHeightCollection
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > ScheduleTablePageMaxHeightCollection
---

# Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTablePageMaxHeightCollection

## Summary
Represents a collection of Schedule Table Page Max Height.

## Properties

### Count
Returns the number of System::Double available in this collection.

**Returns:** Returns the number of System::Double available in this collection.

### Item(System.Int32)
Gets or sets the item at the given index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### CopyTo(System.Double[],System.Int32)
Copies the collection to the array.

- **`array`**: The System::Double array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Add(System.Double)
Adds an item to the collection.

- **`value`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Contains(System.Double)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### IndexOf(System.Double)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,System.Double)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

### Clear
Removes all items from the collection.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Remove(System.Double)
Removes the specified item from the collection.

- **`value`**: The item to remove.
