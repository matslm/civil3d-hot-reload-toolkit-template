---
title: Autodesk.Aec.DatabaseServices.Override
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > Override
---

# Autodesk.Aec.DatabaseServices.Override

## Summary
Represents an override.

## Properties

### ExtensionDictionaryName
Get the name of extension dictionary.

**Returns:** The name of extension dictionary.

## Methods

### #ctor
Initializes a new instance of the Override class.

### AddToOverrideExtionDicttionaryAndClose
Add one object to another object's extension dictionary.

- **`objectToSetOn`**: The object to set on.
- **`newObjectToAdd`**: The new object to add.

**Returns:** The object id that is added into extention dictionary.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
