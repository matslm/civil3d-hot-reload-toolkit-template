---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionGraphic
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertyDefinitionGraphic
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionGraphic

## Summary
Represents a graphic property definition.

## Remarks
Graphic property values can be blocks in the current drawing or image files, such as BMP, GIF, JPG, PNG, or TIF.

## Properties

### GraphicType
Gets or sets the graphic type.

**Returns:** Returns the graphic type.

### BlockName
Gets or sets the block name.

**Returns:** Returns the block name.

### BlockId
Gets or sets the object id of the block to which it references.

**Returns:** Returns the object id of the block to which it references.

### ImageFileName
Gets or sets the image file name.

**Returns:** Returns the image name.

### ImageFileNameStripped
Gets the stripped image file name.

**Returns:** Returns the stripped image name.

### LayerKey
Gets or sets the layer key.

**Returns:** Returns the layer key.

### Rotation
Gets or sets the rotation.

**Returns:** Returns the rotation.

### UsePropertyDefinitionNamesForDescription
Gets or sets whether the property definition names, to which it references, should be used for description.

**Returns:** Returns whether the property definition names, to which it references, should be used for description.

### SupportedImageTypes
Gets the supported image types.

**Returns:** Returns the supported image types.

## Methods

### #ctor
Initializes a new instance of the PropertyDefinitionGraphic class.

### SetImageFileName(System.String,System.String)
Sets the image name.

- **`fileName`**: The image name.
- **`fileNameStripped`**: The stripped image name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetDisplayString(Autodesk.Aec.PropertyData.DatabaseServices.GraphicType)
Gets the display string of the specified graphic type.

- **`type`**: The specified graphic type.
