---
title: Autodesk.Aec.DatabaseServices.GsMarkerDisplayRepresentationInformationNode
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GsMarkerDisplayRepresentationInformationNode
---

# Autodesk.Aec.DatabaseServices.GsMarkerDisplayRepresentationInformationNode

## Summary
Represents a node of the GsMarker information related to the display represetation.

## Properties

### DisplayRepresentationId
Gets or sets the object id of the display representation.

**Returns:** The object id of the display representation.

### DisplayPropertiesId
Gets or sets the object id of the display properties.

**Returns:** The object id of the display properties.

## Methods

### #ctor
Initializes a new instance of the GsMarkerDisplayRepresentationInformationNode class.

### #ctor(Autodesk.Aec.DatabaseServices.GsMarkerInformationTree,Autodesk.Aec.DatabaseServices.GsMarkerInformationNode)
Initializes a new instance of the GsMarkerDisplayRepresentationInformationNode class using the specified display representation, parent tree and parent node.

- **`displayRepresentationId`**: The object id of the specified display representation.
- **`parentTree`**: The specified parent tree.
- **`parentNode`**: The specified parent node.

### SetDisplayPropertiesInformation(Autodesk.Aec.DatabaseServices.DisplayProperties)
Sets the information of the display properties.

- **`properties`**: The information of the display properties.

### ResetTransientDisplayPropertiesInformation
Resets the information of the transient display properties.

### GetDisplayComponentName(Autodesk.Aec.DatabaseServices.DisplayComponentEntity)
Gets the name of the spcified display component.

- **`component`**: The specified component.

**Returns:** The name of the spcified display component.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: The exception is thrown if the name of the component is not found.

### GetDisplayComponentId(Autodesk.Aec.DatabaseServices.DisplayComponentEntity)
Gets the id of the display component.

- **`component`**: The specified component.

**Returns:** The id of the spcified display component.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: The exception is thrown if the id of the component is not found.
