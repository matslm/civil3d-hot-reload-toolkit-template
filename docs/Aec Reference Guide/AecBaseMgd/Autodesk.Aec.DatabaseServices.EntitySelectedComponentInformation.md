---
title: Autodesk.Aec.DatabaseServices.EntitySelectedComponentInformation
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > EntitySelectedComponentInformation
---

# Autodesk.Aec.DatabaseServices.EntitySelectedComponentInformation

## Summary
Represents a component information of the selected entity.

## Properties

### DisplayComponentName
Gets or sets the name of the display component.

### DisplayPropertiesId
Gets or sets the object id of the specified display properties.

### DisplayRepresentationId
Gets or sets the object id of the specified display representation.

### ViewportId
Gets or sets the object id of the specified viewport.

### ViewportNumber
Gets or sets the number of the viewport.

### MaterialDisplayPropertiesId
Gets or sets the specified object id of the material display properties.

### MaterialDisplayRepresentationId
Gets or sets the specified object id of the material display representation.

### MaterialInformation
Gets or sets the specified material information.

### HasMaterialInformation
Gets or sets the boolean value to indicate if the component has the material information.

### CurrentByMaterialStatus
Gets or sets the boolean value to indicate if the current material is in the ByMaterial status.

### ComponentName
Gets the component name.

**Returns:** The component name.

### DisplayProperties
Gets the object id of the display properties.

**Returns:** The object id of the display properties.

### DisplayedDrawingDefaultWarningMessage
Gets or sets the boolean value to indicate if a warning message should be displayed when display properties are modified at the drawing default level.

### DisplayedStyleOverrideWarningMessage
Gets or sets the boolean value to indicate if a warning message should be displayed when display properties are modified at the style override level.

### DisplayedSystemOverrideWarningMessage
Gets or sets the boolean value to indicate if a warning message should be displayed when display properties are modified at the system override level.

### DisplayedMaterialWarningMessage
Gets or sets the boolean value to indicate if a warning message should be displayed when the material definitions are modified.

## Methods

### #ctor
Initializes a new instance of the EntitySelectedComponentInformation class.

### #ctor(System.String,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.MaterialInformation)
Initializes a new instance of the EntitySelectedComponentInformation class using the specified component information, viewport and material information.

- **`displayComponentName`**: The name of the specified component.
- **`displayPropertiesId`**: The object id of the specified component display properties.
- **`displayRepresentationId`**: The object id of the specified component display representation.
- **`viewportId`**: The obejct id of the viewport.
- **`viewportNumber`**: The number of the viewport.
- **`materialDisplayPropertiesId`**: The object id of the specified material display properties.
- **`materialDisplayRepresentationId`**: The object id of the specified material display representation.
- **`materialInformation`**: The specified material information.
