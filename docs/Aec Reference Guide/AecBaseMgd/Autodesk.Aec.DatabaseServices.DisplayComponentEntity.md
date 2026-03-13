---
title: Autodesk.Aec.DatabaseServices.DisplayComponentEntity
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplayComponentEntity
---

# Autodesk.Aec.DatabaseServices.DisplayComponentEntity

## Summary
Represents a display component entity base class.

## Properties

### IsVisible
Gets or sets if it is visible.

**Returns:** True if it is visible, false otherwise.

### LayerId
Gets or sets layer id.

**Returns:** Layer id.

### Color
Gets or sets color.

**Returns:** Color.

### ColorIndex
Gets or sets color index.

**Returns:** Color index.

### LinetypeId
Gets or sets line type id.

**Returns:** Line type id.

### LineWeight
Gets or sets line weight.

**Returns:** Line weight.

### LinetypeScale
Gets or sets line type scale.

**Returns:** Line type scale.

### AllowByMaterial
Gets or sets if it is allow by material.

**Returns:** True if it is allow by material, false otherwise.

### ByMaterial
Gets or sets if it is by material.

**Returns:** True if it is by material, false otherwise.

## Methods

### #ctor
Initializes a new instance of the DisplayComponentEntity class.

### GetPlotStyleNameId()
Gets plot style name id. Please use it together with DisplayComponentEntity.GetPlotStyleNameType.

**Returns:** Plot style name id.

### GetPlotStyleNameType()
Gets plot style name type.  Please use it together with DisplayComponentEntity.GetPlotStyleNameId.

**Returns:** Plot style name type.

### SetPlotStyleName(Autodesk.AutoCAD.DatabaseServices.PlotStyleNameType,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Sets plot style name.

- **`type`**: Plot style name type.
- **`id`**: Plot style name id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetPlotStyleName(Autodesk.AutoCAD.DatabaseServices.PlotStyleNameType)
Sets plot style name.

- **`type`**: Plot style name type.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ResetEnt
Reset entity.
