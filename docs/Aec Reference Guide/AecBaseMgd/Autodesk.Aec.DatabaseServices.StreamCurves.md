---
title: Autodesk.Aec.DatabaseServices.StreamCurves
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > StreamCurves
---

# Autodesk.Aec.DatabaseServices.StreamCurves

## Summary
Represents stream curves.

## Properties

### IgnoreHatch
Gets or sets whether hatch should be ignored.

### CollectArcs
Gets or sets whether arcs should be collected.

### ApplySurfaceHatching
Gets or sets whether surface hatching is applied.

### CollectDisplayPropertiesInfomationFor2dSection
Gets or sets if it collects display properties information for 2d section.

### DisplayComponentEntityLines
Gets the line display component entities.

### DisplayComponentEntityArcs
Gets arc display component entities.

### Lines
Gets the collected lines.

### Arcs
Gets the collected arcs.

### NestedEntityFilter
Gets or sets the nested entity filter.

**Returns:** The nested entity filter.

### IgnoreText
Gets whether text should be ignored.

### BackfaceCullSurfaceHatching
Gets or sets whether BackfaceCullSurfaceHatching should be turned on.

**Returns:** Boolean value indicates whether BackfaceCullSurfaceHatching should be turned on.

## Methods

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database)
Initializes a new instance of the StreamCurves class using the specified database.

- **`db`**: The database.

### SetIgnoreText
Sets whether text should be ignored.

### CollectDisplayPropertiesForCurves(System.Boolean)
Collects display properties for curves.

- **`curveIsALine`**: True if the curve is a line.
