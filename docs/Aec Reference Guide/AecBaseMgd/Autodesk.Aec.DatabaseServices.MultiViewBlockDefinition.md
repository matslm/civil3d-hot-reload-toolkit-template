---
title: Autodesk.Aec.DatabaseServices.MultiViewBlockDefinition
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > MultiViewBlockDefinition
---

# Autodesk.Aec.DatabaseServices.MultiViewBlockDefinition

## Summary
Represents a multi view block definition.

## Remarks
A multi view block definition contains information about which blocks to display for a given display rep and a given viewing direction.

## Properties

### DisplayRepresentationDefinitions
Gets the collection of MultiViewBlockDisplayRepresentationDefinitions.

**Returns:** Returns the collection of MultiViewBlockDisplayRepresentationDefinitions.

### InterferenceBlockId
Gets or sets the id of the interference block.

**Returns:** Returns the id of the interference block.

## Methods

### #ctor
Initializes a new instance of the MultiViewBlockDefinition class.

### GetAllBlocksReferenced
Walks through the MultiViewBlockDefinition and gets all blocks that are referenced.

**Returns:** A collection of block ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAttributeGripsDisabled(System.Boolean)
Sets the state for the grips of each attribute.

- **`disable`**: true disables the attribute grips; false enables them.
