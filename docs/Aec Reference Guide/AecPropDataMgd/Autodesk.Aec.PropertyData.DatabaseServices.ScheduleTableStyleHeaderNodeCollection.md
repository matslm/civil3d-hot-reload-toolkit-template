---
title: Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNodeCollection
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > ScheduleTableStyleHeaderNodeCollection
---

# Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNodeCollection

## Summary
Represents a collection of ScheduleTableStyleHeaderNode.

## Properties

### Count
Returns the number of ScheduleTableStyleHeaderNode available in this collection.

**Returns:** Returns the number of ScheduleTableStyleHeaderNode available in this collection.

### Item(System.Int32)
Gets or sets the item at the given index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

## Methods

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### CopyTo(ScheduleTableStyleHeaderNode[],System.Int32)
Copies the collection to the array.

- **`array`**: The ScheduleTableStyleHeaderNode array.
- **`index`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Add(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode)
Adds an item to the collection.

- **`value`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Contains(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### IndexOf(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Remove(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode)
Removes the specified item from the collection. You can still use the reference to the removed node if you remove it using this function.

- **`value`**: The item to remove.

### RemoveAt(System.Int32)
Removes the item at the specified index. After the node is removed, any old references to this node should not be used.

- **`index`**: The index.

### Clear
Removes all items from the collection. After the nodes are removed, any old references to these nodes should not be used.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Shift(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode,System.Int32)
Shift the node.

- **`node`**: The node to be shifted.
- **`amount`**: Amount.

### Prepend(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode)
Prepend a node to the collection.

- **`node`**: The new node.
