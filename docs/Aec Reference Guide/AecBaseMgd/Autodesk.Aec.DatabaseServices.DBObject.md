---
title: Autodesk.Aec.DatabaseServices.DBObject
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DBObject
---

# Autodesk.Aec.DatabaseServices.DBObject

## Summary
Represents an AEC database object.

## Properties

### Overrides
Gets Overrides.

### DisplayName
Gets the display name.

**Returns:** Returns the display name.

### TypeIcon
Gets the type icon.

**Returns:** Returns the type icon.

### Description
Gets or sets the description.

**Returns:** Returns the description.

### SwappingReferences
Gets or sets the value indicating that references are being swapped.

## Methods

### #ctor
Initializes a new instance of the DBObject class.

### GetMaterialComponents(Autodesk.AutoCAD.Geometry.IntegerCollection@,System.Collections.Specialized.StringCollection@,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@)
Returns the component ids, component names, and material ids.

- **`componentIds`**: The component ids.
- **`componentNames`**: The component names.
- **`materialIds`**: The material ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
The order of the items in the array must be the same as in SetMaterialComponents.

### SetMaterialComponents(Autodesk.AutoCAD.Geometry.IntegerCollection,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Sets the component ids and material ids.

- **`componentIds`**: The component ids.
- **`materialIds`**: The material ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SubSetDatabaseDefaults(Autodesk.AutoCAD.DatabaseServices.Database)
Sets any uninitialized data before the object is closed.

- **`db`**: The database.

### SetToStandard(Autodesk.AutoCAD.DatabaseServices.Database)
Initializes data to realistic values after object construction.

- **`db`**: The database.
