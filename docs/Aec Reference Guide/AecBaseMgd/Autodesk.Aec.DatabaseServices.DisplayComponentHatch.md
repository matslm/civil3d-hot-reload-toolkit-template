---
title: Autodesk.Aec.DatabaseServices.DisplayComponentHatch
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplayComponentHatch
---

# Autodesk.Aec.DatabaseServices.DisplayComponentHatch

## Summary
Represents a display component hatch base class.

## Properties

### HatchType
Gets or sets hatch type.

**Returns:** Hatch type.

### PatternName
Gets or sets pattern name.

**Returns:** Pattern name.

### Scale
Gets or sets scale.

**Returns:** Scale.

### Angle
Gets or sets angle.

**Returns:** Angle.

### UseAngleOfObject
Gets or sets if it use angle of object.

**Returns:** True if it use angle of object, false otherwise.

### Spacing
Gets or sets spacing.

**Returns:** Spacing.

### UOffset
Gets or sets UOffset.

**Returns:** UOffset.

### VOffset
Gets or sets VOffset.

**Returns:** VOffset.

### IsDoubleHatch
Gets or sets if it is double hatch.

**Returns:** True if it is double hatch, false otherwise.

## Methods

### #ctor
Initializes a new instance of the DisplayComponentHatch class.

### SetHatchParams(Autodesk.AutoCAD.DatabaseServices.Hatch,System.Double,System.Double)
Sets hatch parameters.

- **`hatch`**: Hatch.
- **`angleOfObject`**: Angle of object.
- **`ucsXAngleOffset`**: Ucs X angle offset.

### SetHatchParamsToAcadSettings(Autodesk.AutoCAD.DatabaseServices.Hatch)
Set hatch parameters to acad settings.

- **`hatch`**: Hatch.

### ResetHatch
Reset hatch.
