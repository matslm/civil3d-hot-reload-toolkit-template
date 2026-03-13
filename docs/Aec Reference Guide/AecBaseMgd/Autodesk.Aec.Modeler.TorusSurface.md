---
title: Autodesk.Aec.Modeler.TorusSurface
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > TorusSurface
---

# Autodesk.Aec.Modeler.TorusSurface

## Summary
Represents a tours surface.

## Properties

### Center
Gets the center point.

**Returns:** The center point.

### MajorRadius
Gets the major radius.

**Returns:** The major radius.

### MinorRadius
Gets the minor radius.

**Returns:** The minor radius.

### MajorApprox
Gets the major approx.

**Returns:** The major approx.

### MinorApprox
Gets the minor approx.

**Returns:** The minor approx.

## Methods

### Create(System.IntPtr,System.Boolean)
Creates a wrapper class for Vertex.

### #ctor
Initializes a new instance of the TorusSurface class.

### #ctor(Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double,System.Double,System.Int32,System.Int32,Autodesk.Aec.Modeler.Body)
Initializes a new instance of the TorusSurface class using the specified line, radius, approx and body.

- **`axis`**: The axis.
- **`majRadius`**: The major radius.
- **`minRadius`**: The minor radius.
- **`majApprox`**: The major major approx.
- **`minApprox`**: The minor approx.
- **`body`**: The body.
