---
title: Autodesk.Aec.DatabaseServices.DisplayComponentPushPopData
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplayComponentPushPopData
---

# Autodesk.Aec.DatabaseServices.DisplayComponentPushPopData

## Summary
Represents a data class to store the infomation about the location of display properties.

## Properties

### MaterialId
Gets or sets the object id of the material.

**Returns:** The object id of the material.

### HasMaterial
Gets the boolean value to indicate if the data object contains material informations.

**Returns:** The boolean value indicates if the data object contains material informations.

### DisplayComponentName
Gets or sets the display component name.

**Returns:** The display component name.

### HasName
Gets the boolean value to indicate if the data object has its name.

**Returns:** The boolean value indicates if the data object has its name.

### DisplayComponentEntity
Gets or sets the display component entity.

**Returns:** The display comonent entity.

### MaterialInformation
Gets or sets the material information of the data object.

**Returns:** The material information of the data object.

## Methods

### #ctor
Initializes a new instance of the DisplayComponentPushPopData class.

### #ctor(Autodesk.Aec.DatabaseServices.DisplayComponentEntity)
Initializes a new instance of the DisplayComponentPushPopData class using the specified display component entity.

- **`entity`**: The specified display component entity.

### #ctor(Autodesk.Aec.DatabaseServices.DisplayComponentEntity,System.String)
Initializes a new instance of the DisplayComponentPushPopData class using the specified display component entity and the component name.

- **`entity`**: The specified display component entity.
- **`componentName`**: The specified component name.

### SetDisplayComponentData(Autodesk.Aec.DatabaseServices.DisplayComponentEntity,System.String)
Sets the display component data.

- **`entity`**: The specified display component entity.
- **`name`**: The specified name.

### SetMaterialDisplayComponentData(Autodesk.Aec.DatabaseServices.DisplayComponentEntity,System.String)
Sets the material display component data.

- **`entity`**: The specified display component entity.
- **`strName`**: The specified name.
