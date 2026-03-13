---
title: Autodesk.Aec.DatabaseServices.ProfileDefinition
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ProfileDefinition
---

# Autodesk.Aec.DatabaseServices.ProfileDefinition

## Summary
Represents a profile definition.

## Properties

### Profile
Gets a copy of the profile.

**Returns:** Returns a copy of the profile.

### InsertionPoint
Gets or sets the insertion point.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ExtrusionDirection
Gets or sets the extrusion direction.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

## Methods

### #ctor
Initializes a new instance of the ProfileDefinition class.

### SetProfile(Autodesk.Aec.Geometry.Profile,System.Boolean,Autodesk.AutoCAD.Geometry.Point2d)
Sets the profile.

- **`profileToCopy`**: The profile to copy.
- **`translateInsertion`**: If true, translate the insertion point by the vector defined by from the top left to bottom right of the extents.
- **`insertionPoint`**: The insertion point.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CalculateSegmentPositions(Autodesk.Aec.Geometry.ProfileExtrusionDirection)
Calculates the segment positions.

- **`direction`**: The extrusion direction.

### ModifySegmentPositions(Autodesk.Aec.Geometry.SegmentPosition,Autodesk.Aec.Geometry.SegmentPosition)
Modifies the segments positions.

- **`oldPosition`**: The old segment position.
- **`newPosition`**: The new segment position.

### ModifySegmentPositions(Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.ProfileExtrusionDirection)
Modifies the segments positions.

- **`oldDirection`**: The old extrusion direction.
- **`newDirection`**: The new extrusion direction.
