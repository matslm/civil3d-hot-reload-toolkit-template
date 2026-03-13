---
title: Autodesk.Aec.DatabaseServices.MassElement
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > MassElement
---

# Autodesk.Aec.DatabaseServices.MassElement

## Summary
Represents a mass element.

## Properties

### SubType
Gets or sets the user-defined subtype.

**Returns:** Returns the user-defined subtype.

### Width
Gets or sets the width.

**Returns:** Returns the width.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Depth
Gets or sets the depth.

**Returns:** Returns the depth.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Height
Gets or sets the height.

**Returns:** Returns the height.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Radius
Gets or sets the radius.

**Returns:** Returns the radius.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Rise
Gets or sets the rise.

**Returns:** Returns the rise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Deviation
Gets or sets the deviation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Body
Gets the body.

**Returns:** Returns the body.

### ShapeType
Gets the shape type.

**Returns:** The shape type.

### ShapeSubType
Gets the shape subtype.

**Returns:** Returns the shape subtype.

### ProfileId
Gets or sets the profile id.

**Returns:** Returns the profile id.

### Profile
Gets or sets the profile.

**Returns:** Returns the profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Volume
Gets the volume.

**Returns:** Returns the volume.

## Methods

### #ctor
Initializes a new instance of the MassElement class.

### Create(Autodesk.Aec.DatabaseServices.ShapeType)
Creates a mass element with the specified shape type.

- **`type`**: The shape type.

**Returns:** Returns a mass element with the specified shape type.

### Create(Autodesk.Aec.DatabaseServices.ShapeType,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Creates a mass element with the specified shape type and profile id.

- **`type`**: The shape type.
- **`profileId`**: The profile id.

**Returns:** Returns a mass element with the specified shape type and profile id.

### Create(Autodesk.Aec.DatabaseServices.ShapeType,Autodesk.Aec.Geometry.Profile)
Creates a mass element with the specified shape type and profile.

- **`type`**: The shape type.
- **`profile`**: The profile.

**Returns:** Returns a mass element with the specified shape type and profile.

### ChangeTo(Autodesk.Aec.DatabaseServices.ShapeType)
Changes the shape type.

- **`type`**: The shape type.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ChangeTo(Autodesk.Aec.DatabaseServices.ShapeType,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Changes the shape type and profile.

- **`type`**: The shape type.
- **`profileId`**: The profile id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ChangeTo(Autodesk.Aec.DatabaseServices.ShapeType,Autodesk.Aec.Geometry.Profile)
Changes the shape type and profile.

- **`type`**: The shape type.
- **`profile`**: The profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ParentMassing(Autodesk.AutoCAD.DatabaseServices.ObjectId@,Autodesk.Aec.DatabaseServices.Operation@)
Gets the parent massing id and the operation.

- **`id`**: The parent massing id.
- **`operation`**: The operation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
This method throws an exception if the mass is not in a group.

### SetBody(Autodesk.Aec.Modeler.Body,System.Boolean)
Sets the body.

- **`body`**: The body.
- **`centerToLcs`**: Determines if the body is centered to the local CS.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
This function applies for objects created with the ShapeType set to BoundaryRepresentation.

### GetMaterialId(System.Int32,System.Boolean@)
Gets the material id for the specified component.

- **`component`**: The component index.
- **`wasOverridden`**: true, if the material is overriden.
