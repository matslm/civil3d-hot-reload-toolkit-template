---
title: Autodesk.Aec.Geometry.Profile
hierarchy: AecBaseMgd > Autodesk > Aec > Geometry > Profile
---

# Autodesk.Aec.Geometry.Profile

## Summary
Represents a profile.

## Properties

### RingCount
Specifies the number of rings in the profile.

**Returns:** Returns the number of rings in the profile.

### IsSelfIntersecting
Specifies if any rings intersect any other rings.

**Returns:** Returns true if any rings intersect any other rings.

### Centroid
Calculates the average of centroids of all the rings.

**Returns:** Returns the average of centroids of all the rings.

### CenterOfGravity
Specifies the center of gravity of all the rings.

**Returns:** Returns the center of gravity of all the rings.

### Vertices
Returns the vertices of all rings.

**Returns:** Returns the vertices of all rings.

### IsDirty
Specifies if the profile is dirty.

**Returns:** Returns the DirtyFlag.

### DirtyFlag
Sets the DirtyFlag.

### Rings
Returns the ring collection.

**Returns:** Returns the ring collection.

### Attribute
Gets or sets the attribute.

**Returns:** Returns the attribute.

## Methods

### #ctor
Initializes a new instance of the Profile class.

### Create(System.IntPtr,System.Boolean)
Creates a wrapper class for Profile.

### AddRing(Autodesk.Aec.Geometry.Ring)
Appends a ring to the profile.

- **`ring`**: A ring to add to the profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
No validity checking is performed on the ring.

### AddRingsFrom(Autodesk.Aec.Geometry.Profile)
Adds copies of the rings in the specified profile to this profile.

- **`profile`**: The profile to add rings from.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
The input profile is not modified.

### TransferRingsFrom(Autodesk.Aec.Geometry.Profile)
Pops the rings from the specified profile and appends them to this profile.

- **`profile`**: The profile to transfer rings from.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
The input profile is modified.

### RemoveAllRings
Removes all of the rings from the profile.

### RemoveRingAt(System.Int32)
Removes the specified ring from the profile.

- **`index`**: The 0-based index of the ring to remove.

### PopRingAt(System.Int32)
Removes but does not delete a specified ring.

- **`index`**: The 0-based index of the ring to remove.

**Returns:** The popped ring.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### RemoveVoidRings
Removed all void rings from the profile.

**Remarks:**
Rings inside void rings are also removed.

### TransformBy(Autodesk.AutoCAD.Geometry.Matrix3d)
Transforms all rings by the specified matrix.

- **`matrix`**: The 3d transformation matrix.

### TransformBy(Autodesk.AutoCAD.Geometry.Matrix2d)
Transforms all rings by the specified matrix.

- **`matrix`**: The 2d transformation matrix.

### TranslateBy(Autodesk.AutoCAD.Geometry.Vector2d)
Translates all rings by the specified vector.

- **`vector`**: The 2d translation vector.

### Scale(System.Double,System.Double)
Scales all rings in X and Y.

- **`x`**: The X scale factor.
- **`y`**: The Y scale factor.

### SetExtent(System.Double,System.Double)
Scales this profile so that it becomes the specified width and height.

- **`width`**: The new width to scale to.
- **`height`**: The new height to scale to.

**Remarks:**
The width and height must be greater than zero.

### JoinColinearSegments
Joins colinear segments in each ring.

### OrientAboutPoint(Autodesk.AutoCAD.Geometry.Point2d)
Orients all rings in the profile about a given point.

- **`point`**: The point to orient about.

**Remarks:**
In each ring, closest segment to this point will be the first segment after orientation.

### OrientAboutTopLeftCorner
Orients all rings in the profile about its own top left corner of the extents.

**Remarks:**
In each ring, closest segment to its top left corner will be the first segment after orientation.

### GetClosestParameterTo(Autodesk.AutoCAD.Geometry.Point2d,System.Int32@,System.Int32@,System.Double@)
Calculates closest parameter to the specified point.

- **`point`**: The input point.
- **`ringIndex`**: The ring index.
- **`segmentIndex`**: The segment index.
- **`segmentParameter`**: The segment parameter.

### ConsistentlyOrientRings
Orients all rings consistently within the profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
This method may toggle the IsVoid property of any ring in the profile.

### IsValidRingNesting(System.Int32)
Tests the ring nesting validity.

- **`checkingLevel`**: The level of checking to perform: 0, 1 or 2.

**Returns:** true, if valid.

### Ring(System.Int32)
Determines the ring at the specified index.

- **`index`**: The 0-based segment index.

**Returns:** Returns the ring at the specified index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### IsValidProfile(System.Boolean)
Determines if all rings are valid and this profile is not self intersecting.

- **`performAdditionalChecksOnRing`**: If true, also check if rings are valid.

