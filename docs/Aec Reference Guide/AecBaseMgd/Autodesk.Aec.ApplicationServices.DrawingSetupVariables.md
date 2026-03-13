---
title: Autodesk.Aec.ApplicationServices.DrawingSetupVariables
hierarchy: AecBaseMgd > Autodesk > Aec > ApplicationServices > DrawingSetupVariables
---

# Autodesk.Aec.ApplicationServices.DrawingSetupVariables

## Summary
Represents the drawing setup variables.

## Properties

### UnitType
Gets the unit type.

**Returns:** Returns the unit type.

### ScaleOnInsert
Gets or sets the scale on insert setting.

**Returns:** Returns the scale on insert setting.

### LinearUnit
Gets or sets the linear unit.

**Returns:** Returns the linear unit.

### LinearDisplayFormat
Gets or sets the linear display format.

**Returns:** Returns the linear display format.

**Remarks:**
1:Scientific, 2:Decimal, 3:Engineering, 4:Architectural, 5:Fractional.

### LinearPrecision
Gets or sets the linear precision.

**Returns:** Returns the linear precision.

**Remarks:**
Specifies the number of digits to the right of the decimal point.

### AngularDisplayFormat
Gets or sets the angular display format.

**Returns:** Returns the angular display format.

**Remarks:**
0:Decimal degrees, 1:Degrees/minutes/seconds, 2:Gradians, 3:Radians, 4:Surveyor's units.

### AngularAzimuth
Gets or sets the angular azimuth.

**Returns:** Returns the angular azimuth.

**Remarks:**
0:Use Bearings, 1:Use North Azimuths, 2:Use South Azimuths.

### AngularPrecision
Gets or sets the angular precision.

**Returns:** Returns the angular precision.

**Remarks:**
Specifies the number of digits to the right of the decimal point.

### ElevationPrecision
Gets or sets the elevation precision.

**Returns:** Returns the elevation precision.

**Remarks:**
Specifies the number of digits to the right of the decimal point.

### CoordinatePrecision
Gets or sets the coordinate precision.

**Returns:** Returns the coordinate precision.

**Remarks:**
Specifies the number of digits to the right of the decimal point.

### AecDwgBasePt
Gets or sets the drawing base point as XYZ in WCS.

**Returns:** Returns the drawing base point as XYZ in WCS.

**Remarks:**
This is a civil engineering variable.

### AecBasePtNE
Gets or sets the base point as ENZ in WCS.

**Returns:** Returns the base point as ENZ in WCS.

**Remarks:**
This is a civil engineering variable.

### AecNorthRotation
Gets or sets the north rotation as an angle in radians measured counter-clockwise from the X axis (East).

**Returns:** Returns the north rotation.

**Remarks:**
This is a civil engineering variable.

### DwgScale
Gets or sets the drawing scale.

**Returns:** Returns the drawing scale.

### VerticalScale
Gets or sets the vertical scale.

**Returns:** Returns the vertical scale.

**Remarks:**
This is a civil engineering variable.

### TextHeight
Gets or sets the text height.

**Returns:** Returns the text height.

### AreaDisplayUnit
Gets or sets the area display unit.

**Returns:** Returns the area display unit.

### AreaPrecision
Gets or sets the area precision.

**Returns:** Returns the area precision.

**Remarks:**
Specifies the number of digits to the right of the decimal point.

### AreaSuffix
Gets or sets the area suffix.

**Returns:** Returns the area suffix.

### VolumeDisplayUnit
Gets or sets the volume display unit.

**Returns:** Returns the volume display unit.

### VolumePrecision
Gets or sets the volume precision.

**Returns:** Returns the volume precision.

**Remarks:**
Specifies the number of digits to the right of the decimal point.

### VolumeSuffix
Gets or sets the volume suffix.

**Returns:** Returns the volume suffix.

### CivilStateFlag1
Gets or sets the civil state flag 1.

**Returns:** Returns the civil state flag 1.

**Remarks:**
This is a civil engineering variable.

### CivilStateFlag2
Gets or sets the civil state flag 2.

**Returns:** Returns the civil state flag 2.

**Remarks:**
This is a civil engineering variable.

### CivilStateFlag3
Gets or sets the civil state flag 3.

