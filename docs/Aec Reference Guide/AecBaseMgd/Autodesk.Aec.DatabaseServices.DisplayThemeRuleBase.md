---
title: Autodesk.Aec.DatabaseServices.DisplayThemeRuleBase
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplayThemeRuleBase
---

# Autodesk.Aec.DatabaseServices.DisplayThemeRuleBase

## Summary
Represents a display theme rule base class.

## Properties

### DisplayString
Gets display string.

### PropertyOwnerTypeName
Gets property owner type name.

**Returns:** Property owner type name.

### PropertyOwnerName
Gets or sets property owner name.

**Returns:** Property owner name.

### PropertyName
Gets or sets property name.

**Returns:** Property name.

### Units
Gets units.

**Returns:** Units.

### Precision
Gets Precision.

**Returns:** Precision.

### ComparisonOperator
Gets or sets comparision operator.

**Returns:** Operator.

### NextNodeOperator
Gets or sets next node operator.

**Returns:** Next node operator.

### DataType
Gets or sets data type.

**Returns:** Data type.

### ValueAsString
Gets value as string.

**Returns:** Value as string.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### FormattedValue
Gets formatted value.

**Returns:** Formatted value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Value
Set value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

## Methods

### GetCollectPropertyOwners()
Gets the collect properties owners.

**Returns:** The collect property owners .

### GetCollectProperties()
Gets the collect properties.

**Returns:** The collect property .

### GetCollectPropertiesDefaultIndex()
Gets the collect properties default index.

**Returns:** The collect properties default index,return -1 if can not find the default index.

### GetTrueFalseText(System.Boolean)
Get true false text.

- **`isFormatted`**: True if formatted, false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetCount
Gets the count of rule nodes.

### Add(Autodesk.Aec.DatabaseServices.DisplayThemeRuleBase)
Adds the display theme rule to the rule nodes collection.

- **`value`**: The display theme rule.

**Returns:** The index of the newly added node.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Insert(Autodesk.Aec.DatabaseServices.DisplayThemeRuleBase)
Inserts the display theme rule to the specified position of the rule nodes collection.

- **`index`**: The position.
- **`value`**: The display theme rule.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAt(System.Int32)
Gets the display theme rule at the specified position.

- **`index`**: The position.

**Returns:** The display theme rule.

### RemoveAt(System.Int32)
Removes the display theme rule at the specified position from the rule node collection.

- **`index`**: The position.

### RemoveAll
Removes all display theme rules from the rule node collection.

### Value()
Gets value.

- **`data`**: Value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SupportsEntity(Autodesk.Aec.DatabaseServices.Entity)
Check if supports entity.

- **`entity`**: Entity.

**Returns:** Ture if it supports, false otherwise.
