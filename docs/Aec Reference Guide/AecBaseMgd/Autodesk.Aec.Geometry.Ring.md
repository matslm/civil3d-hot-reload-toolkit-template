---
title: Autodesk.Aec.Geometry.Ring
hierarchy: AecBaseMgd > Autodesk > Aec > Geometry > Ring
---

# Autodesk.Aec.Geometry.Ring

## Summary
Represents a ring.

## Properties

### Void
Sets the IsVoid property.

**Remarks:**
A void ring has a negative area.

### IsValidRing
Specifies if the ring is valid.

**Returns:** Returns true if the ring is valid.

### IsVoid
Specifies if the ring is void.

**Returns:** Returns the IsVoid property.

**Remarks:**
A void ring has a negative area.

### Area
Specifies the area of the ring.

**Returns:** Returns the area of the ring.

### Centroid
Specifies the centroid of the ring.

**Returns:** Returns the centroid of the ring.

### IsCircle
Specifies if the ring is a circle.

**Returns:** Returns true if the ring is a circle.

### Segments
Returns the segment collection.

**Returns:** Returns the segment collection.

## Methods

### #ctor
Initializes a new instance of the Ring class.

### #ctor(Autodesk.AutoCAD.Geometry.Point2dCollection)
Initializes a new instance of the Ring class using the specified point collection.

- **`points`**: The points defining the ring.

### Create(System.IntPtr,System.Boolean)
Creates a wrapper class for Ring.

### PointInRing(Autodesk.AutoCAD.Geometry.Point2d)
Determines if the specified point is in the ring.

- **`point`**: The test point.

**Returns:** Returns PointOnVoidRing, PointOnRing, PointOutsideRing, PointOutsideRing or kPointInRing.

### IsContainedBy(Autodesk.Aec.Geometry.Ring)
Determines if the ring is contained by the specified ring.

- **`otherRing`**: The other ring.

**Returns:** Returns true if the ring is contained by the specified ring.

### GetExtrusion(Autodesk.AutoCAD.Geometry.Vector3d,System.Double,System.Int32)
Calculates an extruded body from the ring.

- **`direction`**: The extrusion direction.
- **`deviation`**: The facet deviation.
- **`maxFacetsPerSegment`**: The maximum number of facets per segment.

**Returns:** Returns an extruded body from the ring.

### GetFace(System.Double,System.Int32)
Calculates a face from the ring.

- **`deviation`**: The facet deviation.
- **`maxFacetsPerSegment`**: The maximum number of facets per segment.

**Returns:** Returns a face from the ring.

### IsTopologicallyEquivalent(Autodesk.Aec.Geometry.Ring,System.Int32@)
Determines if the ring can be mapped to another ring.

- **`otherRing`**: The other ring.
- **`offset`**: The offset to get the rings to line up.

**Returns:** Returns true if the ring can be mapped to another ring.

### CalculateSegmentPositions(Autodesk.Aec.Geometry.ProfileExtrusionDirection,System.Boolean)
Calculates the position of each segment in the ring.

- **`extrusionDirection`**: Determines the segment position.
- **`calculateOnlyForNonMarked`**: Determines if marked rings are calculated.

### CalculateSegmentPositions(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,System.Boolean)
Calculates the position of each segment in the ring.

- **`topLeft`**: Defines the quadrant lines.
- **`bottomRight`**: Defines the quadrant lines.
- **`extrusionDirection`**: Determines the segment position.
- **`calculateOnlyForNonMarked`**: Determines if marked rings are calculated.

### ModifySegmentPositions(Autodesk.Aec.Geometry.SegmentPosition,Autodesk.Aec.Geometry.SegmentPosition)
Updates the specified segment positions of each segment of the ring.

- **`oldSegmentPosition`**: The current segment position.
- **`newSegmentPosition`**: The desired segment position.

### ModifySegmentPositions(Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.ProfileExtrusionDirection)
Updates the specified segment positions of each segment of the ring.

- **`oldExtrusionDirection`**: The current extrusion direction.
- **`newExtrusionDirection`**: The desired extrusion direction.

### MirrorSegmentPositions
Mirrors each segment of the ring.
