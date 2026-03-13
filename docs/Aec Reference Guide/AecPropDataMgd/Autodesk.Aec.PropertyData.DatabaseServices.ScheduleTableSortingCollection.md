---
title: Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableSortingCollection
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > ScheduleTableSortingCollection
---

# Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableSortingCollection

## Summary
Represents a collection of Schedule Table Page Max Height.

## Properties

### Count
Returns the number of ScheduleTableSorting^ available in this collection.

**Returns:** Returns the number of ScheduleTableSorting^ available in this collection.

### Item(System.Int32)
Returns the item at the given index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### CopyTo(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableSorting[],System.Int32)
Copies the collection to the array.

- **`array`**: The ScheduleTableSorting^ array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Add(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableSorting)
Adds an item to the collection.

- **`value`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Contains(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableSorting)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### IndexOf(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableSorting)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableSorting)
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

### Swap(System.Int32,System.Int32)
Swap two items.

- **`index1`**: The first item index.
- **`index2`**: The second item index.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### #ctor(Autodesk.Aec.PropertyData.DatabaseServices.IScheduleTableSortingOperation)
Constructor.
