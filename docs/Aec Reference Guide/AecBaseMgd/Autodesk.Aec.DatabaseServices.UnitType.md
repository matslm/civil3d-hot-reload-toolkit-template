---
title: Autodesk.Aec.DatabaseServices.UnitType
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > UnitType
---

# Autodesk.Aec.DatabaseServices.UnitType

## Summary
Represents a unit type.

## Properties

### Status
Gets the status.

**Returns:** Returns the status.

### Type
Gets the type.

**Returns:** Returns the type.

### InternalName
Gets the internal name.

**Returns:** Returns  the internal name.

### IsMetric
Gets the value that indicates if the unit type is metric.

**Returns:** Returns the value that indicates if the unit type is metric.

### IsImperial
Gets the value that indicates if the unit type is imperial.

**Returns:** Returns the value that indicates if the unit type is metric.

## Methods

### #ctor
Initializes a new instance of the UnitType class.

### #ctor(Autodesk.Aec.BuiltInUnit,System.Int32)
Initializes a new instance of the UnitType class.

- **`type`**: The units.
- **`exponent`**: The exponent.

### #ctor(Autodesk.Aec.DatabaseServices.UnitType)
Initializes a new instance of the UnitType class.

- **`value`**: The unit type.

### IsCompatible(Autodesk.Aec.DatabaseServices.UnitType)
Check if the unit type is compatible with another unit type.

- **`value`**: The other unit type.

**Returns:** true, if compatible; false, otherwise.

### GetTypeDisplayName(System.Boolean)
Gets the type display name.

- **`getLocalized`**: true, to return the localized name; false, otherwise.

**Returns:** Returns the type display name.

### SingularName(System.Boolean)
Gets the singular name.

- **`getLocalized`**: true, to return the localized name; false, otherwise.

**Returns:** Returns the singular name.

### PluralName(System.Boolean)
Gets the plural name.

- **`getLocalized`**: true, to return the localized name; false, otherwise.

**Returns:** Returns the plural name.

### IsSimpleUnit(Autodesk.Aec.BuiltInUnit)
Gets the value that indicates if the unit type is simple.

- **`unit`**: The built in units.

**Returns:** Returns the value that indicates if the unit type is simple.
