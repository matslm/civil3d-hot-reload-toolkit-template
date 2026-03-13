---
title: Autodesk.Aec.Modeler.MorphingMap
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > MorphingMap
---

# Autodesk.Aec.Modeler.MorphingMap

## Summary
Represents a class of morphing map.

## Properties

### Null
Gets the null object of morphing map.

### IsNull
Gets to know whether this morphing map is null or not.

**Returns:** True if morphing map is null.

### IsIdentity
Gets to know whether this morphing map is identity.

**Returns:** True if the morphing map is identity.

### Elements
Gets the collection of morphing map elements.

**Returns:** Returns the collection of morphing map elements.

## Methods

### #ctor
Initializes a new instance of the MorphingMap class.

### SetToExplicitIdentityMap(System.Int32)
Sets the morphing map to be explicitly identity.

- **`numberOfEdges`**: Input the number of edges.

### CreateFromTwoPointLoops(Autodesk.AutoCAD.Geometry.Point2dCollection,Autodesk.AutoCAD.Geometry.Point2dCollection)
Creates the morphing map from two point loops.

- **`pointLoopA`**: Input the first point loop.
- **`pointLoopB`**: Input the second point loop.

### Initialize
Initializes the whole morphing map.

### Print
Prints the morphing map.

### Normalize(System.Int32,System.Int32)
Normalizes the whole morphing map.

- **`numberOfEdgesA`**: Input the number of edges A.
- **`numberOfEdgesB`**: Input the number of edges B.

### RemapIndices(Autodesk.AutoCAD.Geometry.IntegerCollection,Autodesk.AutoCAD.Geometry.IntegerCollection)
Remaps both the from and to indices of the map.

- **`fromIndexMap`**: Input the from index collection.
- **`toIndexMap`**: Input the to index collection.

### Clone
Clones the wrapped object.

### DeleteUnmanagedObject
Deletes the unmanaged object.

**Returns:** void.
