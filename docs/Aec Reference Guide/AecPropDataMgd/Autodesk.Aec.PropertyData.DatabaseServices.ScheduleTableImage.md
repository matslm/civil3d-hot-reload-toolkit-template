---
title: Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableImage
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > ScheduleTableImage
---

# Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableImage

## Summary
Represents a schedule table image.

## Methods

### #ctor
Initializes a new instance of the ScheduleTableImage class.

### AddImageDefinition(System.String,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Add image definition.

- **`filename`**: The file name.
- **`definitionId`**: The definition id.

### FindImageDefinition(System.String)
Find the image definition.

- **`filename`**: The file name.

**Returns:** The image definition id.

### AddImage(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Add image.

- **`imageId`**: The image id.

**Returns:** True if found, false otherwise.
