---
title: Autodesk.Aec.DatabaseServices.EditStateManager
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > EditStateManager
---

# Autodesk.Aec.DatabaseServices.EditStateManager

## Summary
Represents an edit state manager, a class that keeps track of the current edit state an entity is in.  The edit state manager is a singleton. The instance of it should be retrieved using the static member property 'Instance'.  The Grips mechanism makes use of the current edit state of an entity when that entity is selected for grips. The way this works is that the mechanism looks at the current edit state for the entity. It then selects those grip factories (from all the registered factories that work with the selected entity) whose compatible edit state is same as the entity's current edit state. Those factories then are asked to create grips for an entity.

## Properties

### Instance
Gets an instance of the edit state manager which is a singleton.

**Returns:** The instance of the edit state manager.

## Methods

### CurrentState(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the current edit state of the specified entity.

- **`id`**: The id of the specified entity.

**Returns:** The current edit state of the specified entity. Returns null if no edit state is attached to the specified entity.

### UnregisterStateForEntitiesInDatabase(Autodesk.AutoCAD.DatabaseServices.Database)
Unregister all the edit states from the entities in the specified database.

- **`database`**: The specified database.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### UnregisterState(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Unregisters the edit state from the specified entity.

- **`id`**: The id of the specified entity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GripStatus(Autodesk.Aec.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.GripStatus)
Notifies the edit state manager that the grip status of the specifed entity has changed. This allows the manager to react to different grip status values.

- **`entity`**: The specified entity.
- **`status`**: The status value.
