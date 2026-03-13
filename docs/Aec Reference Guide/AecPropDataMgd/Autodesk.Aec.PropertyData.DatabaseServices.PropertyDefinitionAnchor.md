---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionAnchor
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertyDefinitionAnchor
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionAnchor

## Summary
Represents an anchor property definition.

## Remarks
Anchor property definitions allow one object to get data from another object to which it is anchored.

## Properties

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
Initializes a new instance of the PropertyDefinitionAnchor class.

### ExtractAnchoredToObject(Autodesk.Aec.DatabaseServices.Geo)
Extracts the object id of the anchored to object.

- **`geo`**: The anchored to object.

**Returns:** The object id of the anchored to object.
