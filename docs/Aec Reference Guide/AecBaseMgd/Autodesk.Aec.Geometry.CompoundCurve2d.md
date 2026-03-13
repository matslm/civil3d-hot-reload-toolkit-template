---
title: Autodesk.Aec.Geometry.CompoundCurve2d
hierarchy: AecBaseMgd > Autodesk > Aec > Geometry > CompoundCurve2d
---

# Autodesk.Aec.Geometry.CompoundCurve2d

## Summary
Represents a compound curve 2d.

## Properties

### SegmentCount
Specifies the number of segments.

**Returns:** Returns the number of segments.

### IsClosed
Determines if the CompoundCurve2d is closed.

**Returns:** Returns true if endpoint equals startpoint.

### IsContinuous
Specifies if the segments are connected in order.

**Returns:** Returns true if all segments are connected in order.

### IsSelfIntersecting
Specifies if any segments cross.

**Returns:** Returns true if any segments cross.

### StartPoint
Specifies the start point of the compound curve.

**Returns:** Returns the start point of the compound curve.

### EndPoint
Specifies the end point of the compound curve.

**Returns:** Returns the end point of the compound curve.

### Length
Specifies the length of the CompoundCurve2d.

**Returns:** Returns the length of the CompoundCurve2d.

### Vertices
Accesses the vertices of the CompoundCurve2d.

**Returns:** Returns the vertices of the CompoundCurve2d.

### DirtyFlag
Indicates when the transient data of the CompoundCurve2d may have changed.

**Returns:** Returns true if the transient data of the CompoundCurve2d may have changed.

**Remarks:**
The transient data includes the length, centroid, area and extents.

### Attribute
Gets or sets the attribute.

**Returns:** Returns the attribute.

## Methods

### #ctor
Initializes a new instance of the CompoundCurve2d class.

### AddSegment(Autodesk.Aec.Geometry.Segment2d,System.Boolean)
Adds a Segment2d to the CompoundCurve2d.

- **`segment`**: The Segment2d to add.
- **`appendAtEnd`**: Determines whether the Segment2d is added to the start/end.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
The segment to add must have the same start/end point as the CompoundCurve2d.

### AddSegmentAt(System.Int32,Autodesk.Aec.Geometry.Segment2d)
Adds a Segment2d to the CompoundCurve2d.

- **`index`**: The index at which to insert the Segment2d.
- **`segment`**: The Segment2d to add.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
No error checking is done on the start/end points.

### AddSegmentsFrom(Autodesk.Aec.Geometry.CompoundCurve2d,System.Boolean)
Adds copies of all segments from the passed in CompoundCurve2d to this CompoundCurve2d.

- **`compoundCurve`**: The CompoundCurve2d to add segments from.
- **`appendAtEnd`**: Determines if the segments are appended to the end or beginning.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
An exception is thrown if the endpoints do not match up.

### AddSegmentsFrom(Autodesk.AutoCAD.DatabaseServices.Polyline,System.Boolean)
Appends new segments from an existing Polyline.

- **`polyline`**: The Polyline to append segments from.
- **`appendAtEnd`**: Determines if the segments are appended to the end or beginning.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddSegmentsFrom(Autodesk.AutoCAD.Geometry.Point2dCollection,System.Boolean)
Adds a series of segments to this CompoundCurve2d.

- **`points`**: The collection of points defining the segments to add.
- **`appendAtEnd`**: Determines if the segments are appended to the end or beginning.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
An exception is thrown if the endpoints do not match up.

### TransferSegmentsFrom(Autodesk.Aec.Geometry.CompoundCurve2d,System.Boolean)
Moves segments from the passed compoundCurve to this one.

- **`compoundCurve`**: The CompoundCurve2d to transfer segments from.
- **`appendAtEnd`**: Determines if the segments are appended to the end or beginning.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveAllSegments
Removes all segments.

### RemoveSegment(System.Boolean)
Removes a single segment.

