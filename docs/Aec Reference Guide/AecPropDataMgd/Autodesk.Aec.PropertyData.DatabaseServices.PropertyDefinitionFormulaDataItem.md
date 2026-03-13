---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionFormulaDataItem
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertyDefinitionFormulaDataItem
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionFormulaDataItem

## Summary
Represents the data of an item inside formula property definition.

## Remarks
The PropertyDefinitionFormula class parses formula string and create a map between the positions of the referenced property and formula data items. By saying position, let's take a look at this example. Say we have a formula string "[A]*[B]". In this formula string, we reference property A and B. And then we calculate the product of the two properties. First we take the "[A]" out of the formula string and create a formula data item which indicates we are referencing property A. And then we mark the position of the newly created formula data item with zero. Then we handle property B with position 1. Finally we save the formula string as "*".  By accessing the formula data item, you can control the sample value of an item. If the item is a property, which you can tell by accessing the IsProperty property, you can specify the format of it by accessing FormatId property.

## Properties

### IsQuantity
Gets whether this data item is a quantity item.

**Returns:** Returns whether this data item is a quantity item.

### IsProperty
Gets whether this data item is a property item.

**Returns:** Returns whether this data item is a property item.

### Sample
Gets or sets the sample data.

**Returns:** Returns the sample data.

### FormatId
Gets or sets the property format id.

**Returns:** Returns the property format id.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

**Remarks:**
FormatId can only be applied to property data item which can be tell by checking the IsProperty property.

### DisplayString
Gets the display string of the data item.

**Returns:** Returns the display string of the data item.

- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

## Methods

### SetSampleToDefault
Sets the sample data to its default value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
