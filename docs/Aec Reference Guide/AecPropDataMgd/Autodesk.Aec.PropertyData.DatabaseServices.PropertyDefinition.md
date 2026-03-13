---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinition
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertyDefinition
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinition

## Summary
Represents a property definition.

## Properties

### Name
Gets or sets the name.

**Returns:** Returns the name.

### GlobalName
Gets or sets the global name.

**Returns:** Returns the global name.

### Id
Gets or sets the Id.

**Returns:** Returns the Id.

### DataType
Gets or sets the data type.

**Returns:** Returns the data type.

### DefaultData
Gets or sets the default data.

**Returns:** Returns the default data, or null if not found.

### FormatId
Gets or sets the format Id.

**Returns:** Returns the format Id.

### FormatString
Gets the format string.

**Returns:** Returns the format string.

### ExampleString
Gets the example string.

**Returns:** Returns the example string.

### ListDefinitionId
Gets or sets the list definition id.

**Returns:** Returns the list definition id.

### IsAutomatic
Gets the value indicating if the property is automatic.

**Returns:** Returns the value indicating if the property is automatic.

### Automatic
Sets the value indicating if the property is automatic.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DefaultIsUnspecified
Gets or sets the value indicating if the default value is unspecified.

**Returns:** Returns the value indicating if the default value is unspecified.

### IsLocked
Gets or sets whether the property definition is locked.

**Returns:** Returns whether the property definition is locked.

### ContainsFields
Gets the value that indicates if the property definition contains fields.

**Returns:** Returns the value that indicates if the property definition contains fields.

### FieldBucketId
Gets the field code Id.

**Returns:** Returns the field code Id.

### UnitType
Gets or sets the unit type.

**Returns:** Returns the unit type.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Applies only to manual property definitions with the data type Real.

### IsReadOnly
Gets or sets whether the property definition is read-only.

**Returns:** Returns whether the property definition is read-only.

### IsVisible
Gets or sets whether the property definition is visible.

**Returns:** Returns whether the property definition is visible.

### DisplayOrder
Gets the display order of the property definition.

**Returns:** Returns the display order of the property definition.

## Methods

### #ctor
Initializes a new instance of the PropertyDefinition class.

### ClearAutomaticData
Clears automatic data.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAutomaticData(System.String,System.String)
Sets automatic data. If the function name is not found, a KeyNotFound exception is thrown.

- **`className`**: The object type name. This is a string similar to the AppliesTo values. It is the internal class/type name. For example: AecDbWall.
- **`sourceName`**: The source name. This is the same name (aka function name) as provided in the ACA UI.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAutomaticData
Gets the automatic data.

**Returns:** Returns the automatic data.

### RemoveAutomaticData(System.String)
Removes automatic data based on the class name.

- **`className`**: The class name to search for.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Value(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Determines the value of the property.

- **`id`**: The id of the object.
- **`blockRefPath`**: The block reference paths Ids.

**Returns:** Returns the value of the property, or null if not found.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Value(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Determines the value of the property.

- **`dbObject`**: The object.
- **`blockRefPath`**: The block reference paths Ids.

**Returns:** Returns the value of the property, or null if not found.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetSampleValue
Gets a sample value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetSampleValue(Autodesk.Aec.DatabaseServices.UnitType)
Gets a sample value for the given unit type.

- **`unitType`**: The unit type.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Synchronize(Autodesk.Aec.PropertyData.DatabaseServices.PropertySet,Autodesk.Aec.PropertyData.DatabaseServices.PropertySetDefinition,Autodesk.AutoCAD.DatabaseServices.DBObject)
Synchronizes the property definition by updating its state.

- **`propertySet`**: The property set.
- **`definition`**: The property set definition.
- **`attachedTo`**: The object attached to.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
The attachedTo parameter is not used.

### References(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32)
Determines if this property definition references the specified property definition.

- **`propertySetDefinitionId`**: The other property set definition.
- **`propertyDefinitionId`**: The other property definition Id.
- **`propertySetDefinitionId2`**: This property set definition.
- **`propertyDefinitionId2`**: This property definition Id.

**Returns:** Returns true if this property definition references the specified property definition.

### ClearFieldData
Clears the field data.

### GetFieldGeneratedData(System.Boolean)
Get the field generated data.

- **`asFieldCode`**: Determines if the value returned is a field code or text.

**Returns:** Returns the field generated data, or null if not found.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetFieldId
Get the field id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
