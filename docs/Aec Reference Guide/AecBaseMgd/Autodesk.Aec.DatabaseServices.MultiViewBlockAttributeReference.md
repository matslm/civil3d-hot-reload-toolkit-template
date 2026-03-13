---
title: Autodesk.Aec.DatabaseServices.MultiViewBlockAttributeReference
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > MultiViewBlockAttributeReference
---

# Autodesk.Aec.DatabaseServices.MultiViewBlockAttributeReference

## Summary
Represents a multi view block attribute reference.

## Remarks
This class is responsible for containment and maintenance of an in-memory AttributeReference and prompt. The attribute requires special handling to keep its justification updated.

## Properties

### Prompt
Gets or sets the prompt string of the attribute.

**Returns:** Returns a string containing the attribute's prompt.

### Attribute
Gets or sets the AttributeReference.

**Returns:** Returns the AttributeReference.

### NeedsUpdate
Gets or sets the update status.

**Returns:** true if update is needed, false otherwise.

### MText
Gets the MText of the AttributeReference.

**Returns:** The MText of AttributeReference, or null if none was found.

## Methods

### #ctor
Initializes a new instance of the MultiViewBlockAttributeReference class.

### #ctor(System.String,Autodesk.AutoCAD.DatabaseServices.AttributeReference)
Initializes a new instance of the MultiViewBlockAttributeReference class using the specified prompt and attribute.

- **`prompt`**: The prompt.
- **`attribute`**: The attribute.

### CopyToMText
Copies the properties and string from the in-memory AttributeReference onto the in-memory MText.

### DeleteMText
Deletes the in-memory MText.
