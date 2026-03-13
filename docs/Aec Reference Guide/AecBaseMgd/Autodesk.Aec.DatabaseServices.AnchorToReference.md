---
title: Autodesk.Aec.DatabaseServices.AnchorToReference
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > AnchorToReference
---

# Autodesk.Aec.DatabaseServices.AnchorToReference

## Summary
Represents an anchor to a reference.

## Properties

### ReferenceObjectCount
Specifies the number of referenced objects.

**Returns:** Returns number of referenced objects.

**Remarks:**
This value is usually 1.

### SingleReferenceId
Specifies the Id of the single object referenced.

**Returns:** Returns the Id of the single object referenced, or null.

## Methods

### #ctor
Initializes a new instance of the AnchorToReference class.

### IsReferenced(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.RelationType@)
Determines if the specified entity is referenced.

- **`id`**: The entity.
- **`relationType`**: The type of relation.

**Returns:** Returns true if the specified entity is referenced.

### AppendReferenceObject(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.RelationType)
Adds the passed in object as a reference of this anchor.

- **`id`**: The referenced object.
- **`relationType`**: The type of relation.

### RemoveReferenceObject(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Removes the passed in id from the list of references.

- **`id`**: The referenced object.

### RemoveAllReferenceObjects
Removes all references.

### GetReferenceObjectAt(System.Int32,Autodesk.Aec.DatabaseServices.RelationType@)
Determines the referenced object and relation type at the current index.

- **`index`**: The index of the referenced object.
- **`relationType`**: The type of relation.

**Returns:** Returns the referenced object and relation type at the current index.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetSingleReference(Autodesk.Aec.DatabaseServices.RelationType@)
Specifies the first referenced object and its relation type.

- **`relationType`**: The type of relation.

**Returns:** Returns the first referenced object and its relation type.

**Remarks:**
Returns null and NotApplicable if there is no referenced object.

### SetSingleReference(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.RelationType)
Sets one reference to the specified object.

- **`id`**: The referenced object Id.
- **`relationType`**: The type of relation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MirrorParameters(System.Boolean,Autodesk.Aec.DatabaseServices.Geo,Autodesk.AutoCAD.Geometry.Matrix3d)
Called internally when the anchor is transformed.

- **`referenceWasMirrored`**: If true, the reference object was in the selection set.
- **`geo`**: The owner of this anchor.
- **`transform`**: The mirror transformation matrix.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
This gives derived anchors a chance to mirror their parameters.

### IsReferencedNested(Autodesk.Aec.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.Aec.DatabaseServices.RelationType@)
Determines whether the specified entity is referenced.

- **`aecId`**: The entity.
- **`db`**: The database.
- **`relationType`**: The type of relation.

**Returns:** Returns true if the specified entity is referenced.

### AppendNestedReferenceObject(Autodesk.Aec.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.Aec.DatabaseServices.RelationType)
Adds the passed in object as a reference of this anchor.

- **`aecId`**: The referenced object.
- **`db`**: The database.
- **`relationType`**: The type of relation.

### RemoveNestedReferenceObject(Autodesk.Aec.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.Database)
Removes the passed in id from the list of references.

- **`aecId`**: The referenced object.
- **`db`**: The database.

### GetNestedReferenceObjectAt(System.Int32,Autodesk.Aec.DatabaseServices.RelationType@)
Determines the referenced object and relation type at the current index.

- **`index`**: The index of the referenced object.
- **`relationType`**: The type of relation.

**Returns:** Returns the referenced object and relation type at the current index.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetNestedSingleReference(Autodesk.Aec.DatabaseServices.RelationType@)
Specifies the first referenced object and its relation type.

- **`relationType`**: The type of relation.

**Returns:** Returns the first referenced object and its relation type.

**Remarks:**
Returns null and NotApplicable if there is no referenced object.

### SetNestedSingleReference(Autodesk.Aec.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.Aec.DatabaseServices.RelationType)
Sets one reference to the specified object.

- **`aecId`**: The referenced object Id.
- **`db`**: The database.
- **`relationType`**: The type of relation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
