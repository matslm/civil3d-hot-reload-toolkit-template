---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertySetData
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertySetData
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertySetData

## Summary
Represents property set data.

## Properties

### Id
Gets or sets the property Id.

**Returns:** Returns the property Id.

### DataType
Gets or sets the property data type.

**Returns:** Returns the property data type.

### IsUnspecified
Gets or sets the value that indicates if the property is unspecified.

**Returns:** Returns the value that indicates if the property is unspecified.

### ContainsFields
Get the value that indicates if the property contains fields.

**Returns:** Returns the value that indicates if the property contains fields.

### FieldBucketId
Gets the field code Id.

**Returns:** Returns the field code Id.

### UnitType
Gets or sets the property unit type.

**Returns:** Returns the property unit type.

## Methods

### #ctor
Initializes a new instance of the PropertySetData class.

### CopyFrom(Autodesk.AutoCAD.Runtime.RXObject)
Copies property set data from the specified property set data object.

- **`other`**: The other property set data object.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetData
Gets the property data.

**Returns:** Returns the property data, or null if not found.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetData(Autodesk.Aec.DatabaseServices.UnitType)
Gets the property data.

- **`unitType`**: The unit type.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetData(System.Object)
Sets the property data.

- **`data`**: The property data.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.
- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetData(System.Object,Autodesk.Aec.DatabaseServices.UnitType)
Sets the property data.

- **`data`**: The property data.
- **`unitType`**: The unit type.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.
- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ClearFieldData
Clears the field data for the property.

### GetFieldGeneratedData(System.Boolean)
Gets the field generated data for the property.

- **`asFieldCode`**: Determines if the value returned is a field code or text.

**Returns:** Returns the field generated data for the property.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetFieldId(System.Object,Autodesk.Aec.DatabaseServices.UnitType)
Get the field id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
