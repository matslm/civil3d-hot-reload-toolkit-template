---
title: Autodesk.Aec.DatabaseServices.UnitVariable
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > UnitVariable
---

# Autodesk.Aec.DatabaseServices.UnitVariable

## Summary
Represents a unit variable.

## Properties

### Status
Gets the status.

**Returns:** Returns the status.

### Value
Gets or sets the value.

**Returns:** Returns the value.

### Type
Gets or sets the unit type.

**Returns:** Returns the unit type.

## Methods

### #ctor
Initializes a new instance of the UnitVar class.

### #ctor(System.Double,Autodesk.Aec.DatabaseServices.UnitType,System.Int32)
Initializes a new instance of the UnitVariable class.

- **`value`**: The value.
- **`type`**: The unit type.
- **`exponent`**: The exponent.

### #ctor(Autodesk.Aec.DatabaseServices.UnitVariable)
Initializes a new instance of the UnitVar class.

- **`unitVariable`**: The unit variable.

### Convert(Autodesk.Aec.DatabaseServices.UnitVariable,Autodesk.Aec.DatabaseServices.UnitType)
Converts the unit variable using the specified unit type.

- **`from`**: The unit variable.
- **`toUnit`**: The unit type.

**Returns:** Returns the resulting unit variable.

### ConvertTo(Autodesk.Aec.DatabaseServices.UnitType)
Converts the unit variable to the specified unit type.

- **`toUnit`**: The unit type.

**Returns:** The unit status.

### IsCompatible(Autodesk.Aec.DatabaseServices.UnitVariable)
Check if the unit variable is compatible with another unit variable.

- **`other`**: The other unit varable.

**Returns:** true, if compatible; false, otherwise.

### IsCompatible(Autodesk.Aec.DatabaseServices.UnitType)
Check if the unit variable is compatible with the specified unit type.

- **`type`**: The unit type.

**Returns:** true, if compatible; false, otherwise.