**Returns:** Returns true if all rings are valid and this profile is not self intersecting.

### IsTopologicallyEquivalent(Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.IntegerCollection@)
Checks if each ring can be mapped to the other.

- **`otherProfile`**: The other profile.
- **`offsets`**: A collection of offsets to get the rings to line up.

**Returns:** true if all rings match.

### Extent(Autodesk.AutoCAD.Geometry.Point2d@,Autodesk.AutoCAD.Geometry.Point2d@)
Calculates the extent of the profile.

- **`topLeft`**: The top left extent.
- **`bottomRight`**: The bottom right extent.

**Returns:** Returns the extent of the profile.

### Area(System.Double)
Calculates the sum of the areas of all rings.

- **`tolerance`**: The tolerance.

**Returns:** Returns the sum of the areas of all rings.

**Remarks:**
The tolerance is not used at this time.

### Perimeter(System.Double)
Calculates the sum of all the lengths of all rings.

- **`tolerance`**: The tolerance.

**Returns:** Returns the sum of all the lengths of all rings.

**Remarks:**
The tolerance is not used at this time.

### PointInProfile(Autodesk.AutoCAD.Geometry.Point2d)
Determines the containment of the specified point in this profile.

- **`point`**: The input point.

**Returns:** Returns the containment of the specified point in this profile.

**Remarks:**
Can be PointInProfile, PointOutsideProfile, PointOnRing or PointOnVoidRing.

### RingInProfile(Autodesk.Aec.Geometry.Ring)
Determines the containment of the specified ring within this profile.

- **`ring`**: The input ring.

**Returns:** Returns the containment of the specified ring within this profile.

**Remarks:**
Can be RingOutsideProfile, RingInsideProfile, RingCoincidesWithVoidRing, or RingCoincidesWithRing.  The specified ring must not intersect this profile.

### OffsetUniform(System.Double)
Offsets each ring in the profile by the specified distance.

- **`distance`**: The offset distance.

**Returns:** The resulting profile.

### OffsetUniformRingAt(System.Int32,System.Double)
Offsets one ring in the profile by the specified distance.

- **`index`**: The index of the ring to offset.
- **`distance`**: The offset distance.

**Returns:** The resulting profile.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### Split(Autodesk.AutoCAD.Geometry.Line2d)
Splits the profile and removes all geometry to the right of the specified line.

- **`line`**: The input line.

**Returns:** The resulting profile.

### IntersectWith(Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.Tolerance)
Calculates the boolean intersection of this profile and the specified profile.

- **`profile`**: The input profile.
- **`tolerance`**: The tolerance.

**Returns:** The resulting profile.

### UnionWith(Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.Tolerance)
Calculates the boolean union of this profile and the specified profile.

- **`profile`**: The input profile.
- **`tolerance`**: The tolerance.

**Returns:** The resulting profile.

### SubtractProfile(Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.Tolerance)
Subtracts the specified profile from this profile.

- **`profile`**: The input profile.
- **`tolerance`**: The tolerance.

**Returns:** The resulting profile.

### CleanupVertices(System.Boolean)
Ensures that the end point and the start point of consecutive segments are the same.

- **`doChange`**: Determines if the vertices are actually changed.

**Returns:** The number of vertices changed.

### CalculateSegmentPositions(Autodesk.Aec.Geometry.ProfileExtrusionDirection,System.Boolean)
Calculates the segment positions for each ring in the profile.

- **`extrusionDirection`**: Determines the segment position.
- **`calculateOnlyForNonMarked`**: Determines if marked rings are calculated.

**Remarks:**
The calculateOnlyForNonMarked is not used at this time.

### ModifySegmentPositions(Autodesk.Aec.Geometry.SegmentPosition,Autodesk.Aec.Geometry.SegmentPosition)
Updates the specified segment positions of each segment of each ring in the profile.

- **`oldSegmentPosition`**: The current segment position.
- **`newSegmentPosition`**: The desired segment position.

### ModifySegmentPositions(Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.ProfileExtrusionDirection)
Updates the specified segment positions of each segment of each ring in the profile.

- **`oldExtrusionDirection`**: The current extrusion direction.
- **`newExtrusionDirection`**: The desired extrusion direction.

### MirrorSegmentPositions
Mirrors the position of each segment of each ring in the profile.

### UpdateTransientData
Updates the transient data for the profile.

**Remarks:**
The method recalculates the extents of the profile.

### GetExtrusion(Autodesk.AutoCAD.Geometry.Vector3d,System.Double,System.Int32)
Creates a body from the profile.

