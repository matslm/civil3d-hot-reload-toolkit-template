---
title: Autodesk.Aec.DatabaseServices.StreamColorToPropertiesMap
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > StreamColorToPropertiesMap
---

# Autodesk.Aec.DatabaseServices.StreamColorToPropertiesMap

## Summary
This class is for future use with the StreamBodyColorModeType kUseAsMapIndex to allow associating an object with a color of a body edge or face.

## Methods

### #ctor
Initializes a new instance of the StreamColorToPropertiesMap class.

### Lookup(System.Int32)
Gets the display component entity indexed by the specified key.

- **`key`**: The key used to look up the entity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: The exception is thrown if the entity indexed by the key is not found.

### SetAt(System.Int32,Autodesk.Aec.DatabaseServices.DisplayComponentEntity,System.Boolean)
Sets the specified entity at the specified index key.

- **`key`**: The specified index key.
- **`value`**: The specified entity.
- **`deleteExisting`**: Boolean value indicates whether the entity should be deleted if it exists.

### DeleteAll
Deletes all items.
