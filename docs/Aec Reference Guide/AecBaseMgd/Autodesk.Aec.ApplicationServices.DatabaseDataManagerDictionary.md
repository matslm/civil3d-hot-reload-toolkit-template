---
title: Autodesk.Aec.ApplicationServices.DatabaseDataManagerDictionary
hierarchy: AecBaseMgd > Autodesk > Aec > ApplicationServices > DatabaseDataManagerDictionary
---

# Autodesk.Aec.ApplicationServices.DatabaseDataManagerDictionary

## Summary
Represents a database data manager dictionary.

## Methods

### RegisterPacketType(System.String,Autodesk.AutoCAD.Runtime.RXClass)
Register the specified packet class type with the specified key name.

- **`keyName`**: The specified key name.
- **`packetClassType`**: The specified packet class type.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### UnRegisterPacketType(System.String)
Unregister the specifed packet class type associated with the specified key name.

- **`keyName`**: The specified key name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetManager(System.String)
Gets the database data manager associated with the specified key name.

- **`keyName`**: The specified key name.

**Returns:** The database data manager.

### GetManagers
Gets the managers.

- **`managers`**: The managers.
