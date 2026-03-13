---
title: Autodesk.Aec.DatabaseServices.LayoutModeType
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > LayoutModeType
---

# Autodesk.Aec.DatabaseServices.LayoutModeType

## Summary
LayoutMode types for LayoutCurve object.

## Fields

### Manual
Nodes are to be positioned manually.

### Repeat
Nodes are to be positioned automatically at repeated equidistant spacing. The number of anchor nodes is determined by the length of the layout curve. As the length of the curve changes, nodes are added or subtracted accordingly. The spacing of the nodes remains fixed.

### SpaceOut
Nodes are to be positioned spaced out evenly. The number of nodes is specified along the curve. The space between nodes is determined by the length of the layout curve. As the length of the curve changes, the spacing between nodes is lengthened or shortened accordingly. The number of nodes remains fixed.