- **`removeFromEnd`**: Determines if the first or last segment is removed.

### RemoveSegmentAt(System.Int32)
Removes the specified segment.

- **`index`**: The 0-based index of the segment to remove.

### ReplaceSegmentAt(System.Int32,Autodesk.Aec.Geometry.Segment2d)
Replace the segment in specified index.

- **`index`**: The 0-based index of the segment to remove.
- **`withThis`**: The segment to replace.

### PopSegment(System.Boolean)
Pops the first or last segment.

- **`removeFromEnd`**: Determines if the first or last segment is removed.

**Returns:** The segment removed.

### PopSegmentAt(System.Int32)
Pops the specified segment.

- **`index`**: The 0-based index of the segment to pop.

**Returns:** The segment removed.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Reverse(System.Boolean)
Reverses the order of all the segments.

- **`reverseInPlace`**: Determines if the first segment stay at the beginning.

### TransformBy(Autodesk.AutoCAD.Geometry.Matrix3d)
Transforms each of the segments.

- **`matrix`**: The Matrix3d to transform by.

**Remarks:**
The caller is responsible for making sure the CompoundCurve2d is still valid after the transformation.

### TransformBy(Autodesk.AutoCAD.Geometry.Matrix2d)
Transforms each of the segments.

- **`matrix`**: The Matrix2d to transform by.

**Remarks:**
The caller is responsible for making sure the CompoundCurve2d is still valid after the transformation.

### TranslateBy(Autodesk.AutoCAD.Geometry.Vector2d)
Transforms each of the segments.

- **`vector`**: The Vector2d to transform by.

**Remarks:**
The caller is responsible for making sure the CompoundCurve2d is still valid after the transformation.

### Scale(System.Double,System.Double)
Scales each segment of the CompoundCurve2d.

- **`x`**: Scale for X.
- **`y`**: Scale for Y.

**Remarks:**
If an arc is non-uniformly scaled, it is broken up into a number of segments determined by the facet deviation of the current database.

### JoinColinearSegments
Loop through each segment and try to join consecutive colinear segments.

### TransferSegmentDataForJoin(Autodesk.Aec.Geometry.Segment2d,Autodesk.Aec.Geometry.Segment2d)
Determines how two segments are joined.

- **`segmentToKeep`**: The Segment2d to keep.
- **`segmentToDelete`**: The Segment2d to delete.

### JoinColinearPossible(Autodesk.Aec.Geometry.Segment2d,Autodesk.Aec.Geometry.Segment2d)
Determines if a join operation will be rejected.

- **`segment`**: The current Segment2d.
- **`nextSegment`**: The next Segment2d.

**Returns:** true if the join is possible.

### OrientAboutPoint(Autodesk.AutoCAD.Geometry.Point2d)
Orient the CompoundCurve2d about a given point.

- **`point`**: The Point2d to orient the CompoundCurve2d.

**Remarks:**
Closest segment to this point will be the first segment after orientation.

### OrientAboutTopLeftCorner
Orients a CompoundCurve2d about the top left corner of its extents.

**Remarks:**
Closest segment to the top left corner will be the first segment after orientation.

### Segment(System.Int32)
Accesses an individual segment.

- **`index`**: The 0-based index of the segment.

**Returns:** Returns the specified segment.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### EvaluatePointAtParameter(System.Int32,System.Double)
Evaluates the point on the specified segment at the specified parameter.

- **`segmentIndex`**: The 0-based index of the segment.
- **`segmentParameter`**: The parameter value.

**Returns:** Returns the point on the specified segment at the specified parameter.

### DirectionAtParameter(System.Int32,System.Double)
Evaluates the first derivative of the specified segment at the specified parameter.

- **`segmentIndex`**: The 0-based index of the segment.
- **`segmentParameter`**: The parameter value.

**Returns:** Return the first derivative of the specified segment at the specified parameter.

