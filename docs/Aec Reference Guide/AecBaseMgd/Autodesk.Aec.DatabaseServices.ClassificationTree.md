---
title: Autodesk.Aec.DatabaseServices.ClassificationTree
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ClassificationTree
---

# Autodesk.Aec.DatabaseServices.ClassificationTree

## Summary
Represents a classification tree.

## Properties

### Id
Gets or sets the classification id.

**Returns:** Returns the classification id.

## Methods

### #ctor
Initializes a new instance of the ClassificationTree class.

### SetClass(Autodesk.AutoCAD.Runtime.RXClass)
Set the RXClass for the tree.

- **`rxClass`**: The RXClass.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddNode(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds a node by id.

- **`idClassification`**: The classification id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddNode(System.String)
Adds a node by name.

- **`name`**: The classification name.

**Returns:** Returns the classification id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddBranch(Autodesk.Aec.DatabaseServices.ClassificationTree)
Adds a branch.

- **`branch`**: The branch.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetIdAt(System.Int32)
Gets the id at the specified index.

- **`index`**: The index.

**Returns:** Returns the id at the specified index.

### IsInDictionary(Autodesk.AutoCAD.DatabaseServices.DBObject)
Determines if the object is in the dictionary.

- **`obj`**: The object.

**Returns:** Returns true if the object is in the dictionary.

### IsInDictionary(Autodesk.AutoCAD.DatabaseServices.DBDictionary)
Determines if the dictionary is in the dictionary.

- **`dbDictionary`**: The dictionary.

**Returns:** Returns true if the dictionary is in the dictionary.

### SynchDictionary
Synchronizes the dictionary.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveFromDictionary
Removes this classification tree from the extension dictionary.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddNodeToParent(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.String)
Adds a node the specified parent.

- **`idParent`**: The parent node.
- **`name`**: The name of the classification.

**Returns:** Returns the id of the newly created classification.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
The name will be incremented if necessary to be unique in the tree.

### AddBranch(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.ClassificationTree)
Adds the branch to the specified parent node.

- **`idParent`**: The id of the parent node.
- **`branch`**: The branch.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
All names will be incremented if necessary to be unique in the tree.

### GetBranch(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the branch starting at the specified node.

- **`idClassification`**: The classification id.

**Returns:** Returns the branch starting at the specified node.

### GetBranch(System.String)
Gets the branch starting at the specified node.

- **`name`**: The classification name.

**Returns:** Returns the branch starting at the specified node.

### DeleteBranch(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Deletes the branch starting at the specified node.

- **`idClassification`**: The classification id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveBranch(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Removes the branch starting at the specified node.

- **`idClassification`**: The classificaton id.

**Returns:** Returns the branch starting at the specified node.

### MoveBranch(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Moves the branch from one parent to another.

- **`from`**: The node to remove the branch from.
- **`to`**: The node to add the branch to.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CopyBranch(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Copies the branch from one parent to another.

- **`from`**: The node to remove the branch from.
- **`to`**: The node to add the branch to.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Contains(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Determines if the tree contains the specified classification.

- **`idClassification`**: The classification id.

**Returns:** Returns true if the tree contains the specified classification.

### Rename(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.String)
Renames the specified classification.

- **`idClassification`**: The classification id.
- **`newName`**: The new name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
