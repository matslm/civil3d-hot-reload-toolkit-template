---
title: Autodesk.Aec.DatabaseServices.DisplaySet
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplaySet
---

# Autodesk.Aec.DatabaseServices.DisplaySet

## Summary
Represents a class that maintains a list of user definable display representations.

## Properties

### DisplayRepresentationIds
Gets the collection of display representation ids.

**Returns:** Returns the the collection of display representation ids.

### IsStandardSet
Gets to know whether this display set is standard or not.

**Returns:** True if this display set is standard, otherwise is false.

### HasLiveClippingBody
Gets to know whether this display set has live clipping body.

**Returns:** True if this display set has live clipping body, otherwise false.

### LiveSectionBody
Gets the live section body.

**Returns:** Returns the live section body.

### LiveSectionClipVolumes
Gets or sets the live section clip volumes.

### HasTransientLiveSectionBody
Gets to know whether this display set has transient live section body.

**Returns:** True if this display set has transient live section body, otherwise false.

### ClipModelGeometry
Gets or sets the model geometry to be clipped or not.

### ShowClippedMaterials
Gets or sets the display set to show clipped materials or not.

### DisableSurfaceHatching
Gets or sets to disable surface hatching or not.

### DisableSectionedBodyDisplay
Gets or sets the display set to disable section body display or not.

### ClassificationFilter
Gets the classification filter of the display set.

**Remarks:**
When there are no classifications present, an empty collection is provided that classification definition Ids can be added to.

## Methods

### #ctor
Initializes a new instance of the DisplaySet class.

### SetStandardType(Autodesk.Aec.DatabaseServices.StandardDisplaySetType,Autodesk.AutoCAD.DatabaseServices.Database)
Sets the standard type for the display set.

- **`type`**: Inputs the type.
- **`db`**: Inputs the database.

### GetStandardType
Gets the standard type for the display set.

**Returns:** Returns the standard type for the display set.

### WorksWith(Autodesk.AutoCAD.Runtime.RXClass)
Gets the display representation ids which are working with the specifed class.

- **`type`**: Inputs the RXClass type of the object.

**Returns:** Returns the display representation ids which are working with the specifed class.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetTransientLiveSectionBody
Sets the transient live section body.

### GetDisplayRangeSectionBody(Autodesk.Aec.DatabaseServices.DisplayConfiguration)
Gets the display range section body.

- **`configuration`**: Inputs the display configuration.

**Returns:** Returns the display range section body.

### GetCombinedDisplayRangeAndLiveSectionBody(Autodesk.Aec.DatabaseServices.DisplayConfiguration)
Gets combined display range and live section body with specified display configuration.

- **`configuration`**: Inputs the display configuration.

**Returns:** Returns combined display range and live section body with specified display configuration.

### UpdateMergedClassifications(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
?

- **`oldSystemDefinition`**: ?
- **`oldClassId`**: ?
- **`newSystemDefinition`**: ?
- **`newClassId`**: ?

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
