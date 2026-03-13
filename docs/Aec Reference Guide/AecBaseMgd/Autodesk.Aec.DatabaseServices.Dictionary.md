---
title: Autodesk.Aec.DatabaseServices.Dictionary
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > Dictionary
---

# Autodesk.Aec.DatabaseServices.Dictionary

## Summary
Represents a dictionary.

## Properties

### HasStandardEntries
Gets the value that indicates if the dictionary has standard entries.

**Returns:** true, if the dictionary has standard entries.

### Records
Gets the collection of record ids.

**Returns:** Returns the collection of record ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### NamesInUse
Gets the record names in use.

**Returns:** Returns the record names in use.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DisplayName
Gets the display name.

**Returns:** Returns the display name.

### DictionaryId
Gets the id.

**Returns:** Returns the id.

### RecordType
Gets the record type.

**Returns:** Returns the record type.

### ObjectType
Gets the object type.

**Returns:** Returns the object type.

### Database
Gets the database.

**Returns:** Returns the database.

### InternalName
Gets the internal name.

**Returns:** Returns the internal name.

## Methods

### #ctor(System.String,Autodesk.AutoCAD.Runtime.RXClass,Autodesk.AutoCAD.Runtime.RXClass,System.Boolean,Autodesk.AutoCAD.DatabaseServices.Database)
Initializes a new instance of the Dictionary class using the specified record type, object type, standard entries and database.

- **`dictionaryName`**: The dictionary name.
- **`recordType`**: The record type.
- **`objectType`**: The object type.
- **`hasStandardEntries`**: true, if the dictionary will have standard entries.
- **`db`**: The database.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAt(System.String)
Gets a dictionary record by name.

- **`name`**: The name.

**Returns:** Returns a dictionary record id by name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### NameAt(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the name of a dictionary record specified by the id.

- **`id`**: The id.

**Returns:** Returns the name of a dictionary record specified by the id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAlternateAt(System.String)
Gets a dictionary record by alternate name.

- **`name`**: The alternate name.

**Returns:** Returns a dictionary record id by alternate name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
An exception is thrown if the alternate name is empty.

### NameAlternateAt(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the alternate name of a dictionary record specified by the id.

- **`id`**: The id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
An exception is thrown if the alternate name is empty.

### AddNewRecord(System.String,Autodesk.Aec.DatabaseServices.DictionaryRecord)
Adds a new record.

- **`name`**: The name.
- **`newRecord`**: The dictionary record.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Has(System.String,Autodesk.AutoCAD.DatabaseServices.Transaction)
Determines if the record exists.

- **`name`**: The name.
- **`trans`**: The transaction.

**Returns:** Returns true if the record exists.

### Rename(System.String,System.String,Autodesk.AutoCAD.DatabaseServices.Transaction)
Renames a record.

- **`oldName`**: The old name.
- **`newName`**: The new name.
- **`trans`**: The transaction.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### NewEntry
Creates a new dictionary record.

**Returns:** Returns a new dictionary record.

**Remarks:**
SetToStandard and SubSetDatabaseDefaults are automatically called on the returned DictionaryRecord.

### CloneEntry(Autodesk.Aec.DatabaseServices.DictionaryRecord,System.String)
Clones a dictionary record.

- **`copyFromRec`**: The existing record.
- **`newName`**: The new name.

**Returns:** Returns a cloned a dictionary record.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ExtraPurgeCheck(Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Checks records that could be purged.

- **`idsToPurge`**: The record ids to check.