### LengthToPoint(Autodesk.AutoCAD.Geometry.Point2d,System.Boolean)
Calculates the length from the start or end to a specified point.

- **`pointOnCurve`**: A point on the curve.
- **`fromStart`**: Determines if the length is measured from the start or end.

**Returns:** Returns the length from the start or end to a specified point.

### LengthToParameter(System.Int32,System.Double,System.Boolean)
Calculates the length along the specified segment from the start or end to the specified parameter.

- **`segmentIndex`**: The 0-based index of the segment.
- **`segmentParameter`**: The parameter value.
- **`fromStart`**: Determines if the length is measured form the start or end.

**Returns:** Returns the length along the specified segment from the start or end to the specified parameter.

### GetParameterAtPoint(Autodesk.AutoCAD.Geometry.Point2d,System.Int32@,System.Double@,System.Boolean)
Finds the parameter and segment index of the specified point.

- **`point`**: A point on the CompoundCurve2d.
- **`segmentIndex`**: The 0-based index of the segment.
- **`segmentParameter`**: The parameter value.
- **`useStartParameterAtJoints`**: Determines whether to use the start or end parameter when the point lies on an endpoint.

**Returns:** Returns the parameter and segment index of the specified point.

### GetParameterAtLength(System.Double,System.Int32@,System.Double@,System.Boolean,System.Boolean)
Finds the parameter and segment index at the specified distance from the start or end of the CompoundCurve2d.

- **`distance`**: Distance from start or end.
- **`segmentIndex`**: The 0-based index of the segment.
- **`segmentParameter`**: The parameter value.
- **`useStartParameterAtJoints`**: Specifies whether to use the start or end param when the point lies on an endpoint.
- **`fromStart`**: Determines whether to evaluate from the start or end.

**Returns:** Returns the parameter and segment index at the specified distance from the start or end of the CompoundCurve2d.

### GetClosestParameterTo(Autodesk.AutoCAD.Geometry.Point2d,System.Int32@,System.Double@)
Determines the closest segment index and parameter to a specified point.

- **`point`**: A point on the CompoundCurve2d.
- **`segmentIndex`**: The 0-based index of the segment.
- **`segmentParameter`**: The parameter value.

**Returns:** void.

### Extent(Autodesk.AutoCAD.Geometry.Point2d@,Autodesk.AutoCAD.Geometry.Point2d@)
Calculates the extent of all segments.

- **`topLeft`**: Top left point of the bound box.
- **`bottomRight`**: Bottom right point of the bound box.

**Returns:** Returns the extent of all segments.

### MoveVertex(Autodesk.Aec.Geometry.CompoundCurve2dVertex,Autodesk.AutoCAD.Geometry.Vector2d)
Moves a vertex (start of one segment, end of another segment).

- **`vertex`**: The vertex to move.
- **`offset`**: The amount to move the vertex.

**Returns:** void.

### InsertVertex(Autodesk.AutoCAD.Geometry.Point2d)
Inserts a new vertex.

- **`newPoint`**: The new vertex.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
A new segment is added unless the point was on an endpoint or not on a segment.

### CleanupVertices(System.Boolean)
Ensures that the end point and the start point of consecutive segments are the same.

- **`doChange`**: Whether or not to actually change vertices.

**Returns:** The number of vertices that were different.

### IntersectWith(Autodesk.Aec.Geometry.CompoundCurve2d,Autodesk.AutoCAD.Geometry.Point2dCollection@)
Determines intersection points with another CompoundCurve2d.

- **`curve`**: The other CompoundCurve2d.
- **`points`**: The collection of intersecting points.

**Returns:** Returns the collection of intersecting points.

### IntersectWith(Autodesk.Aec.Geometry.CompoundCurve2d,Autodesk.AutoCAD.Geometry.Point2dCollection@,Autodesk.AutoCAD.Geometry.IntegerCollection@,Autodesk.AutoCAD.Geometry.DoubleCollection@,Autodesk.AutoCAD.Geometry.IntegerCollection@,Autodesk.AutoCAD.Geometry.DoubleCollection@)
Finds intersection points and parameters with another CompundCurve2d.

