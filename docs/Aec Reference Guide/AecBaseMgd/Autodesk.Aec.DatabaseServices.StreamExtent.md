---
title: Autodesk.Aec.DatabaseServices.StreamExtent
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > StreamExtent
---

# Autodesk.Aec.DatabaseServices.StreamExtent

## Summary
Represents a stream that calculates an extents box based on all of the geometry pushed in.  The resulting extents are in world coordinates and are orthogonal to the world origin.  By default the results include graphics that are on non-visible layers.

## Properties

### Extents
Gets the extents.

**Returns:** The extents.

### TextStrokingStatus
Gets the current text stroking status. The top value of the status stack.

**Returns:** The current text stroking status.

### AllowMText
Gets or sets if MText is allowed.

## Methods

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database)
Initializes a new instance of the StreamExtent class using the specified database.

- **`db`**: The specified database.

### PushTextStrokingStatus(System.Boolean)
Pushes a text stroking status into the status stack.

- **`isTextStrokingOn`**: Indicates if text stroking is on.

### PopTextStrokingStatus
Pops the text stroking status stack.

### SetIncludeLiveSectionInExtent(System.Boolean)
Sets if live sections should be included in the extent.

- **`value`**: Indicates if live sections should be included in the extent.
