---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionLocation
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertyDefinitionLocation
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionLocation

## Summary
Represents a location property definition.

## Remarks
Location property values are obtained from property data on AEC polygons or spaces in or near an object.

## Properties

### AppliesTo
Gets or sets the class type to which this location property applies.

**Returns:** Returns the class type to which this location property applies.

### PropertySetDefinitionId
Gets or sets the object id of the property set definition to which it references.

**Returns:** Returns the object id of the property set definition to which it references.

### PropertyDefinitionId
Gets or sets the id of the property definition inside the property set definition to which it references.

**Returns:** Returns the id of the property definition inside the property set definition to which it references.

### UsePropertyDefinitionNamesForDescription
Gets or sets whether the property definition names, to which it references, should be used for description.

**Returns:** Returns whether the property definition names, to which it references, should be used for description.

### Valid
Gets whether this property definition is valid.

**Returns:** Returns whether this property definition is valid.

### DisplayString
Gets the display string.

**Returns:** Returns the display string.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

## Methods

### #ctor
Initializes a new instance of the PropertyDefinitionLocation class.

### SetAppliesTo(System.String)
Sets the class type to which this location property applies using the class name.

- **`className`**: The class name to which this location property applies.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
