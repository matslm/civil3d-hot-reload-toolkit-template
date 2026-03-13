---
title: Autodesk.Aec.Geometry.Segment2d
hierarchy: AecBaseMgd > Autodesk > Aec > Geometry > Segment2d
---

# Autodesk.Aec.Geometry.Segment2d

## Summary
Represents a segment 2d.

## Properties

### Curve
Gets or sets the base curve.

**Returns:** Returns the base curve.

**Remarks:**
Only arc and line are supported at this time.

### StartPoint
Gets or sets the start point.

**Returns:** The start point.

### EndPoint
Gets or sets the end point.

**Returns:** The end point.

### Length
Returns the total length of the base curve.

**Returns:** The total length of the base curve.

### Bulge
Returns the bulge value.

**Returns:** The bulge value.

**Remarks:**
This value is suitable for Polyline2d methods.

### Visible
Gets or sets the Visible flag.

**Returns:** Returns the Visible flag.

**Remarks:**
Internal bit flag 0x08.

### SegmentPosition
Gets or sets the segment position.

**Returns:** Returns the segment position.

### BoundBox2d
Returns a BoundBox2d.

### MidPoint
Returns the mid point.

**Returns:** Returns the mid point.

### Interval
Sets the interval of the curve.

### StartParameter
Returns the start parameter.

**Returns:** Returns the start parameter.

### EndParameter
Returns the end parameter.

**Returns:** Returns the end parameter.

### IsClosed
Determines if the curve is closed.

**Returns:** Returns true if the curve is closed.

### CurveDirectionPositive
Returns true if the curve direction is clockwise.

**Returns:** Returns true if the curve direction is clockwise.

### IsCurveLineSegment2d
Determines if the Segment2d is a line.

**Returns:** Returns true if the Segment2d is a line.

### IsCurveCircularArc2d
Determines if the Segment2d is an arc.

**Returns:** Returns true if the Segment2d is an arc.

### Attribute
Gets or sets the attribute.

**Returns:** Returns the attribute.

## Methods

### #ctor(Autodesk.AutoCAD.Geometry.Curve2d)
Initializes a new instance of the Segment2d class using the specified curve.

- **`curve`**: A Curve2d.

### #ctor(Autodesk.AutoCAD.Geometry.Curve2d,Autodesk.Aec.Geometry.SegmentPosition)
Initializes a new instance of the Segment2d class using the specified curve and segment position.

- **`curve`**: A Curve2d.
- **`segmentPosition`**: The SegmentPosition of the curve.

### #ctor(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d)
Initializes a new instance of the Segment2d class using the specified start and end points.

- **`startPoint`**: The start point.
- **`endPoint`**: The end point.

### Create(System.IntPtr,System.Boolean)
Creates a wrapper class for Segment2d.

### TransformBy(Autodesk.AutoCAD.Geometry.Matrix3d)
Transforms the curve by the specified matrix.

- **`matrix`**: The 3d transformation matrix.

### TransformBy(Autodesk.AutoCAD.Geometry.Matrix2d)
Transforms the curve by the specified matrix.

- **`matrix`**: The 2d transformation matrix.

### TransferJoinedSegmentData(Autodesk.Aec.Geometry.Segment2d)
Joins two colinear segments.

- **`segment`**: The next segment.

**Remarks:**
Implemented in derived classes.

### Split(Autodesk.AutoCAD.Geometry.Point2d)
Split a segment into two segments.

- **`point`**: The point at which to split the segment.

**Returns:** A new segment from the given point to original end point.

### Scale(System.Double,System.Double)
Scales the Segment2d in X and Y.

- **`x`**: The X scale.
- **`y`**: The y scale.

**Remarks:**
This method turns arcs into ellipses.

### Extent(Autodesk.AutoCAD.Geometry.Point2d@,Autodesk.AutoCAD.Geometry.Point2d@)
Returns the extent of the Segment2d.

- **`topLeft`**: The top left extent.
- **`bottomRight`**: The bottom right extent.

