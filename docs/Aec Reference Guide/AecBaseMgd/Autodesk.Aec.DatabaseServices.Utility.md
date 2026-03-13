---
title: Autodesk.Aec.DatabaseServices.Utility
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > Utility
---

# Autodesk.Aec.DatabaseServices.Utility

## Summary
Represents some utility functions.

## Methods

### #ctor
Initializes a new instance of the Utility class.

### SetLayer(Autodesk.AutoCAD.DatabaseServices.Entity,System.String)
Uses the input layer key and assigns the appriate layer to the input entity. It also generates the layer if it does not exist.

- **`entity`**: Input any entity type (AutoCAD or AEC specific).
- **`layerKey`**: Input a valid layer key. If no key is found, exception eKeyNotFound is thrown.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### FindAnonymousBlockLastCreated(Autodesk.AutoCAD.DatabaseServices.Database)
Finds the object id of the last created anonymous block within the specified database.

- **`db`**: The specified database.

### GetAutomaticallyBoundSpaces(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,@Autodesk.Aec.DatabaseServices.AutomaticSpaceBoundary)
Gets the bound spaces property for an object, in the context of blockRefPath.

- **`object`**: The object.
- **`blockRefPath`**: The block ref path.
- **`boundSpaces`**: The current value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAutomaticallyBoundSpaces(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.Aec.DatabaseServices.AutomaticSpaceBoundary)
Sets the bound spaces property for an object. If blockRefPath is not empty this will store the new value as an override on the topmost block ref.

- **`object`**: The object.
- **`blockRefPath`**: The block ref path.
- **`boundSpaces`**: The new value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetCurrentSupportedAnnotationScales(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the scales that are currently assgined to the input object.

- **`id`**: The object id of the object to test.

**Returns:** the scales that are currently assgined to the input object.

- **Exception `T:System.Exception.InvalidOperationException`**: System.Exception.InvalidOperationException if there is no current working database.

### CanDeleteCurrentAnnotationScale(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Determines whether the the current database scale is on the object and if it can be deleted.

- **`id`**: The object id of the object to test.

**Returns:** True if the current scale can be deletd or false otehrwise.

- **Exception `T:System.Exception.InvalidOperationException`**: System.Exception.InvalidOperationException if there is no current working database.

### MassElementHasFacesToJoin(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Checks whether the specified mass element has joinable faces.

- **`massElementId`**: The id of the mass element.

**Returns:** Boolean value indicates whether the specified mass element has joinable faces.

### IsSectionedBodyDisplayDisabled(Autodesk.AutoCAD.DatabaseServices.Database)
Determines whether sectioned bodies are displayed.

- **`db`**: The database to determine whether sectioned bodies are displayed.

**Returns:** True if section bodies are disable from display, or false otherwise.

- **Exception `T:System.Exception.InvalidOperationException`**: System.Exception.InvalidOperationException if there is no current working database.
