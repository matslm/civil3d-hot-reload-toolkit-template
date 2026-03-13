---
title: Autodesk.Aec.DatabaseServices.EntityBodyModifier
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > EntityBodyModifier
---

# Autodesk.Aec.DatabaseServices.EntityBodyModifier

## Summary
Represents an entity body modifier.

## Properties

### Body
Sets the body.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ComponentId
Gets or sets the component id.

**Returns:** The component id.

### OperationType
Gets or sets the body modifier operation type.

**Returns:** The body modifier operation type.

## Methods

### #ctor
Initializes a new instance of the EntityBodyModifier class.

### SetBodyFromMassElement(Autodesk.Aec.DatabaseServices.MassElement,Autodesk.AutoCAD.Geometry.Matrix3d)
Sets the body from a mass element.

- **`massElement`**: Input the mass element.
- **`wcsToEcs`**: Input the matrix.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyAsMassElement
Gets the body as a mass element.

**Returns:** The mass element.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### TransformBy(Autodesk.AutoCAD.Geometry.Matrix3d)
Transforms the body modifier by the input matrix.

- **`matrix`**: Input the matrix.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
