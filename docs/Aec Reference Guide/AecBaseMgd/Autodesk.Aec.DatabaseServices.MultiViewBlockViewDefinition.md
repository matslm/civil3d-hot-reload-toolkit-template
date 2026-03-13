---
title: Autodesk.Aec.DatabaseServices.MultiViewBlockViewDefinition
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > MultiViewBlockViewDefinition
---

# Autodesk.Aec.DatabaseServices.MultiViewBlockViewDefinition

## Summary
Represents a multi view block view definition.

## Remarks
This class represents viewing flags and the block id for a single block definition of a multi-view block. The blockId must point to a BlockTableRecord. The viewing flags should be one of the values of the ViewDirection enum.

## Properties

### BlockId
Gets or sets the id of the BlockTableRecord.

**Returns:** Returns the id of the BlockTableRecord.

### AttributeGripsDisabled
Gets the state of the attribute grips.

**Returns:** true if grip points are disabled for all attribute definitions within this block def, false otherwise.

## Methods

### #ctor
Initializes a new instance of the MultiViewBlockViewDefinition class.

### IsViewOn(Autodesk.Aec.DatabaseServices.ViewDirection)
Returns true if the passed in view direction is turned on.

- **`viewDirectionType`**: The view direction.

**Returns:** Returns true if the passed in view direction is turned on, false otherwise.

### SetViewOn(Autodesk.Aec.DatabaseServices.ViewDirection,System.Boolean)
Allows turning on/off the given view direction.

- **`viewDirectionType`**: The view direction.
- **`isOn`**: true to turn the view on, false to turn it off.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAllViews(System.Boolean)
Allows turning on/off all the view directions available.

- **`isOn`**: true to turn the views on, false to turn them off.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
