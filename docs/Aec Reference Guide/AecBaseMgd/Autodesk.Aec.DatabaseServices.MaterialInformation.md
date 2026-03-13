---
title: Autodesk.Aec.DatabaseServices.MaterialInformation
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > MaterialInformation
---

# Autodesk.Aec.DatabaseServices.MaterialInformation

## Summary
This class stores material information.

## Properties

### ComponentName
Gets or sets the component name of the material information.

**Returns:** The component name of the material information.

### MaterialId
Gets the object id of the material.

**Returns:** The object id of the material.

### MaterialId(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Sets the object id of the specified material.

- **`id`**: The object id of the specified material.

## Methods

### Create
Creates a new instance of the MaterialInformation class.

### #ctor
Initializes a new instance of the MaterialInformation class.

### #ctor(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.String,System.Int32,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int16,System.Boolean)
Initializes a new instance of the MaterialInformation class using the specified material, component name, location id, location style and component id.

- **`materialId`**: The specified material id.
- **`componentName`**: The specified component name.
- **`locationId`**: The specified location id.
- **`locationStyleId`**: The object id of the specified location style.
- **`componentId`**: The specified component id.
- **`isFromObjectOverride`**: The boolean value indicates if it is from the overrided object.

### CopyTo(Autodesk.Aec.DatabaseServices.MaterialInformation)
Copies itself to the specified material information.

- **`information`**: The specified material information.
