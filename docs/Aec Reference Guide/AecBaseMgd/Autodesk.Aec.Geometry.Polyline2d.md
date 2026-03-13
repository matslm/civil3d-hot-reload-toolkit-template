---
title: Autodesk.Aec.Geometry.Polyline2d
hierarchy: AecBaseMgd > Autodesk > Aec > Geometry > Polyline2d
---

# Autodesk.Aec.Geometry.Polyline2d

## Summary
Represents a polyline 2d.

## Methods

### #ctor
Initializes a new instance of the Polyline2d class.

### ClipStart(Autodesk.AutoCAD.Geometry.Line2d)
Sets the start clip line.

- **`clipLine`**: Line2d that intersects the Polyline2d.

### ClipEnd(Autodesk.AutoCAD.Geometry.Line2d)
Sets the end clip line.

- **`clipLine`**: Line2d that intersects the Polyline2d.

### GetBefore(System.Double)
Returns a Polyline2d before passed in distance.

- **`endDistanceAlong`**: Distance along the Polyline2d.

**Returns:** A Polyline2d from the start point to the specified distance.

### GetBefore(Autodesk.AutoCAD.Geometry.Point2d)
Returns a Polyline2d before passed in point.

- **`endPoint`**: Point2d on the Polyline2d.

**Returns:** A Polyline2d from the start point to the specified end point.

### GetBefore(Autodesk.AutoCAD.Geometry.Curve2d)
Returns a Polyline2d before intersection of polyline with passed in curve.

- **`endClip`**: Curve2d that intersects the Polyline2d.

**Returns:** A Polyline2d from the start point to the intersection of the specified Curve2d.

### GetBefore(System.Int32,System.Double)
Returns a Polyline2d before passed in parameter.

- **`endIndex`**: Segment number.
- **`endParameter`**: Parameter value.

**Returns:** A Polyline2d from the start point to the specified parameter.

### GetAfter(System.Double)
Returns a Polyline2d after passed in distance.

- **`startDistanceAlong`**: Distance along the Polyline2d.

**Returns:** A Polyline2d from the specified distance to the end point.

### GetAfter(Autodesk.AutoCAD.Geometry.Point2d)
Returns a Polyline2d after passed in distance.

- **`startPoint`**: Point2d on the Polyline2d.

**Returns:** A Polyline2d from the specified start point to the end point.

### GetAfter(Autodesk.AutoCAD.Geometry.Curve2d)
Returns a Polyline2d after intersection of polyline with passed in curve.

- **`startClip`**: Curve2d that intersects the Polyline2d.

**Returns:** A Polyline2d from the intersection of the specified Curve2d to the end point.

### GetAfter(System.Int32,System.Double)
Returns a Polyline2d after passed in parameter.

- **`startIndex`**: Segment number.
- **`startParameter`**: Parameter value.

**Returns:** A Polyline2d from the specified parameter to the end point.
