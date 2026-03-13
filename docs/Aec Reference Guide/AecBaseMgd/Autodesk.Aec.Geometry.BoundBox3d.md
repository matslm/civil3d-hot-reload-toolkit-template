---
title: Autodesk.Aec.Geometry.BoundBox3d
hierarchy: AecBaseMgd > Autodesk > Aec > Geometry > BoundBox3d
---

# Autodesk.Aec.Geometry.BoundBox3d

## Summary
Represents a 3D bounding box.

## Properties

### IsValid
The MinPoint coordinates must be less than the MaxPoint coordinates.

**Returns:** Returns true if the BoundBox3d is valid.

### Volume
The volume of the BoundBox3d.

**Returns:** Returns the volume.

### Width
The width of the BoundBox3d.

**Returns:** Returns the width.

### Depth
The depth of the BoundBox3d.

**Returns:** Returns the depth.

### Height
The height of the BoundBox3d.

**Returns:** Returns the height.

### MinPoint
The minimum point of the BoundBox3d.

**Returns:** Returns the minimum point.

### MaxPoint
The maximum point of the BoundBox3d.

**Returns:** Returns the maximum point.

## Methods

### Create(System.IntPtr,System.Boolean)
Creates a wrapper class for BoundBox3d.

### #ctor
Initializes a new instance of the BoundBox3d class.

### #ctor(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d)
Initializes a new instance of the BoundBox3d class.

- **`minPoint`**: Minimum bounding 3d point.
- **`maxPoint`**: Maximum bounding 3d point.

### TransformBy(Autodesk.AutoCAD.Geometry.Matrix3d)
Transforms this bound box 3d rings by the specified matrix.

- **`xform`**: Input the 3d transformation matrix.

### Init
Initializes the BoundBox3d extents to infinity.

### Set(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d)
Sets the extents of the BoundBox3d.

- **`minPoint`**: The minimum point of the BoundBox3d.
- **`maxPoint`**: The maximum point of the BoundBox3d.

### Set(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)
Sets the extents of the BoundBox3d.

- **`minX`**: The minimum X coordinate of the BoundBox3d.
- **`minY`**: The minimum Y coordinate of the BoundBox3d.
- **`minZ`**: The minimum Z coordinate of the BoundBox3d.
- **`maxX`**: The maximum X coordinate of the BoundBox3d.
- **`maxY`**: The maximum Y coordinate of the BoundBox3d.
- **`maxZ`**: The maximum Z coordinate of the BoundBox3d.

### IntersectWith(Autodesk.Aec.Geometry.BoundBox3d)
Determines if 2 BoundBox3d objects intersect.

- **`boundBox`**: Input another BoundBox3d to test intersection with.

**Returns:** true if this BoundBox3d intersects with the input BoundBox3d.

### ClosestPoint(Autodesk.AutoCAD.Geometry.Point3d)
Determines the closest point on the BoundBox3d to the test point.

- **`testPoint`**: Input the point for determining the closet point on the BoundBox3d.

**Returns:** Returns the closest point.

### FurthestPoint(Autodesk.AutoCAD.Geometry.Point3d)
Returns the furthest point on the BoundBox3d from the test point.

- **`testPoint`**: Input the point for determining the furthest point on the BoundBox3d.

**Returns:** Returns the furthest point.

### Clone
Clones the BoundBox3d.

### DeleteUnmanagedObject()
Deletes the unmanaged object.

**Returns:** void.
