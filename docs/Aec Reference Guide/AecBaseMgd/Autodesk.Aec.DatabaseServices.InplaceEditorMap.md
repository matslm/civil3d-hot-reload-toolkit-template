---
title: Autodesk.Aec.DatabaseServices.InplaceEditorMap
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > InplaceEditorMap
---

# Autodesk.Aec.DatabaseServices.InplaceEditorMap

## Summary
Represents an inplace editor map.

## Properties

### FirstParentEntityId
Gets the id of the first parent entity.

**Returns:** The id of the first parent entity.

### FirstInplaceEditorId
Gets the id of the first inplace editor.

**Returns:** The id of the first inplace editor.

### Size
Gets the size of the map.

**Returns:** The size of the map.

## Methods

### #ctor
Initializes a new instance of the InplaceEditorMap class.

### FindInplaceEditor(System.IntPtr)
Finds the id of an inplace editor using the old object id.

- **`oldId`**: The old object id.

**Returns:** The id of the inplace editor. This could equal ObjectId.Null if nothing could be found.

### FindParentEntityIdForInplaceEditEntityId(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Finds the id of the parent entity for the specified inplace edit entity id.  An eKeyNotFound exception is thrown if nothing could be found.

- **`inplaceEditEntityId`**: The specified inplace edit entity id.

**Returns:** The id of the parent entity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### FindParentEntityIdForInplaceEditorId(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Finds the id of the parent entity for the specified inplace editor id.  An eKeyNotFound exception is thrown if nothing could be found.

- **`inplaceEditorId`**: The id of the inplace editor.

**Returns:** The id of the parent entity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### FindInplaceEditorIdForInplaceEditEntityId(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Finds the id of the inplace editor for the specified inplace edit entity id.  An eKeyNotFound exception is thrown if nothing could be found.

- **`inplaceEditEntityId`**: The specified inplace edit entity id.

**Returns:** The id of the inplace editor.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetObjectIdsInInplaceEditMode
Gets the object id collection of the objects which are in inplace edit mode.

**Returns:** The object id collection of the objects which are in inplace edit mode.

### GetEntityIdsInInplaceEditMode
Gets the object id collection of the entities which are in inplace edit mode.

**Returns:** The object id collection of the entities which are in inplace edit mode.

### AddInplaceEditor(System.IntPtr,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds an inplace editor to the map.

- **`id`**: The old style id of the inplace editor.
- **`editorDataId`**: The editor data id.

**Returns:** Boolean value indicates if the operation succeeded.

### RemoveInplaceEditor(System.IntPtr)
Removes the inplace editor with specified id from the map.

- **`id`**: The old style id of the inplace editor.

**Returns:** Boolean value indicates if the operation succeeded.

### RemoveInplaceEditorAll
Removes all ids from the map.
