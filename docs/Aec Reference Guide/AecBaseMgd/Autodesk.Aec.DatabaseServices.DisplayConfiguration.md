---
title: Autodesk.Aec.DatabaseServices.DisplayConfiguration
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplayConfiguration
---

# Autodesk.Aec.DatabaseServices.DisplayConfiguration

## Summary
Represents a class of display configuration which maintains information about which display sets to use.

## Properties

### IsViewDependent
Gets or sets to know whether this display configuration is view dependent.

**Returns:** True if this display representation is view dependent, otherwise false.

### DefaultViewDependentViewSet
Gets or sets the default view dependent display set.

**Returns:** Returns the object id of the display set.

### ViewDependentCombinations
Gets the collection of view dependent combinations, each of them is consisting of display set and view direction vector.

**Returns:** Returns the collection of view dependent combinations.

### HardViewSet
Gets or sets the hardwired display set which is regardless of the current viewing direction.

**Returns:** Returns the hardwired display set which is regardless of the current viewing direction.

### UseViewportViewDirection
Gets or sets to know whether this display configuration is using viewport view direction or not.

**Returns:** True if  this display configuration is using viewport view direction, otherwise false.

### HardViewDirection
Gets or sets the hard view direction vector.

**Returns:** Returns the hard view direction vector.

### HardViewDirectionType
Gets or sets the hard view direction type.

**Returns:** Returns the hard view direction type.

### StateIcon
Gets the state icon of display configuration.

**Returns:** Returns the state icon of display configuration.

### StateImageIndex
Gets the state image index.

**Returns:** Returns the state image index.

### CutPlaneOffsetFromWcsZero
Gets or sets the cut plane offset from WcsZero.

### CutPlaneAboveRange
Gets or sets the value of above range of cut plane.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CutPlaneBelowRange
Gets or sets the value of below range of cut plane.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DisplayTheme
Gets the display theme attached to display configuration.

**Returns:** Returns the display theme attached to display configuration.

## Methods

### #ctor
Initializes a new instance of the DisplayConfiguration class.

### FindViewDependentViewSet(Autodesk.AutoCAD.Geometry.Vector3d)
Finds the view-dependent view set.

- **`direction`**: The direction.

**Returns:** The index of the view set but -1 if can't find anything.

### ResolveViewSet(Autodesk.AutoCAD.Geometry.Vector3d)
Looks up the view dependent display set or hard view set for the specified viewport direction.

- **`viewportDirection`**: Inputs the viewport direction.

**Returns:** Returns the view dependent display set or hard view set for the specified viewport direction.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetStateIcon(Autodesk.Aec.DatabaseServices.DisplayConfigurationImageIndex)
Gets the state icon of display configuration with specified image index.

- **`index`**: Inputs the image index of display configuration.

**Returns:** Gets the state icon of display configuration.

### AttachDisplayTheme(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Attaches the display theme to the display configuration.

- **`themeId`**: Inputs the display theme object id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DetachDisplayTheme
Detaches the display theme.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ViewDirectionTypeToVector(Autodesk.Aec.DatabaseServices.ViewDirection)
Gets the direction vector  for specified view direction type.

- **`type`**: Inputs the view direction type.

**Returns:** Returns the direction vector  for specified view direction type.

### VectorToViewDirectionType(Autodesk.AutoCAD.Geometry.Vector3d)
Gets the view direction type for specified vector.

- **`direction`**: Inputs the direction vector.

**Returns:** Returns the view direction type for specified vector.
