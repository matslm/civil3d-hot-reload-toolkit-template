---
title: Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderTree
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > ScheduleTableStyleHeaderTree
---

# Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderTree

## Summary
Represents a ScheduleTableStyleHeaderTree.

## Properties

### MaxLevel
Gets the max level of the tree.

**Returns:** The max level.

### Root
Gets the root node of the tree.

**Returns:** The root node.

### Columns
Gets the ScheduleTableStyleColumn collection.

**Returns:** The column collection.

## Methods

### #ctor
Initializes a new instance of the ScheduleTableStyleHeaderTree class.

### InsertNode(System.String,System.Int32,Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode,Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode[])
Insert a node to specific position.

- **`text`**: Text of the node.
- **`newIndex`**: The new index of the node.
- **`parent`**: Parent of the node.
- **`children`**: Children of the node.

**Returns:** The newly inserted node.

### DeleteNode(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode)
Delete a specified node.

- **`node`**: Node to be deleted.

### ShiftNode(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode,System.Int32)
Shift specified node.

- **`node`**: The node to be shifted.
- **`amount`**: The amount.

### MoveNode(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode,Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode,System.Int32,Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode,System.Int32)
Move the specified node from the old parent to a new parent.

- **`node`**: The node to be moved.
- **`originalParent`**: The original parent.
- **`originalIndex`**: The original index of the node.
- **`newParent`**: The new parent.
- **`newIndex`**: The new index of the node.

### IsNodeChildOf(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode,Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode)
Determine if a specified node is the child node of another node.

- **`node`**: The node.
- **`parent`**: The parent node.

**Returns:** Whether the node is the child node of another node.

### Contains(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode)
Determines if the tree contains the specified node.

- **`node`**: The specified node.

**Returns:** Whether the tree contains the specified node.
