---
title: Autodesk.Aec.DatabaseServices.ClassificationDefinition
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ClassificationDefinition
---

# Autodesk.Aec.DatabaseServices.ClassificationDefinition

## Summary
Represents a classification definition.

## Properties

### AppliesToFilter
Gets or sets the applies to filter.

**Returns:** Returns the applies to filter.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AppliesToAll
Gets or sets the value that determines if it applies to all.

**Returns:** Returns the value that determines if it applies to all.

### ClassificationTree
Gets the classification tree.

**Returns:** Returns the classification tree.

## Methods

### #ctor
Initializes a new instance of the ClassificationDefinition class.

### AppliesTo(System.String)
Determines if it applies to the specified class name.

- **`className`**: The class name.

**Returns:** Returns true if it applies to the specified class name.

### GetClassification(System.String)
Gets the id of a classification with a specified name.

- **`classificationName`**: The classificaton name.

**Returns:** Returns the id of the classification with the specified name, if it exists, otherwise it returns a null id.

### IsClassified(Autodesk.Aec.DatabaseServices.Entity,Autodesk.Aec.DatabaseServices.ClassificationCollection)
Determines if the entity has all of the given classifications.

- **`entity`**: The entity.
- **`classificationIds`**: The classifications.

**Returns:** Returns true if the entity has all of the given classifications.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IsClassified(Autodesk.Aec.DatabaseServices.DictionaryRecord,Autodesk.Aec.DatabaseServices.ClassificationCollection)
Determines if the style has all of the given classifications.

- **`dictionaryRecord`**: The style.
- **`classificationIds`**: The classifications.

**Returns:** Returns true if the entity has all of the given classifications.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IsClassified(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.ClassificationCollection)
Determines if the object has all of the given classifications.

- **`id`**: The object id.
- **`classificationIds`**: The classifications.

**Returns:** Returns true if the object has all of the given classifications.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetClassification(Autodesk.Aec.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Get an entity's classification for a specific classification definition.

- **`entity`**: The entity.
- **`classificationDefinitionId`**: The classification definition.

**Returns:** Returns an entity's classification for a specific classification definition.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetClassification(Autodesk.Aec.DatabaseServices.DictionaryRecord,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Get a style's classification for a specific classification definition.

- **`dictionaryRecord`**: The style.
- **`classificationDefinitionId`**: The classification definition.

**Returns:** Returns a style's classification for a specific classification definition.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IsAClassifiedAsB(Autodesk.Aec.DatabaseServices.ClassificationCollection,Autodesk.Aec.DatabaseServices.ClassificationCollection,System.Boolean)
Determines if each element in A is in B.

- **`a`**: The first classification array.
- **`b`**: The second classification array.
- **`exclusive`**: true, to also test if each element in B is in A (equality).

**Returns:** Returns true if each element in A is in B.

### FilterEntitySet(Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@,Autodesk.Aec.DatabaseServices.ClassificationCollection,System.Boolean)
Filters the collection using the specified classification ids.

- **`entityIds`**: The entity collection.
- **`classificationIds`**: The classification ids.
- **`runToCompletion`**: false, to return immediately after the first entity is filtered.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
