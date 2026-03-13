---
title: Autodesk.Aec.DatabaseServices.MultiViewBlockReference
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > MultiViewBlockReference
---

# Autodesk.Aec.DatabaseServices.MultiViewBlockReference

## Summary
Represents a multi view block reference.

## Remarks
Defines a reference to a multi view block (i.e. refers to an instance of a MultiViewBlockDefinition). Provides methods for obtaining the number of views available on the multiview block, and also for accessing each available view.

## Properties

### ViewInstances
Gets the collection of view instances.

**Returns:** Returns the collection of view instances.

### HasAttributes
Returns true if the Multiview block has attributes, false otherwise.

**Returns:** Returns true if the Multiview block has attributes, false otherwise.

### NumberOfAnnotationScaleContexts
Return the number of annotation scale contexts.

**Returns:** Return the number of annotation scale contexts.

### AnnotationScale
Return the AnnotationScale.

**Returns:** Return the AnnotationScale.

### AnnotationScaleUniqueIdentifier
Return the Annotation Scale Id.

**Returns:** Return the Annotation Scale Id.

### ScaleDependentOffset
Sets the Scale Dependent Offset.

- **`vector`**: The scale dependent offset.

**Returns:** void.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

## Methods

### #ctor
Initializes a new instance of the MultiViewBlockReference class.

### UpdateViewInstances
Updates the multiview blocks.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Updates any matching or non-existant overrides, and removes any "stale" overrides.

### UpdateViewInstancesAttributes(System.Boolean)
Updates all of the attributes for the given view blocks. Ignores attribute width.

- **`includeTextStyle`**: true to include text style on updates; false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
This will create/remove attributes as well as making sure that the properties of the attributes match. This is only meant to be used with MultiViewBlock/Update or when you know you want things to be totally synched up.

### UpdateViewInstancesAttributesIncludeWidth(System.Boolean)
Updates all of the attributes for the given view blocks. Includes attribute width.

- **`includeTextStyle`**: true to include text style on updates; false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
This will create/remove attributes as well as making sure that the properties of the attributes match. This is only meant to be used with MultiViewBlock/Update or when you know you want things to be totally synched up.

### updateAnnotative
Add or remove Annotation Scale Context Data.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
