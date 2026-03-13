---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertySetDataCollection
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertySetDataCollection
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertySetDataCollection

## Summary
Represents a collection of property set data.

## Properties

### Item(System.Int32)
Gets or sets an item from the collection at the specified index.

- **`index`**: The index of the item.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Count
Gets the number of items in the collection.

**Returns:** Returns the number of items in the collection.

## Methods

### GetEnumerator
Gets the enumerator for this collection.

**Returns:** Returns the enumerator for this collection.

### RemoveAt(System.Int32)
Removes an item from the collection at the specified index.

- **`index`**: The index of the item to remove.

- **Exception `T:System.NotSupportedException`**: System.NotSupportedException.

**Remarks:**
Not implemented - read only collection.

### Clear
Removes all items from the collection.

- **Exception `T:System.NotSupportedException`**: System.NotSupportedException.

**Remarks:**
Not implemented - read only collection.

### Add(Autodesk.Aec.PropertyData.DatabaseServices.PropertySetData)
Adds the specified item to the collection.

- **`value`**: The item to add.

**Returns:** The number of items in the collection.

- **Exception `T:System.NotSupportedException`**: System.NotSupportedException.

**Remarks:**
Not implemented - read only collection.

### IndexOf(Autodesk.Aec.PropertyData.DatabaseServices.PropertySetData)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.Aec.PropertyData.DatabaseServices.PropertySetData)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

- **Exception `T:System.NotSupportedException`**: System.NotSupportedException.

**Remarks:**
Not implemented - read only collection.

### Remove(Autodesk.Aec.PropertyData.DatabaseServices.PropertySetData)
Removes the specified item from the collection.

- **`value`**: The item to remove.

- **Exception `T:System.NotSupportedException`**: System.NotSupportedException.

**Remarks:**
Not implemented - read only collection.

### Contains(Autodesk.Aec.PropertyData.DatabaseServices.PropertySetData)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### CopyTo(Autodesk.Aec.PropertyData.DatabaseServices.PropertySetData[],System.Int32)
Copies the collection to the PropertySetData array.

- **`array`**: The PropertySetData array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
