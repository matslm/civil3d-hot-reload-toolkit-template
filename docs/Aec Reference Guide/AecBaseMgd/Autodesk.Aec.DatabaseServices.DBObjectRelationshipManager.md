---
title: Autodesk.Aec.DatabaseServices.DBObjectRelationshipManager
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DBObjectRelationshipManager
---

# Autodesk.Aec.DatabaseServices.DBObjectRelationshipManager

## Summary
Represents a class of manager of relationships.

## Properties

### ObjectsWithEnhancedReferences
Gets all AEC objects in the database that currently contain enhanced references.

**Returns:** Returns all AEC objects in the database that currently contain enhanced references.

- **Exception `T:System.Exception`**: System.Exception.

### ObjectsWithEnhancedReferencesIncludingErased
Gets all AEC objects in the database that currently contain enhanced references, including erased.

**Returns:** Returns all AEC objects in the database that currently contain enhanced references, including erased.

- **Exception `T:System.Exception`**: System.Exception.

### IsNotificationSuppressed
Indicates whether or not notification is currently suppressed.

**Returns:** Returns true if notification is currently suppressed, otherwise false.

- **Exception `T:System.Exception`**: System.Exception.

### Database
Gets the database that owned by this DBObjectRelationshipManager.

**Returns:** Returns the database that owned by this DBObjectRelationshipManager.

- **Exception `T:System.Exception`**: System.Exception.

## Methods

### #ctor
Initializes a new instance of the DBObjectRelationshipManager class.

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database)
Initializes a new instance of the DBObjectRelationshipManager class.

### GetObjectsOfType(Autodesk.AutoCAD.Runtime.RXClass,System.Boolean)
Gets all AEC objects in the database of the specified class type.

- **`type`**: Inputs class type.
- **`verifyObject`**: Inputs true if verifying objects are valid or not.

**Returns:** Returns all AEC objects in the database of the specified class type.

- **Exception `T:System.Exception`**: System.Exception.

### GetObjectsOfTypeIncludingErased(Autodesk.AutoCAD.Runtime.RXClass,System.Boolean)
Gets all AEC objects in the database of the specified class type, including erased.

- **`type`**: Inputs class type.
- **`verifyObject`**: Inputs true if verifying objects are valid or not.

**Returns:** Returns all AEC objects in the database of the specified class type, including erased.

- **Exception `T:System.Exception`**: System.Exception.

### ObjectContainsEnhancedReferences(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets to know whether this DBObject contains enhanced references or not.

- **`id`**: Inputs the object id.

**Returns:** Returns to true if this DBObject contains enhanced references, otherwise false.

- **Exception `T:System.Exception`**: System.Exception.

### GetAllReferences(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets all references from and to the specified object.

- **`object`**: Inputs the DBObject.

**Returns:** Returns all references from and to the specified object.

- **Exception `T:System.Exception`**: System.Exception.

### GetAllReferencesIncludingErased(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets all references, including erased, from and to the specified object.

- **`object`**: Inputs the DBObject.

**Returns:** Returns all references, including erased, from and to the specified object.

- **Exception `T:System.Exception`**: System.Exception.

### GetReferencesToThisObject(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets the ids of all objects referencing the specified object.

- **`object`**: Inputs the referenced DBObject.

**Returns:** Returns the ids of all objects referencing the specified object.

- **Exception `T:System.Exception`**: System.Exception.

### GetReferencesToThisObjectIncludeErased(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets the ids of all objects, including erased, referencing the specified object.

- **`object`**: Inputs the referenced DBObject.

**Returns:** Returns the ids of all objects, include erased, referencing the specified object.

- **Exception `T:System.Exception`**: System.Exception.

### GetReferencesToThisObjectRecursive(Autodesk.AutoCAD.DatabaseServices.DBObject,System.Int32,System.Boolean)
Gets all objects referencing this object plus all other objects referencing those objects, plus all objects referencing those objects, etc. recursively.

- **`object`**: Inputs the referenced DBObject.
- **`relationshipTypeFilter`**: Inputs the relationship type to filter objects.
- **`includeFilter`**: Inputs true or false to allow user to specify a relationship type or not.

**Returns:** Returns all objects referencing this object plus all other objects referencing those objects, plus all objects referencing those objects, etc. recursively.

- **Exception `T:System.Exception`**: System.Exception.

### GetReferencesToThisObjectRecursiveIncludeErased(Autodesk.AutoCAD.DatabaseServices.DBObject,System.Int32,System.Boolean)
Gets all objects, including erased, referencing this object plus all other objects referencing those objects, plus all objects referencing those objects, etc. recursively.

- **`object`**: Inputs the referenced DBObject.
- **`relationshipTypeFilter`**: Inputs the relationship type to filter objects.
- **`includeFilter`**: Inputs true or false to allow user to specify a relationship type or not.

**Returns:** Returns all objects, including erased, referencing this object plus all other objects referencing those objects, plus all objects referencing those objects, etc. recursively.

- **Exception `T:System.Exception`**: System.Exception.

### GetReferencesFromThisObject(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets all objects that the specified object is referencing.

- **`object`**: Inputs the referencing DBObject.

**Returns:** Returns all objects that the specified object is referencing.

- **Exception `T:System.Exception`**: System.Exception.

### GetReferencesFromThisObjectIncludeErased(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets all objects that the specified object is referencing, including erased.

- **`object`**: Inputs the referencing DBObject.

**Returns:** Returns all objects that the specified object is referencing, including erased.

- **Exception `T:System.Exception`**: System.Exception.

### GetClassReferencesToThisObject(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets all class references to this object.

- **`object`**: Inputs the referenced DBObject.

**Returns:** Returns all class references to this object.

- **Exception `T:System.Exception`**: System.Exception.

### GetClassReferencesToThisObjectIncludErased(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets all class references, including erased,  to this object.

- **`object`**: Inputs the referenced DBObject.

**Returns:** Returns all class references, including erased, to this object.

- **Exception `T:System.Exception`**: System.Exception.

### SupressNotificationOn
Supress the notification on.

- **Exception `T:System.Exception`**: System.Exception.

### SupressNotificationOff
Supress the notification off.

- **Exception `T:System.Exception`**: System.Exception.

### ForceUpdate
Walks through all AEC derived entities and tells them to update themselves in the graph.

- **Exception `T:System.Exception`**: System.Exception.
- **Exception `T:System.Exception`**: System.Exception.

### ForceUpdate(Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Walks through all AEC derived entities contained in ObjectIdCollection and tells them to update themselves in the graph.

- **`updateIds`**: Inputs the ObjectIdCollection for update.

- **Exception `T:System.Exception`**: System.Exception.
- **Exception `T:System.Exception`**: System.Exception.
