---
title: Autodesk.Aec.DatabaseServices.DisplayMaterialInformation
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplayMaterialInformation
---

# Autodesk.Aec.DatabaseServices.DisplayMaterialInformation

## Summary
Represents a class which stores material display related information.

## Properties

### LocationId
Gets or sets the locations id.

**Returns:** Returns the location id.

### LocationStyleId
Gets the location style id.

**Returns:** Returns the location style id.

### LocationStyleId(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Sets the location style id.

- **`id`**: Inputs the location style id.

### ComponentId
Gets or sets the component id.

**Returns:** Returns the component id.

### IsFromObjectOverride
Gets or sets to know whether is from object override.

**Returns:** True if it is from object override. Otherwise false.

### MaterialLocation
Gets the material information location.

**Returns:** Returns the material information location.

## Methods

### Create
Creates a new instance of the DisplayMaterialInformation class.

### #ctor
Initializes a new instance of the DisplayMaterialInformation class.

### #ctor(System.UInt32,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.UInt16,System.Boolean)
Initializes a new instance of the DisplayMaterialInformation class using the specified parameters.

- **`locationId`**: Inputs the location id.
- **`locationStyleId`**: Inputs the location sytle id.
- **`componentId`**: Input the component id.
- **`isFromObjectOverride`**: Inputs the value to indicate whether is from object override or not.

### Clone
Clones the current object.

**Returns:** Returns the newly cloned object.
