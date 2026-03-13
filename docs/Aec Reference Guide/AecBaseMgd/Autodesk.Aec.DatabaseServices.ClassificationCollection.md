---
title: Autodesk.Aec.DatabaseServices.ClassificationCollection
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ClassificationCollection
---

# Autodesk.Aec.DatabaseServices.ClassificationCollection

## Summary
Represents a classification array.

## Properties

### Count
Returns the number of classification ids available on this collection.

**Returns:** Returns the number of classification ids available on this collection.

### Item(System.Int32)
Gets or sets the classification id at the given index.

- **`index`**: The index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### AllowDuplicateDefinitions
Gets whether the classification collection supports duplicate classification definition Ids. Typically DictionaryRecord and Entity derived classes do NOT support duplicate definitions.

**Returns:** Returns true if the classification collection supports duplicate definition Ids, or false otherwise.

## Methods

### #ctor
Initializes a new instance of the ClassificationCollection class.

### GetEnumerator
Returns an enumerator for this collection.

**Returns:** Returns an enumerator for this collection.

### CopyTo(Autodesk.AutoCAD.DatabaseServices.ObjectId[],System.Int32)
Copies the collection to the array.

- **`array`**: The ObjectId array.
- **`start`**: The start index to begin copying.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.
- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### Add(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds a classification id to the collection. If the AllowDuplicateDefinitions property is false, and the id has a parent definition that is the same as an entry already in the collection, the add operation will add the new one, but removes the old one and the count does not grow.

- **`item`**: The item.

**Returns:** Returns the index where the item was added.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Contains(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Determines if the collection contains the specified item.

- **`value`**: The item.

**Returns:** Returns true if the collection contains the specified item.

### IndexOf(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Determines the index of the specified item.

- **`value`**: The item.

**Returns:** Returns the index of the specified item.

### Insert(System.Int32,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Inserts the specified item into the collection at the specified index.

- **`index`**: The index to insert the item at.
- **`value`**: The item to insert.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
Not implemented.

### Remove(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Removes the specified item from the collection.

- **`value`**: The item to remove.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.
- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveAt(System.Int32)
Removes the item at the specified index.

- **`index`**: The index.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Clear
Removes all items from the collection.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetIdForDefinition(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the classification for the given owning system definition.

- **`idOwningSystemDefinition`**: The owning system definition.

**Returns:** Gets the classification for the given owning system definition.

### AreDifferent(Autodesk.Aec.DatabaseServices.ClassificationCollection,Autodesk.Aec.DatabaseServices.ClassificationCollection)
Determines if the classification arrays are different.

- **`a`**: The first classification collection.
- **`b`**: The second classification collection.

**Returns:** Returns true if the classification arrays are different.
