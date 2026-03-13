---
title: Autodesk.Aec.DatabaseServices.VolumeLayoutTool
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > VolumeLayoutTool
---

# Autodesk.Aec.DatabaseServices.VolumeLayoutTool

## Summary
Represents a volume layout tool.

## Properties

### LayoutVolumeIds
Gets a collection of layout volume ids.

**Returns:** Returns the collection of layout volume ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

## Methods

### #ctor
Initializes a new instance of the VolumeLayoutTool class.

### GetClosestLayoutVolume(Autodesk.AutoCAD.Geometry.Point3d)
Gets the closest layout volume to the location given.

- **`location`**: The location.

**Returns:** Returns the closest layout volume.

### GetLayoutVolumeBody(System.Int32,Autodesk.AutoCAD.Geometry.Matrix3d@)
Gets the layout volume body and the coordinate system of the layout volume with the given id.

- **`volumeId`**: The volume id.
- **`toWcs`**: The coordinate system of the layout volume (if found.)

**Returns:** Returns the layout volume body.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Should be handled by the derived classes only.

### GetLayoutVolumeCentroid(System.Int32)
Gets the layout volume centroid.

- **`volumeId`**: The volume id.

**Returns:** Returns the layout volume centroid.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetLayoutVolumeExtent(System.Int32,System.Double@,System.Double@,System.Double@,Autodesk.AutoCAD.Geometry.Matrix3d@)
Gets the layout volume extents (length, width, height, and coordinate system).

- **`volumeId`**: The volume layout id.
- **`length`**: The volume layout length to be returned.
- **`width`**: The volume layout width to be returned.
- **`height`**: The volume layout height to be returned.
- **`toWcs`**: The volume layout coordinate system to be returned.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Should be handled by the derived classes only.
