---
title: Autodesk.Aec.DatabaseServices.MultiViewBlockDisplayRepresentationDefinition
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > MultiViewBlockDisplayRepresentationDefinition
---

# Autodesk.Aec.DatabaseServices.MultiViewBlockDisplayRepresentationDefinition

## Summary
Represents a multi view block display representation definition.

## Remarks
This class is responsible for storing a collection of MultiViewBlockDefinition objects.  Each viewBlock points to an autocad block definition to be displayed in various viewing directions. All contained view blocks are associated only with the display representation object that this class points to.

## Properties

### DisplayRepresentationId
Gets or sets the id of the display representation.

**Returns:** Returns the id of the display representation.

### ViewDefinitions
Gets the collection of MultiViewBlockViewDefinitions.

**Returns:** Returns the collection of MultiViewBlockViewDefinitions.

## Methods

### #ctor
Initializes a new instance of the MultiViewBlockDisplayRepresentationDefinition class.

### SetAttributeGripsDisabled(System.Boolean)
Disables the grips of each attribute.

- **`disable`**: The new value to be used for disabling or enabling the attribute grips.
