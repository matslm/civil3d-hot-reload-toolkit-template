---
title: Autodesk.Aec.Geometry.BoundBox2d
hierarchy: AecBaseMgd > Autodesk > Aec > Geometry > BoundBox2d
---

# Autodesk.Aec.Geometry.BoundBox2d

## Summary
Represents a bound box 2d.

## Properties

### IsValid
The MinPoint coordinates must be less than the MaxPoint coordinates.

**Returns:** Returns true if the BoundBox2d is valid.

### Area
The area of the BoundBox2d.

**Returns:** Returns the area.

### Width
The width of the BoundBox2d.

**Returns:** Returns the width.

### Depth
The depth of the BoundBox2d.

**Returns:** Returns the depth.

### MinPoint
The minimum point of the BoundBox2d.

**Returns:** Returns the minimum point.

### MaxPoint
The maximum point of the BoundBox2d.

**Returns:** Returns the maximum point.

## Methods

### Create(System.IntPtr,System.Boolean)
Creates a wrapper class for BoundBox2d.

### #ctor
Initializes a new instance of the BoundBox2d class.

### #ctor(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d)
Initializes a new instance of the BoundBox2d class using the specified min and max points.

- **`minPoint`**: Minimum bounding point.
- **`maxPoint`**: Maximum bounding point.

### Init
Initializes the BoundBox2d extents to infinity.

### Set(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d)
Sets the extents of the BoundBox2d.

- **`minPoint`**: The minimum point of the BoundBox2d.
- **`maxPoint`**: The maximum point of the BoundBox2d.

### Set(System.Double,System.Double,System.Double,System.Double)
Sets the extents of the BoundBox2d.

- **`minX`**: The minimum X coordinate of the BoundBox2d.
- **`minY`**: The minimum Y coordinate of the BoundBox2d.
- **`maxX`**: The maximum X coordinate of the BoundBox2d.
- **`maxY`**: The maximum Y coordinate of the BoundBox2d.

### IntersectWith(Autodesk.Aec.Geometry.BoundBox2d)
Determines if 2 BoundBox2d objects intersect.

- **`boundBox`**: The other BoundBox2d.

**Returns:** Returns true if this BoundBox2d intersects with the other BoundBox2d.

### ContainsPoint(Autodesk.AutoCAD.Geometry.Point2d)
Determines if the given point is contained by the BoundBox2d.

- **`point`**: A Point2d.

**Returns:** Returns true if the point is within or on the BoundBox2d.

### Enlarge(System.Double)
Enlarges the BoundBox2d uniformly.

- **`factor`**: The amount added to each coordinate.

### ClosestPoint(Autodesk.AutoCAD.Geometry.Point2d)
Determines the closest point on the BoundBox2d to the test point.

- **`testPoint`**: The test point.

**Returns:** Returns the closest point.

### FurthestPoint(Autodesk.AutoCAD.Geometry.Point2d)
Returns the furthest point on the BoundBox2d from the test point.

- **`testPoint`**: The test point.

**Returns:** Returns the furthest point.

### Clone
Clones the wrapped object.

### DeleteUnmanagedObject()
Deletes the unmanaged object.

**Returns:** void.
