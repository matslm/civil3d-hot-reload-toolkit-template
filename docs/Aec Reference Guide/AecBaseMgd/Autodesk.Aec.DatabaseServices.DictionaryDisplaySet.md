---
title: Autodesk.Aec.DatabaseServices.DictionaryDisplaySet
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DictionaryDisplaySet
---

# Autodesk.Aec.DatabaseServices.DictionaryDisplaySet

## Summary
Represents a helper class that accesses display sets in the named object dictionary.  This class establishes the record type for display sets recorded in the named object dictionary.  Provides helper functions for the names of the standard display sets established by the Aec framework.

## Properties

### DictionaryName
Retrieves the name of the dictionary.

**Returns:** The name of the dictionary.

### StandardPlanName
Retrieves the name of the standard plan display representation set.

**Returns:** The translated name of the standard plan display representation set.

### StandardModelName
Retrieves the name of the standard model display representation set.

**Returns:** The translated name of the standard model display representation set.

### StandardReflectedName
Retrieves the name of the standard reflected display representation set.

**Returns:** The translated name of the standard reflected display representation set.

### StandardSectionElevName
Retrieves the name of the standard section elev display representation set.

**Returns:** The translated name of the standard section elev display representation set.

### StandardPlanLowDetailName
Retrieves the name of the standard plan low detail display representation set.

**Returns:** The translated name of the standard plan low detail display representation set.

### StandardPlanHighDetailName
Retrieves the name of the standard plan high detail display representation set.

**Returns:** The translated name of the standard plan high detail display representation set.

### StandardModelLowDetailName
Retrieves the name of the standard model low detail display representation set.

**Returns:** The translated name of the standard model low detail display representation set.

### StandardModelHighDetailName
Retrieves the name of the standard model high detail display representation set.

**Returns:** The translated name of the standard model high detail display representation set.

## Methods

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database,System.Boolean)
Initializes a new instance of the DictionaryDisplaySet class using the specified database.

- **`db`**: Specified database.
- **`doInitialization`**: Flag that indicates whether initialization is needed.

### Exists(Autodesk.AutoCAD.DatabaseServices.Database)
Test if display representation set dictionary exists in the database.

- **`db`**: The database to be tested.

**Returns:** True if the dictionary exists.

### GetStandardPlanName(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the name of the standard plan display representation set.

- **`db`**: Specified database.

**Returns:** The name of the standard plan display representation set.

### GetStandardModelName(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the name of the standard model display representation set.

- **`db`**: Specified database.

**Returns:** The name of the standard model display representation set.

### GetStandardReflectedName(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the name of the standard reflected display representation set.

- **`db`**: Specified database.

**Returns:** The name of the standard reflected display representation set.

### GetStandardSectionElevName(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the name of the standard section elev display representation set.

- **`db`**: Specified database.

**Returns:** The name of the standard section elev display representation set.

### GetStandardPlanLowDetailName(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the name of the standard plan low detail display representation set.

- **`db`**: Specified database.

**Returns:** The name of the standard plan low detail display representation set.

### GetStandardPlanHighDetailName(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the name of the standard plan high detail display representation set.

- **`db`**: Specified database.

**Returns:** The name of the standard plan high detail display representation set.

### GetStandardModelLowDetailName(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the name of the standard model low detail display representation set.

- **`db`**: Specified database.

**Returns:** The name of the standard model low detail display representation set.

### GetStandardModelHighDetailName(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the name of the standard model high detail display representation set.

- **`db`**: Specified database.

**Returns:** The name of the standard model high detail display representation set.

### GetStandardPlanId(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the Id of the standard plan display representation set.

- **`db`**: Specified database.

**Returns:** The Id of the standard plan display representation set.

### GetStandardModelId(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the Id of the standard model display representation set.

- **`db`**: Specified database.

**Returns:** The Id of the standard model display representation set.

### GetStandardReflectedId(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the Id of the standard reflected display representation set.

- **`db`**: Specified database.

**Returns:** The Id of the standard reflected display representation set.

### GetStandardSectionElevId(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the Id of the standard section elev display representation set.

- **`db`**: Specified database.

**Returns:** The Id of the standard section elev display representation set.

### GetStandardPlanLowDetailId(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the Id of the standard plan low detail display representation set.

- **`db`**: Specified database.

**Returns:** The Id of the standard plan low detail display representation set.

### GetStandardPlanHighDetailId(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the Id of the standard plan high detail display representation set.

- **`db`**: Specified database.

**Returns:** The Id of the standard plan high detail display representation set.

### GetStandardModelLowDetailId(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the Id of the standard model low detail display representation set.

- **`db`**: Specified database.

**Returns:** The Id of the standard model low detail display representation set.

### GetStandardModelHighDetailId(Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the Id of the standard model high detail display representation set.

- **`db`**: Spedified database.

**Returns:** The Id of the standard model high detail display representation set.

### GetStandardSet(System.String,Autodesk.AutoCAD.DatabaseServices.Database)
Retrieves the Id of the standard display representation set.

- **`name`**: The name of view.
- **`db`**: Specified database.

**Returns:** The Id of the standard display representation set.

### ScanAndRemoveDuplicateStandardSets(Autodesk.AutoCAD.DatabaseServices.Database)
Scan and remove duplicated standard display representation sets.

- **`db`**: Specified database.

**Returns:** Result of this operation.

### CheckForMatchingEntries(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.Aec.DatabaseServices.StandardDisplaySetType)
Check for matching entries.

- **`db`**: Specified database.
- **`displaySetType`**: Specified display set type.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetStandardDisplaySetName(System.String,Autodesk.AutoCAD.DatabaseServices.Database)
This function will take the untranslated hardcoded name i.e. "Model" and return the translated version.

- **`untranslatedName`**: Untranslated hardcoded name.
- **`db`**: Specified database.

**Returns:** Translated name.
