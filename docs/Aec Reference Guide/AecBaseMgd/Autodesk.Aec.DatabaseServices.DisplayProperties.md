---
title: Autodesk.Aec.DatabaseServices.DisplayProperties
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplayProperties
---

# Autodesk.Aec.DatabaseServices.DisplayProperties

## Summary
Represents a display properties base class.

## Properties

### OwningDisplayRep
Gets owning display representation id.

**Returns:** Owning display representation id.

### OwningDisplayRepClass
Gets owning display representation class.

**Returns:** Owning display representation class.

### IsDrawingDefault
Check if it is drawing default.

**Returns:** Ture if it is drawing default, false otherwise.

### IsStyleOverride
Check if it is style override.

**Returns:** True if it is style override, false otherwise.

### OwnerObjectId
Gets owner object id.

**Returns:** Owner object id.

## Methods

### #ctor
Initializes a new instance of the DisplayProperties class.

### GetApplicableDisplayComponents(System.Collections.Specialized.StringCollection@)
Gets applicable display components.

- **`componentNames`**: Returns display components' name.

**Returns:** Array of DisplayComponent.

### GetDisplayComponents(System.Collections.Specialized.StringCollection@)
Gets display components.

- **`componentNames`**: returns display components' name.

**Returns:** Array of DisplayComponent.

### SetDisplayRepDefaults(Autodesk.Aec.DatabaseServices.DisplayRepresentation)
Sets default display representation.

- **`displayRep`**: Display representation.

### GetDisplayRepsWhichWorksWithThisDisplayProps(System.Boolean)
Gets display representations which work with this display properties.

- **`ignoreOwnerDisplayRep`**: whether or not ignore the owner display representation.

### GetDisplayRepsWhichWorksWithThisDisplayPropsClass(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Runtime.RXClass,System.Boolean)
Gets display representations which work with the display properties class.

- **`db`**: Database.
- **`displayPropsClass`**: Display properties class.
- **`ignoreDerivedDispProps`**: Whether or not ignore the owner display representation.

### GetDisplayPropertiesOverrideClassType(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets display properties override class type.

- **`id`**: The object id.

**Returns:** Display properties override class type.

### GetDisplayRepsForOverride(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets display properties for verride.

- **`id`**: The object id collection for override display representation.

**Returns:** Display representation override object id.

### GetDisplayPropertiesFromOverride(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets display properties from override.

- **`id`**: The object id collection for override display representation.

**Returns:** Display representation override object id.

### GetDisplayPropsExistsInDrawingDefaultDictionary(Autodesk.AutoCAD.Runtime.RXClass,Autodesk.AutoCAD.DatabaseServices.Database)
Gets the object id of display properties exists in the drawing default dictionary.

- **`dispPropsClass`**: Display properties class.
- **`db`**: Database.

**Returns:** Gets the object id of display properties exists in the drawing default dictionary.

### RemoveDisplayPropsFromDrawingDefaultDictionary(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Removes the display properties from the drawing default dictionary.

- **`objectId`**: Object id of the display properties being removed.

**Returns:** True if remove successfully, false otherwise.

### DeprecateOverride(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Deprecated override.

- **`newObject`**: New object.
- **`deprecatedDisplayRepId`**: deprecated display representation id.
- **`oldDisplayRepId`**: old display representation id.

**Returns:** Object id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
