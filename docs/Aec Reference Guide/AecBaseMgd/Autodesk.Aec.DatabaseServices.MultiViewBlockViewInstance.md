---
title: Autodesk.Aec.DatabaseServices.MultiViewBlockViewInstance
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > MultiViewBlockViewInstance
---

# Autodesk.Aec.DatabaseServices.MultiViewBlockViewInstance

## Summary
Represents a multi view block view instance.

## Remarks
This class is responsible for storing and synchronizing attribute instances with the block definition they came from. It also maintains an offset that may be applied to this particular block.

## Properties

### BlockId
Gets or sets the block id.

**Returns:** Returns the block id.

### Offset
Gets or sets the block offset.

**Returns:** Returns the block offset.

### NeedsAttributeUpdate
Gets the upcoming update status of the attributes.

**Returns:** true if attributes will need updating, false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Looks ahead and sees if the attributes need to be updated. Try to save unnecessary updates so we don't force a massive chain of events just to make sure we are in sync with other data.

### AttributeReferences
Gets the collection of MultiViewBlockAttributeReferences contained on this MultiViewBlockViewInstance.

**Returns:** Returns the collection of MultiViewBlockAttributeReferences contained on this MultiViewBlockViewInstance.

## Methods

### #ctor
Initializes a new instance of the MultiViewBlockViewInstance class.

### EnsureConsistentAttributes
Ensures that the attributes are consistent.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Ensures that any missing attributes are added to our block definition, and removes all attributes from our view block that are not actually in the block definition.

### ResetAttributes(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Resets all non-constant attributes definitions.

- **`blockId`**: The block table record id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### NeedsAttributeUpdateFullCheck(System.Boolean)
Does a detailed checking of all attributes and their properties to see if an update is needed. Attribute width is ignored.

- **`includeTextStyle`**: true to include checking of text style, false otherwise.

**Returns:** true if update is needed, false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### NeedsAttributeUpdateFullCheckIncludeWidth(System.Boolean)
Does a detailed checking of all attributes and their properties to see if an update is needed. Includes attribute width.

- **`includeTextStyle`**: true to include checking of text style, false otherwise.

**Returns:** true if update is needed, false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### EnsureConsistentAttributesAndUpdateExisting(System.Boolean)
Ensures that the attributes are consistent, and updates them if they are not.

- **`includeTextStyle`**: true to include checking of text style, false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### EnsureConsistentAttributesAndUpdateExistingIncludeWidth(System.Boolean)
Ensures that the attributes are consistent, and updates them if they are not. Includes attribute width.

- **`includeTextStyle`**: true to include checking of text style, false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
