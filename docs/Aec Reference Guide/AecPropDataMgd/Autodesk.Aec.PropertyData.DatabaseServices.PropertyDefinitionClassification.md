---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionClassification
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertyDefinitionClassification
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionClassification

## Summary
Represents a classification property definition.

## Remarks
Including classifications or classification properties in a property set definition for schedules enables you to report classification data for the objects in a schedule table.

## Properties

### ClassificationDefinitionId
Gets or sets the object id of the classification definition to which it references.

**Returns:** Returns the object id of the classification definition to which it references.

### PropertySetDefinitionId
Gets or sets the object id of the property set definition to which it references.

**Returns:** Returns the object id of the property set definition to which it references.

### PropertyDefinitionId
Gets or sets the id of the property definition inside the property set definition to which it references.

**Returns:** Returns the id of the property definition inside the property set definition to which it references.

### UseClassificationNamesForDescription
Gets or sets whether the classification definition names, to which it references, should be used for description.

**Returns:** Returns whether the classification definition names, to which it references, should be used for description.

### Valid
Gets whether this property definition is valid.

**Returns:** Returns whether this property definition is valid.

## Methods

### #ctor
Initializes a new instance of the PropertyDefinitionClassification class.
