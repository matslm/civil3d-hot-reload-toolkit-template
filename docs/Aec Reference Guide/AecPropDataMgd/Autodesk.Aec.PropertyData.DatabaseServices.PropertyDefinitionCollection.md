---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionCollection
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertyDefinitionCollection
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionCollection

## Summary
Represents a collection of property definitions.

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

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Clear
Removes all items from the collection.

### Add(Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinition)
Adds the specified item to the collection.

- **`value`**: The item to add.

**Returns:** The number of items in the collection.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IndexOf(Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinition)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### IndexOf(System.String)
Determines the index of the property set with the specifed name.

- **`propertyName`**: The name of the property set.

**Returns:** Returns the index of the property set with the specifed name.

### Insert(System.Int32,Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinition)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Remove(Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinition)
Removes the specified item from the collection.

- **`value`**: The item to remove.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Contains(Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinition)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### CopyTo(Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinition[],System.Int32)
Copies the collection to the PropertyDefinition array.

- **`array`**: The PropertyDefinition array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.