- **`direction`**: The extrusion direction.
- **`deviation`**: The facet deviation.
- **`maxFacetsOnCircle`**: The maximum number of circle facets.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateCircle(System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`width`**: The width of the circle.
- **`height`**: The height of the circle.
- **`translation`**: The translation of the circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateCircle(System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`radius`**: The radius of the circle.
- **`translation`**: The translation of the circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateIsoscelesTriangle(System.Double,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`width`**: The width of the triangle.
- **`height`**: The height of the triangle.
- **`rotation`**: The rotation of the triangle.
- **`translation`**: The translation of the triangle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateLeftHandSideRightAngleTriangle(System.Double,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`width`**: The width of the triangle.
- **`height`**: The height of the triangle.
- **`rotation`**: The rotation of the triangle.
- **`translation`**: The translation of the triangle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateOval(System.Double,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`width`**: The width of the oval.
- **`height`**: The height of the oval.
- **`rotation`**: The rotation of the oval.
- **`translation`**: The translation of the oval.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreatePolygon(System.Int32,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`sideCount`**: The side count of the polygon.
- **`sideLength`**: The side length of the polygon.
- **`rotation`**: The rotation of the polygon.
- **`translation`**: The translation of the polygon.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateQuarterCircle(System.Double,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`width`**: The width of the circle.
- **`height`**: The height of the circle.
- **`rotation`**: The rotation of the circle.
- **`translation`**: The translation of the circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateQuarterCircle(System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`radius`**: The radius of the circle.
- **`rotation`**: The rotation of the circle.
- **`translation`**: The translation of the circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateRectangle(System.Double,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`width`**: The width of the rectangle.
- **`height`**: The height of the rectangle.
- **`rotation`**: The rotation of the rectangle.
- **`translation`**: The translation of the rectangle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateRightHandSideRightAngleTriangle(System.Double,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`width`**: The width of the triangle.
- **`height`**: The height of the triangle.
- **`rotation`**: The rotation of the triangle.
- **`translation`**: The translation of the triangle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateSemiCircle(System.Double,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`width`**: The width of the circle.
- **`height`**: The height of the circle.
- **`rotation`**: The rotation of the circle.
- **`translation`**: The translation of the circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateSemiCircle(System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`radius`**: The radius of the circle.
- **`rotation`**: The rotation of the circle.
- **`translation`**: The translation of the circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateUShape(System.Double,System.Double,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`width`**: The width of the U shape.
- **`height`**: The height of the U shape.
- **`thickness`**: The thickness of the U shape.
- **`rotation`**: The rotation of the U shape.
- **`translation`**: The translation of the U shape.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateSemiCircularRing(System.Double,System.Double,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`width`**: The width of the ring.
- **`height`**: The height of the ring.
- **`thickness`**: The thickness of the ring.
- **`rotation`**: The rotation of the ring.
- **`translation`**: The translation of the ring.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateSemiCircularRing(System.Double,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`outerRadius`**: The outer radius of the ring.
- **`thickness`**: The thickness of the ring.
- **`rotation`**: The rotation of the ring.
- **`translation`**: The translation of the ring.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateQuarterCircularRing(System.Double,System.Double,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`width`**: The width of the ring.
- **`height`**: The height of the ring.
- **`thickness`**: The thickness of the ring.
- **`rotation`**: The rotation of the ring.
- **`translation`**: The translation of the ring.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateQuarterCircularRing(System.Double,System.Double,System.Double,Autodesk.AutoCAD.Geometry.Vector2d)
Creates a profile.

- **`outerRadius`**: The outer radius of the ring.
- **`thickness`**: The thickness of the ring.
- **`rotation`**: The rotation of the ring.
- **`translation`**: The translation of the ring.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateFromEntity(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.Geometry.Matrix3d)
Creates a profile.

- **`entity`**: The entity to create the profile from.
- **`toWcs`**: The 3d transformation matrix.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### op_Equality(Autodesk.Aec.Geometry.Profile,Autodesk.Aec.Geometry.Profile)
Check if the profiles are equal.

- **`profile1`**: The first profile.
- **`profile2`**: The second profile.

**Returns:** true, if the profiles are equal; false, otherwise.

### op_Inequality(Autodesk.Aec.Geometry.Profile,Autodesk.Aec.Geometry.Profile)
Check if the profiles are not equal.

- **`profile1`**: The first profile.
- **`profile2`**: The second profile.

**Returns:** True, if the profiles are not equal; false, otherwise.

### Equals(Autodesk.Aec.Geometry.Profile,Autodesk.Aec.Geometry.Profile)
Check if the profiles are equal.

- **`profile1`**: The first profile.
- **`profile2`**: The second profile.

**Returns:** true, if the profiles are equal; false, otherwise.

### IsEqualTo(Autodesk.Aec.Geometry.Profile)
Check if the profiles are equal.

- **`otherProfile1`**: The other profile.

**Returns:** true, if the profiles are equal; false, otherwise.
