---
title: Autodesk.Aec.DatabaseServices.ImpTree
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ImpTree
---

# Autodesk.Aec.DatabaseServices.ImpTree

## Summary
Represents an implementation tree.

## Properties

### AllowNullObjects
Gets or sets whether null objects are allowed.

**Returns:** Returns whether null objects are allowed.

### SubObjectsMightHaveReferences
Gets or sets whether subobjects can have references.

**Returns:** Returns whether subobjects can have references.

### AllowChildren
Gets or sets whether children are allowed.

**Returns:** Returns whether children are allowed.

### Root
Gets the root of the tree.

**Returns:** Returns the root of the tree.

### IsRoot
Specifies whether this is the root.

**Returns:** Returns whether this is the root.

### ParentTree
Gets the parent tree.

**Returns:** Returns the parent tree.

### Children
Gets the children tree collection.

**Returns:** Returns the children tree collection.

## Methods

### #ctor
Initializes a new instance of the ImpTree class.

### Add(Autodesk.Aec.DatabaseServices.ImpTree)
Adds a tree to the children collection.

- **`value`**: The tree.

**Returns:** The index of the newly added tree in the children collection.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Insert(System.Int32,Autodesk.Aec.DatabaseServices.ImpTree)
Inserts a tree to the specified position of the children tree collection.

- **`index`**: The specified position.
- **`value`**: The tree.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveAll
Removes all the trees in the children tree collection.

### RemoveAt(System.Int32)
Removes a child at the specified position in the children tree collection.

- **`index`**: The specified position.

### GetAt(System.Int32)
Gets the child tree at the specified position.

- **`index`**: The specified position.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetCount
Gets the count of children.

**Returns:** The count of children.
