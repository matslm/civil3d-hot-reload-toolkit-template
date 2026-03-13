---
title: Autodesk.Aec.DatabaseServices.InplaceEditorUtilities
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > InplaceEditorUtilities
---

# Autodesk.Aec.DatabaseServices.InplaceEditorUtilities

## Summary
Represents an inplace editor utilities class.

## Methods

### GetInplaceEditorMap(Autodesk.AutoCAD.DatabaseServices.Database)
Gets the inplace editor map.

- **`db`**: The specified database.

**Returns:** The inplace editor map.

### AddInplaceEditorToEntity(Autodesk.Aec.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds the inplace editor to the specified entity.

- **`entity`**: The specified entity.
- **`inplaceEditorId`**: The id of the inplace editor.

### DeleteInplaceEditorFromEntity(Autodesk.Aec.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Deletes the inplace editor from the specified entity.

- **`entity`**: The specified entity.
- **`inplaceEditorId`**: The id of the inplace editor.

### CreateNewInplaceEditProfileDefinitionFromOldProfileDefinition(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Creates new inplace edit profile definition from old profile definition.

- **`oldProfileId`**: The id of the old profile definition.

**Returns:** The id of the new profile definition.

### CreateNewProfileDefinitionFromOldProfileDefinition(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Creates new profile definition from old profile definition.

- **`oldProfileDefinition`**: The id of the old profile definition.

**Returns:** The id of the new profile definition.

### PurgeInplaceEditProfiles(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Purges the inplace edit profiles.

- **`db`**: The specified database.
- **`profileIds`**: The id collection of the profiles.

### CreateNewInplaceEditDictionaryEntryFromOldDictionaryEntry(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.Dictionary)
Creates new inplace edit dictionary entry from old dictionary entry.

- **`oldDictionaryId`**: The old dictionary entry entry.
- **`dictionary`**: The specified dictionary.

**Returns:** The new dictionary entry id.

### CreateNewDictionaryEntryFromOldDictionaryEntry(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.Dictionary)
Creates new dictionary entry from old dictionary entry.

- **`oldDictionaryId`**: The old dictionary entry id.
- **`dictionary`**: The specified dictionary.

**Returns:** The new dictionary entry id.

### AddEditorToExtentionDictionaryAndClose(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.Aec.DatabaseServices.InplaceEditor)
Adds the specified inplace editor to extention dictionary and then close the editor.

- **`objectToSegOn`**: The specified db object.
- **`newEditorToAdd`**: The specified inplace editor.

**Returns:** The id of the new dictionary entry.

### RemoveEditorFromExtentionDictionary(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Removes the specified inplace editor from extention dictionary.

- **`objectToRemoveFrom`**: The specified db object from which the specified inplace editor should be removed.
- **`entryId`**: The id of the specified inplace editor.

### HandledModifiedMessageFromInplaceEditEntity(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.Aec.DatabaseServices.Entity,System.Int32,Autodesk.AutoCAD.Runtime.RXClass)
Handled modified message from inplace edit entity.

- **`fromObj`**: The 'from' object.
- **`toEntity`**: The 'to' entitry.
- **`messageId`**: The message id.
- **`allowedFromClass`**: The allowed 'from' class.

### CurrentInplaceEditLongTransactionId(Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Gets the current inplace edit long transaction id.

- **`selectedObjectIds`**: The selected object id collection.

**Returns:** The current inplace edit long transaction id.

### IsInplaceEditSessionInProgress(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Checks whether the inplace edit session is in progress.

- **`selectedEntityId`**: The selected entity id.

**Returns:** Boolean value indicates whether the inplace edit session is in progress.

### IsInplaceEditSessionInProgress(Autodesk.AutoCAD.DatabaseServices.Database)
Checks whether the inplace edit session is in progress.

- **`db`**: The specified database.

**Returns:** Boolean value indicates whether the inplace edit session is in progress.

### CurrentInplaceEditorId(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the current inplace editor id.

- **`selectedEntityId`**: The selected entity id.

**Returns:** The id of the current inplace editor.

### SelectionSetHasEntitiesFromInPlaceEditSession(Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Checks whether the selection set has entities from the inplace edit session.

- **`selectedObjectIds`**: The selected object id collection.
- **`inplaceEditEntities`**: The inplace edit entities.

**Returns:** Boolean value indicates whether the selection set has entities from the inplace edit session.

### InvalidCommandInInPlaceEditMode(Autodesk.AutoCAD.DatabaseServices.Database,System.String,Autodesk.Aec.DatabaseServices.CommandStatus@)
Tests whether the specified command is not allowed in inplace edit mode.

- **`db`**: The specified database.
- **`commandName`**: The specified command name.
- **`status`**: Out parameter indicates the constraint of using the specified command.

**Returns:** Boolean value indicates whether the specified command is not allowed in inplace edit mode.

### EntityIdInInPlaceEditMode(Autodesk.AutoCAD.DatabaseServices.Database)
Gets the entity id in inplace edit mode.

- **`db`**: The specified database.

**Returns:** The entity id in inplace edit mode.

### InplaceEditorIdInInPlaceEditMode(Autodesk.AutoCAD.DatabaseServices.Database)
Gets the inplace editor id in inplace edit mode.

- **`db`**: The specified database.

**Returns:** The inplace editor id in inplace edit mode.

### GetInplaceEditEntitiesInInPlaceEditMode(Autodesk.AutoCAD.DatabaseServices.Database)
Gets the inplace edit entities in inplace edit mode.

- **`db`**: The specified database.

### UpdateAnchoredObjectsForInplaceEditOperation(Autodesk.AutoCAD.DatabaseServices.Database,System.String)
Updates the anchored objects for inplace edit operation.

- **`db`**: The specified database.
- **`commandName`**: The specified command name.

**Returns:** Boolean value.

### HandleInplaceEditorMapOperation(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Boolean)
Handles the inplace editor map operation.

- **`entityId`**: The specified entity id.
- **`inplaceEditorId`**: The specified inplace editor id.
- **`add`**: Boolean value.

### FindParentEntityIdForInplaceEditEntityId(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Finds the parent entity id for inplace edit entity id.

- **`inplaceEditEntityId`**: The inplace edit entity id.

**Returns:** The parent entity id.
