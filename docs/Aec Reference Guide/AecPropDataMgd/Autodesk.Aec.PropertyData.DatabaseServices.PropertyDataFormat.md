---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertyDataFormat
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertyDataFormat
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertyDataFormat

## Summary
Represents a ScheduleDataFormat.

## Properties

### Prefix
Gets or sets the prefix.

**Returns:** The prefix.

### Suffix
Gets or sets the suffix.

**Returns:** The suffix.

### Case
Gets or sets the case.

**Returns:** The case.

### Units
Gets or sets the units.

**Returns:** The units.

### Precision
Gets or sets the precision.

**Returns:** The precision.

### Separator
Gets or sets the separator.

**Returns:** The separator.

### Fraction
Gets or sets the fraction.

**Returns:** The fraction.

### LeadingZeros
Gets or sets if it is leading zeros.

**Returns:** True if it is leading zeros, false otherwise.

### TrailingZeros
Gets or sets if it is trailing zeros.

**Returns:** True if it is trailing zeros, false otherwise.

### ZeroFeet
Gets or sets if it is zero feet.

**Returns:** True if it is zero feet, false otherwise.

### ZeroInches
Gets or sets if it is zero Inches.

**Returns:** True if it is zero Inches, false otherwise.

### RoundOff
Gets or sets the round off.

**Returns:** The round off.

### ZeroPadding
Gets or sets the zero padding.

**Returns:** Zero padding.

### TrueText
Gets or sets the true text.

**Returns:** The true text.

### FalseText
Gets or sets the false text.

**Returns:** The false text.

### Undefined
Gets or sets the undefined string.

**Returns:** The undefined string.

### NotApplicable
Gets or sets the not applicable string.

**Returns:** The not applicable string.

### SeparatorComma
Gets or sets separator comma.

**Returns:** Separator comma.

### RoundingMode
Gets or sets rounding mode.

**Returns:** Rounding mode.

### Scale
Gets or sets scale.

**Returns:** The scale.

### UnitType
Gets or sets unit type.

**Returns:** The unit type.

### BuiltinType
Gets or sets built-in type.

**Returns:** Built-in type.

## Methods

### #ctor
Initializes a new instance of the PropertyDataFormat class.

### FormatToObject(System.Object)
Format to object.

- **`var`**: Format.

**Returns:** Object.

### FormatToObject(System.Object,Autodesk.Aec.DatabaseServices.UnitType)
Format to object.

- **`var`**: Format.
- **`unitType`**: The unit type.

**Returns:** Object.

### FormatObject(System.Object,System.Boolean)
Format object.

- **`var`**: Object.
- **`plainText`**: True if is plain text, false otherwise.

**Returns:** System.String.

### FormaObject(System.Object,Autodesk.Aec.DatabaseServices.UnitType,System.Boolean)
Format object.

- **`var`**: Object.
- **`unitType`**: Unit type.
- **`plainText`**: True if is plain text, false otherwise.

**Returns:** System.String.

### FormaObject(System.Object,Autodesk.AutoCAD.Runtime.ErrorStatus,System.Boolean)
Format object.

- **`var`**: The object.
- **`es`**: The error status.
- **`plainText`**: True if is plain text, false otherwise.

### FormaObject(System.Object,Autodesk.Aec.DatabaseServices.UnitType,Autodesk.AutoCAD.Runtime.ErrorStatus,System.Boolean)
Format object.

- **`var`**: The object.
- **`unitType`**: The unit type.
- **`es`**: The error status.
- **`plainText`**: True if is plain text, false otherwise.

### FormaObjectExtend(System.Object,System.Boolean)
Extend format object.

- **`var`**: Object.
- **`plainText`**: True if is plain text, false otherwise.

**Returns:** System.String.

### FormaObjectExtend(System.Object,Autodesk.Aec.DatabaseServices.UnitType,System.Boolean)
Extend format object.

- **`var`**: Object.
- **`unitType`**: Unit type.
- **`plainText`**: True if is plain text, false otherwise.

**Returns:** System.String.

### DoRoundOff(System.Double)
Do round off.

- **`value`**: ?

**Returns:** Double.

### FormatValues(Autodesk.AutoCAD.Runtime.ErrorStatus,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Object@,System.Object@)
Formats the specified property value retrieved from the property set based on the specified property data format and the error status returned when the property value was retrieved.

- **`readStatus`**: The Read status.
- **`idPropertyFormat`**: The Id property format.
- **`propValue`**: The property value.
- **`propFormatted`**: The property formatted.

**Returns:** True if the formatting was successful; false if values are "*Error getting value*", formatting could not be completed.

### FormatValues(Autodesk.AutoCAD.Runtime.ErrorStatus,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.UnitType,System.Object@,System.Object@)
Formats the specified property value retrieved from the property set based on the specified property data format and the error status returned when the property value was retrieved.

- **`readStatus`**: The read status.
- **`idPropertyFormat`**: The Id property format.
- **`unitType`**: The unit type.
- **`propValue`**: The property value.
- **`propFormatted`**: The property formatted.

**Returns:** True if the formatting was successful; false if values are "*Error getting value*", formatting could not be completed.

### ReadErrorValueMessage
Get read error value message.

**Returns:** Read error value message.

### Convert(System.Object,Autodesk.Aec.DatabaseServices.UnitType,Autodesk.Aec.DatabaseServices.UnitType)
Convert from one unit type to another unit type.

- **`data`**: The variant data.
- **`currentUnitType`**: The current unit type.
- **`targetUnitType`**: The target unit type.

**Returns:** System.Object.
