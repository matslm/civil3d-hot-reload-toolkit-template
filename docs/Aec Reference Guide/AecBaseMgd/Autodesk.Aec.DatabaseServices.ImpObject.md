---
title: Autodesk.Aec.DatabaseServices.ImpObject
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ImpObject
---

# Autodesk.Aec.DatabaseServices.ImpObject

## Summary
Represents an implementation object.

## Properties

### Description
Gets or sets the description.

**Returns:** Returns the description.

### Database
Gets the database.

**Returns:** Returns the database.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

## Methods

### #ctor
Initializes a new instance of the ImpObject class.

### SubSetDatabaseDefaults(Autodesk.AutoCAD.DatabaseServices.Database)
Sets any uninitialized data before the object is closed.

- **`db`**: The database.

**Remarks:**
This call is forwarded to the internal implementation class.

### SetToStandard(Autodesk.AutoCAD.DatabaseServices.Database)
Initializes data to realistic values after object construction.

- **`db`**: The database.