**Returns:** Returns the extent of the Segment2d.

### Reverse
Reverses the start and end points.

### ParameterOf(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Tolerance)
Returns the parameter at the specified point.

- **`point`**: A point on the curve.
- **`tolerance`**: The tolerance.

**Returns:** Returns the parameter at the specified point.

### GetBounds(System.Double@,System.Double@)
Returns the interval of the curve.

- **`lowerBoundParam`**: The parameter of the lower bound.
- **`upperBoundParam`**: The parameter of the upper bound.

**Returns:** Returns the interval of the curve.

### Interval
Returns the interval of the curve.

- **`interval`**: The interval.

### IsOn(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Tolerance)
Determines if the point is on the curve.

- **`point`**: The point.
- **`tolerance`**: The tolerance.

**Returns:** Returns true if the point is on the curve.

### IsOn(Autodesk.AutoCAD.Geometry.Point2d,System.Double@,Autodesk.AutoCAD.Geometry.Tolerance)
Determines if the point is on the curve.

- **`point`**: The point.
- **`parameter`**: The parameter.
- **`tolerance`**: The tolerance.

**Returns:** Returns true if the point is on the curve.

### EvaluatePoint(System.Double)
Evaluates the point using the specified parameter.

- **`parameter`**: The parameter.

**Returns:** Returns the point using the specified parameter.

### DirectionAtParameter(System.Double)
Evaluates the direction at the specified parameter.

- **`parameter`**: The parameter.

**Returns:** Returns the direction at the specified parameter.

### GetCurvature(System.Double)
Determines the curvature at the parameter.

- **`parameter`**: The parameter.

**Returns:** Returns the curvature at the parameter.

**Remarks:**
The curvature is defined as 1/radius, positive if counterclockwise.

### GetCurvature(Autodesk.AutoCAD.Geometry.Point2d)
Determines the curvature at the specified point.

- **`point`**: The point.

**Returns:** Returns the curvature at the specified point.

**Remarks:**
The curvature is defined as 1/radius, positive if counterclockwise.

### ParameterAtLength(System.Double,System.Double,System.Boolean,Autodesk.AutoCAD.Geometry.Tolerance)
Determines the parameter along the length of the curve.

- **`datumParameter`**: The start parameter.
- **`length`**: The length along the curve.
- **`positiveParameterDirection`**: Specifies whether to travel in the positive direction.
- **`tolerance`**: The tolerance.

**Returns:** Returns the parameter along the length of the curve.

### EvaluateLength(System.Double,System.Double,Autodesk.AutoCAD.Geometry.Tolerance)
Evaluates the length along the curve.

- **`fromParameter`**: The start parameter.
- **`toParameter`**: The end parameter.
- **`tolerance`**: The tolerance.

**Returns:** Returns the length between two parameters.

### GetPointOnCurve2d(System.Double)
Returns a point on the curve.

- **`parameter`**: The parameter to evaluate at.

**Returns:** A point on the curve.

### DistanceTo(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Tolerance)
Calculates the distance to the specified parameter.

- **`point`**: The point to calculate the distance to.
- **`tolerance`**: The tolerance.

**Returns:** Returns the distance to the specified parameter.

### GetClosestPointTo(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Tolerance)
Determines the closest point on the curve.

- **`point`**: The input point.
- **`tolerance`**: The tolerance.

**Returns:** Returns a point on the curve.

### IsColinearTo(Autodesk.Aec.Geometry.Segment2d,Autodesk.AutoCAD.Geometry.Tolerance)
Determines if this Segment2d is colinear to another Segment2d.

- **`segment`**: The other segment.
- **`tolerance`**: The tolerance.

**Returns:** Returns true if this Segment2d is colinear to another Segment2d.

### IsColinearTo(Autodesk.AutoCAD.Geometry.LinearEntity2d,Autodesk.AutoCAD.Geometry.Tolerance)
Determines if this Segment2d is colinear to a LinearEntity2d.

