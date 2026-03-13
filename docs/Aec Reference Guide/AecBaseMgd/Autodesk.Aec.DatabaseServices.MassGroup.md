---
title: Autodesk.Aec.DatabaseServices.MassGroup
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > MassGroup
---

# Autodesk.Aec.DatabaseServices.MassGroup

## Summary
Represents a mass group.

## Properties

### SubType
Gets or sets the subtype.

**Returns:** Returns the subtype.

### Body
Gets the body.

**Returns:** The body.

### Nodes
Gets the nodes.

**Returns:** Returns the nodes.

### NodeCount
Gets the number of nodes.

**Returns:** Returns the number of nodes.

### Volume
Gets the volume.

**Returns:** Returns the volume.

### Entities
Gets the elements of the group.

### RootNode
Gets the root node.

**Returns:** The id of the root element.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SupportsAnchoring
Gets or sets whether the mass group supports anchoring.

**Returns:** Returns true if the mass group supports anchoring,return false otherwise.

## Methods

### #ctor
Initializes a new instance of the MassGroup class.

### AddNode(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.Aec.DatabaseServices.Operation)
Adds a node.

- **`entity`**: The entity.
- **`operation`**: The mass group operation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveNode(Autodesk.AutoCAD.DatabaseServices.Entity)
Removes the specified node.

- **`entity`**: The entity node.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveAllNodes
Removes all nodes.

### MoveNodeToAfter(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Moves the node after the specified node id.

- **`id`**: The id of the node to move.
- **`afterId`**: The node to move after.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MoveNodeToBefore(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Moves the node before the specified id.

- **`id`**: The id of the node to move.
- **`beforeId`**: The node to move before.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MoveNodeToEnd(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Moves a node to the end.

- **`id`**: The node to move.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MoveNodeToBeginning(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Moves a node to the beginning.

- **`id`**: The node to move.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetOperation(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the mass group operation for the specified element.

- **`id`**: The element id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetOperation(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.Operation)
Sets the mass group operation for the specified element.

- **`id`**: The element id.
- **`operation`**: The mass group operation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ParentMassing(Autodesk.Aec.DatabaseServices.Operation@)
Finds the parent and operation of this mass group.

- **`operation`**: The operation.

**Returns:** Returns the parent and operation of this mass group.

### Contains(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.Operation@,System.Boolean)
Determines if the mass element is contained by this group.

- **`id`**: The mass element id.
- **`operation`**: The operation.
- **`recursive`**: true, to perform a recursive search.

### SaveBody(System.String)
Saved the mass group body to a file.

- **`filename`**: The body filename.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetMaterialId(System.Int32)
Gets the material id.

- **`componentId`**: The component id.

**Returns:** Returns the material id.

### SetSupportsAnchoring(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Boolean)
Sets whether anchoring is supported by the specified mass group .

- **`massGroupId`**: The mass group id.
- **`supports`**: Input true if anchoring is supported by the specified mass group,false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetSupportsAnchoring(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets whether anchoring is supported by the specified mass group .

- **`massGroupId`**: The mass group id.

**Returns:** Returns true if anchoring is supported by the specified mass group , false otherwise.