- **`curve`**: The other CompoundCurve2d.
- **`points`**: The collection of intersecting points.
- **`indices1`**: Indices of this CompoundCurve2d.
- **`parameters1`**: Parameters of this CompoundCurve2d.
- **`indices2`**: Indices of the other CompoundCurve2d.
- **`parameters2`**: Parameters of the other CompoundCurve2d.

**Returns:** Returns the intersection points and parameters with another CompundCurve2d.

### IntersectWith(Autodesk.AutoCAD.Geometry.Curve2d,Autodesk.AutoCAD.Geometry.Point2dCollection@)
Determines intersection points with a Curve2d.

- **`curve`**: A curve2d.
- **`points`**: The collection of intersecting points.

**Returns:** Returns the collection of intersecting points.

### IntersectWith(Autodesk.AutoCAD.Geometry.Curve2d,Autodesk.AutoCAD.Geometry.Point2dCollection@,Autodesk.AutoCAD.Geometry.IntegerCollection@,Autodesk.AutoCAD.Geometry.DoubleCollection@)
Finds intersection points and parameters with a Curve2d.

- **`curve`**: A Curve2d.
- **`points`**: The collection of intersecting points.
- **`indices`**: Indices of this CompoundCurve2d.
- **`params`**: Parameters of this CompoundCurve2d.

**Returns:** Returns the intersection points and parameters with a Curve2d.

### IntersectionParameter(Autodesk.AutoCAD.Geometry.Curve2d,Autodesk.AutoCAD.Geometry.Point2d@,System.Int32@,System.Double@,System.Boolean)
Determines the  closest intersection parameter.

- **`curve`**: A Curve2d.
- **`point`**: The intersection point.
- **`segmentIndex`**: The segment index.
- **`segmentParameter`**: The parameter.
- **`closestToStart`**: Determines whether to get the intersection point closer to start or end.

**Returns:** Return true if an intersection is found.

### UpdateTransientData
Updates the transient data of the CompoundCurve2d.

**Remarks:**
The transient data includes the length, centroid, area and extents.

### GetBetween(System.Double,System.Double)
Returns a CompoundCurve2d from the start to the end distance along the curve.

- **`startDistanceAlong`**: The start distance along the curve.
- **`endDistanceAlong`**: The end distance along the curve.

**Returns:** Returns a CompoundCurve2d from the start to the end distance along the curve.

### GetBetween(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d)
Returns a CompoundCurve2d from the start to the end point on the curve.

- **`startPoint`**: The start point on the curve.
- **`endPoint`**: The end point on the curve.

**Returns:** Returns a CompoundCurve2d from the start to the end point on the curve.

### GetBetween(Autodesk.AutoCAD.Geometry.Curve2d,Autodesk.AutoCAD.Geometry.Curve2d)
Returns a CompoundCurve2d between the intersection points of two Curve2d objects.

- **`startClip`**: The intersecting Curve2d that defines the start point.
- **`endClip`**: The intersecting Curve2d the defines the end point.

**Returns:** Returns a CompoundCurve2d between the intersection points of two Curve2d objects.

### GetBetween(System.Int32,System.Double,System.Int32,System.Double)
Returns a CompoundCurve2d from the start to the end parameter of the curve.

- **`startIndex`**: Index of the start segment.
- **`startParameter`**: Parameter of the start segment.
- **`endIndex`**: Index of the end segment.
- **`endParameter`**: Parameter of the end segment.

**Returns:** Returns a CompoundCurve2d from the start to the end parameter of the curve.

### IsEqualTo(Autodesk.Aec.Geometry.CompoundCurve2d)
Determine whether two compound curve are equal.

- **`pOtherCompCurve`**: The other compound curve.

**Returns:** Returns true if two compount curve are equal, false otherwise.