- **`line`**: The input LinearEntity2d.
- **`tolerance`**: The tolerance.

**Returns:** Returns true if this Segment2d is colinear to a LinearEntity2d.

### IsOnSameUnboundedCurveAs(Autodesk.Aec.Geometry.Segment2d)
Determines if this Segment2d is on the same unbounded curve as another Segment2d.

- **`segment`**: The other Segment2d.

**Returns:** Returns true if this Segment2d is on the same unbounded curve as another Segment2d.

### IntersectWith(Autodesk.AutoCAD.Geometry.LinearEntity2d,System.Int32@,Autodesk.AutoCAD.Geometry.Point2d@,Autodesk.AutoCAD.Geometry.Point2d@,Autodesk.AutoCAD.Geometry.Tolerance)
Determines the intersection with a line.

- **`line`**: The line.
- **`count`**: The number of intersection points.
- **`point1`**: The first intersection point.
- **`point2`**: The second intersection point.
- **`tolerance`**: The tolerance.

**Returns:** Returns the intersection of the Segment2d and the specified line.

**Remarks:**
If the Segment2d is an arc, 2 points may be returned.

### Tangent(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Line2d@,Autodesk.AutoCAD.Geometry.Tolerance)
Determines the tangent at a given point.

- **`point`**: The tangent point.
- **`line`**: The tangent line if successful, or null otherwise.
- **`tolerance`**: The tolerance.

**Returns:** Returns the tangent at a given point.

### IntersectSegments(Autodesk.Aec.Geometry.Segment2d,System.Int32@,Autodesk.AutoCAD.Geometry.Point2d@,Autodesk.AutoCAD.Geometry.Point2d@)
Determines if the Segment2d intersects another Segement2d.

- **`segment`**: The other Segment2d.
- **`count`**: The number of intersection points.
- **`point1`**: The first intersection point.
- **`point2`**: The second intersection point.

**Returns:** Returns the intersection points of the Segment2d and another Segement2d.

### IntersectWithCurve(Autodesk.AutoCAD.Geometry.Curve2d,System.Int32@,Autodesk.AutoCAD.Geometry.Point2d@,Autodesk.AutoCAD.Geometry.Point2d@)
Determines if the Segment2d intersects a Curve2d.

- **`segment`**: The Curve2d.
- **`count`**: The number of intersection points.
- **`point1`**: The first intersection point.
- **`point2`**: The second intersection point.

**Returns:** Returns the intersection points of the Segment2d and the specified Curve2d.

### GetProjectedIntersectionPoints(Autodesk.Aec.Geometry.Segment2d,Autodesk.AutoCAD.Geometry.Point2d@,Autodesk.AutoCAD.Geometry.Point2d@)
Calculates the project intersection points of the Segment2d and another Segment2d.

- **`segment`**: The other Segment2d.
- **`point1`**: The first projected intersection point.
- **`point2`**: The second projected intersection point.

**Returns:** Returns the project intersection points of the Segment2d and another Segment2d.

### CanMoveStartEndPoint(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d)
Determines if the new start or end point is valid.

- **`oldStartEndPoint`**: The old start/end point.
- **`newStartEndPoint`**: The new start/end point.

**Returns:** Returns true if the new start or end point is valid.

**Remarks:**
The new point must be on the curve between the existing start and end.

### IsExtending(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d)
Determines if the new start or end point will increase the segment length.

- **`oldStartEndPoint`**: The old start/end point.
- **`newStartEndPoint`**: The new start/end point.

**Returns:** Returns true if the new start or end point will increase the segment length.

### MoveStartEndPoint(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d)
Moves the start or end point.

- **`oldStartEndPoint`**: The old start/end point.
- **`newStartEndPoint`**: The new start/end point.

### SegmentPositionName(Autodesk.Aec.Geometry.SegmentPosition)
Returns a string for the specified SegmentPosition value.

- **`position`**: The SegmentPosition.

**Returns:** Returns a string for the specified SegmentPosition value.
