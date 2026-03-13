---
title: Autodesk.Aec.DatabaseServices.ObjectId
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ObjectId
---

# Autodesk.Aec.DatabaseServices.ObjectId

## Summary
Represents an object id and its block reference path.

## Properties

### Id
Gets or sets the id.

**Returns:** Returns the id.

### BlockRefPath
Gets or sets the block reference path.

**Returns:** Returns the block reference path.

### ModelToWorldTransform
Gets the model to world transformation.

**Returns:** Returns the model to world transformation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### WorldToModelTransform
Gets the world to model transformation.

**Returns:** Returns the world to model transformation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

## Methods

### Create(System.IntPtr,System.Boolean)
Creates a new instance of the ObjectId class.

- **`unmanagedPointer`**: The unmanaged pointer of AecObjectId object.
- **`autoDelete`**: Tells the wrapper whether deleting the unmanaged object automatically or not.

### #ctor
Initializes a new instance of the ObjectId class.

### #ctor(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Initializes a new instance of the ObjectId.

- **`id`**: The object id.

### #ctor(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Initializes a new instance of the ObjectId class.

- **`id`**: The object id.
- **`blockRefPath`**: The block reference path.

### Clone
Clones the wrapped object.

### DeleteUnmanagedObject
Deletes the unmanaged object.

### op_Equality(Autodesk.Aec.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.ObjectId)
Determines if the object IDs are equal.

- **`objId1`**: The first object id.
- **`objId2`**: The second object id.

**Returns:** true, if the object IDs are equal; false, otherwise.

### op_Inequality(Autodesk.Aec.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.ObjectId)
Determines if the object ids are not equal.

- **`objId1`**: The first object id.
- **`objId2`**: The second object id.

**Returns:** True, if the object ids are not equal; false, otherwise.

### Equals(Autodesk.Aec.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.ObjectId)
Determines if the object IDs are equal.

- **`objId1`**: The first object id.
- **`objId2`**: The second object id.

**Returns:** true, if the object IDs are equal; false, otherwise.

### ToString(System.IFormatProvider)
Returns a String that represents the current AEC Object id.

- **`provider`**: Format specifier used to indicate how the string is to be converted.

**Returns:** Returns a String that represents the current AEC Object id.

### ToString
Returns a String that represents the current AEC Object id.

**Returns:** Returns a String that represents the current AEC Object id.
