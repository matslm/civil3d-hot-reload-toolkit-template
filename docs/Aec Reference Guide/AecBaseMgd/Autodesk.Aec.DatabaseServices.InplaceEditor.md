---
title: Autodesk.Aec.DatabaseServices.InplaceEditor
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > InplaceEditor
---

# Autodesk.Aec.DatabaseServices.InplaceEditor

## Summary
Represents an inplace editor.

## Properties

### OldUcsMatrix
Gets or sets the old ucs matrix.

**Returns:** The old ucs matrix.

### EntityId
Gets or sets the entity id.

**Returns:** The entity id.

### LongTransactionId
Gets or sets the long transaction id.

**Returns:** The long transaction id.

### OldEntityEcs
Gets or sets the old entity ecs.

**Returns:** The old entity ecs.

### Entity
Gets or sets the entity.

**Returns:** The entity.

### InplaceEditorComponentCount
Gets the count of inplace editor component.

**Returns:** The count of inplace editor component.

### ActiveInplaceEditorComponentCount
Gets the count of active inplace editor component.

**Returns:** The count of active inplace editor component.

### IsSingleComponentEditor
Gets whether the inplace editor is sinble component editor.

**Returns:** Boolean value indicates whether the inplace editor is sinble component editor.

## Methods

### #ctor
Initializes a new instance of the InplaceEditor class.

### IsCurrentEditorInplaceEditEntity(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets whether the current editor is inplace edit entity.

- **`id`**: The specified id.

**Returns:** Boolean value indicates whether the current editor is inplace edit entity.

### GetInplaceEditEntities
Gets the inplace edit entities.

**Returns:** The inplace edit entities.

### InvalidCommandInInPlaceEditMode(System.String,Autodesk.Aec.DatabaseServices.CommandStatus@)
Tests whether the specified command is not allowed in inplace edit mode.

- **`commandName`**: The specified command name.
- **`status`**: Out parameter indicates the constraint of using the specified command.

**Returns:** Boolean value indicates whether the specifed command is not allowed in inplace edit mode.