**Returns:** Returns the civil state flag 3.

**Remarks:**
This is a civil engineering variable.

### CivilDimaltd
Gets or sets the civil DIMALTD variable.

**Returns:** Returns the civil DIMALTD variable.

**Remarks:**
This is a civil engineering variable.

### CivilTextStyle
Gets or sets the civil text style.

**Returns:** Returns the civil text style.

**Remarks:**
This is a civil engineering variable.

### CivilDimpost
Gets or sets the civil DIMPOST variable.

**Returns:** Returns the civil DIMPOST variable.

**Remarks:**
This is a civil engineering variable.

### CivilDimapost
Gets or sets the civil DIMAPOST variable.

**Returns:** Returns the civil DIMAPOST variable.

**Remarks:**
This is a civil engineering variable.

### CivilDimexo
Gets or sets the civil DIMEXO variable.

**Returns:** Returns the civil DIMEXO variable.

**Remarks:**
This is a civil engineering variable.

### CivilDimscale
Gets or sets the civil DIMSCALE variable.

**Returns:** Returns the civil DIMSCALE variable.

**Remarks:**
This is a civil engineering variable.

### CivilDimaltf
Gets or sets the civil DIMALTF variable.

**Returns:** Returns the civil DIMALTF variable.

**Remarks:**
This is a civil engineering variable.

### ProjectName
Gets or sets the project name.

**Returns:** Returns the project name.

### LayerStandard
Gets or sets the layer standard.

**Returns:** Returns the layer standard.

### LayerStandardLegacy
Gets the layer standard legacy.

**Returns:** Returns the layer standard legacy.

### IsMetric
Specifies if the drawing uses Metric units.

**Returns:** Returns true if the drawing uses Metric units.

### FacetDeviation
Gets or sets the facet deviation.

**Returns:** Returns the facet deviation.

### MaxFacetsOnCircle
Gets or sets the maximum facets on circle.

**Returns:** Returns the maximum facets on circle.

### LayerFile
Gets or sets the layer file. It is retrieved via the registry and therefore will not change via assignment until the SaveAsDefault function is called.

**Returns:** Returns the layer file.

### SuperScript
Gets or sets the super script.

**Returns:** Returns the super script.

### SuperScriptZeroSupression
Gets or sets the super script zero supression setting.

**Returns:** Returns the super script zero supression setting.

### ElevationLabelPlus
Gets or sets the elevation label plus setting.

**Returns:** Returns the elevation label plus setting.

### ElevationLabelPlusMinus
Gets or sets the elevation label plus minus setting.

**Returns:** Returns the elevation label plus minus setting.

### CurrentDimUnit
Gets or sets the current dimension unit.

**Returns:** Returns the current dimension unit.

### LastLayerStyleUpdate
Gets the last layer style update setting.

**Returns:** Returns the last layer style update setting.

### AlwaysUpdateLayerKeyStyle
Gets or sets the always update layer key style.

**Returns:** Returns the always update layer key style.

### CreateDimOverride
Gets or sets the create dimension override setting.

### XrefOverlaysUseOwnDisplayConfig
Gets or sets the xref overlays use own display configuration setting.

### BlockBasedLayerOffBehavior
Gets or sets the block based layer off behavior setting.

**Returns:** Returns the block based layer off behavior setting.

### GeometrySharingEnabled
Gets or sets whether the geometry share function is enabled.

## Methods

### #ctor
Initializes a new instance of the DrawingSetupVariables class.

### ConvertToCurrentAreaDisplay(System.Double)
Converts the value using the current area display unit.

- **`area`**: The area.

**Returns:** Returns the value converted using the current area display unit.

### ConvertToCurrentVolumeDisplay(System.Double)
Converts the value using the current volume display unit.

- **`volume`**: The volume.

**Returns:** Returns the value converted using the current volume display unit.

### SaveAsDefault
Saves the drawing setup variables are the default.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetInstance(Autodesk.AutoCAD.DatabaseServices.Database,System.Boolean)
Gets the drawing setup variables for the specified database.

- **`db`**: The database.
- **`createIfNotFound`**: Determines if the drawing setup variables are created if not found.

**Returns:** Returns the drawing setup variables for the specified database.
