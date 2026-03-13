---
title: Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumnCollection
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > ScheduleTableStyleColumnCollection
---

# Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumnCollection

## Summary
Represents a collection of ScheduleTableStyleColumn.

## Properties

### Count
Returns the number of ScheduleTableStyleColumn available in this collection.

**Returns:** Returns the number of ScheduleTableStyleColumn available in this collection.

### Item(System.Int32)
Gets or sets the item at the given index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### CopyTo(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn[],System.Int32)
Copies the collection to the array.

- **`array`**: The ScheduleTableStyleColumn array.
- **`index`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Add(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn)
Adds an item to the collection.

- **`value`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Contains(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### IndexOf(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn)
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

### Prepend(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn)
Prepend a column to the collection.

- **`column`**: The new column.

### Remove(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn)
Removes the specified item from the collection.

- **`value`**: The item to remove.

### IndexOf(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32)
Determines the index of the specified item.

- **`propSetDefId`**: The propSetDefId.
- **`propId`**: The propId.

**Returns:** Returns the index of the specified item.
