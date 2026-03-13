---
title: Autodesk.Aec.DatabaseServices.ListDefinition
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ListDefinition
---

# Autodesk.Aec.DatabaseServices.ListDefinition

## Summary
Represents a list definition.

## Properties

### AllowToVary
Gets or sets if the list definition is allowed to vary.

**Returns:** Returns true if the list definition is allowed to vary. Otherwise, returns false.

## Methods

### #ctor
Initializes a new instance of the ListDefinition class.

### GetListItems
Gets the items of this list definition.

**Returns:** The ObjectId collection of all list items.

### AddListItem(System.String)
Adds a new item to the list definition.

- **`name`**: The name of the new item to add.

**Returns:** The ObjectId of the new added list item.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetListItem(System.String)
Returns the ObjectId of the list item whose name is the specified name.

- **`name`**: The name of the wanted list item.

**Returns:** The ObjectId of the list item with respect to the specified name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DeleteListItem(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Removes the list item whose ObjectId is the specified id.

- **`id`**: The ObjectId of the list item to remove.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RenameList(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.String)
Renames the list item name with respect to the ObjectId of the list definition to rename.

- **`listId`**: The ObjectId of the list item to rename.
- **`newName`**: The new name for the list item.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
