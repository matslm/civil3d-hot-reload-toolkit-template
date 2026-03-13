---
title: Autodesk.Aec.PropertyData.DatabaseServices.DisplayThemeScheduleDataRule
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > DisplayThemeScheduleDataRule
---

# Autodesk.Aec.PropertyData.DatabaseServices.DisplayThemeScheduleDataRule

## Summary
Represents a display theme schedule data rule.

## Properties

### PropertySetDefinitionId
Retrieve the id of the property set definition.

**Returns:** The id of the property set definition.

### PropertyDefinitionId
Retrieve the id of the property definition.

**Returns:** The id of the property definition.

## Methods

### #ctor
Initializes a new instance of the DisplayThemeScheduleDataRule class.

### SetPropertySetDefinitionId(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Boolean)
Set the id of the property set definition.

- **`id`**: The new id of the property set definition.
- **`isUpdate`**: Flag that indicates whether it is needed to update.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetPropertyDefinitionId(System.Int32,System.Boolean)
Set the id of the property definition.

- **`id`**: The new id of the property definition.
- **`isUpdate`**: Flag that indicates whether it is needed to update.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetValidPropertySetDefinitions(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.Aec.DatabaseServices.NameObjectIdPairCollection)
Retrieves valid property set difinitions.

- **`db`**: Database.
- **`validAvailablePropertyDefinitionSets`**: Name object id pair collection.

**Returns:** Flag indicates success.
