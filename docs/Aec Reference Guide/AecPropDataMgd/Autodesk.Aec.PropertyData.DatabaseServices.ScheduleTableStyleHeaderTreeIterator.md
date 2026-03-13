---
title: Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderTreeIterator
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > ScheduleTableStyleHeaderTreeIterator
---

# Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderTreeIterator

## Summary
Represents a ScheduleTableStyleHeaderTreeIterator.

## Methods

### #ctor(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderTree,Autodesk.Aec.PropertyData.IteratorType)
Initializes a new instance of the ScheduleTableStyleHeaderTreeIterator class.

- **`tree`**: The tree to be traversed.
- **`type`**: The type of the iterator.

### Next
Gets the next node in the tree.

**Returns:** The next node.

### Reset
Reset the iterator. Note that this operation DOES NOT reload the tree. If your tree is modified, then you're in trouble.

### Dump
Debug function.
