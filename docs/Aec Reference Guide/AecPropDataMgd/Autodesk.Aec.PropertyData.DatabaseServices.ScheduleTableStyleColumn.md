---
title: Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > ScheduleTableStyleColumn
---

# Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn

## Summary
Represents a Schedule Table Style Column.

## Properties

### DefaultData
Gets or sets the default data.

**Returns:** Returns the default data.

### Heading
Gets or sets the heading.

**Returns:** The heading.

### FormatId
Gets the format id.

**Returns:** Returns the format id.

### PropertySetDefinitionId
Gets the propertyset definition id.

**Returns:** Returns the propertyset definition id.

### PropertySetDefinitionId(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Sets the propertyset definition id.

- **`propertySetDefinitionId`**: The propertyset definition id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### PropertyId
Gets or sets the property id.

**Returns:** Returns  the property id.

### Matrix
Gets or sets the schedule table variant matrix.

**Returns:** Returns the schedule table variant matrix.

### MaxMatrixCols
Gets the maximum of matrix columns.

**Returns:** Returns the maximum of matrix columns.

### MaximumMatrixColumns
Sets the maximum of matrix columns.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Total
Gets or sets the total.

**Returns:** Returns the total.

### FormulaTotal
Gets or sets the formula total.

**Returns:** Returns the formula total.

### ColumnType
Gets or sets the column type.

**Returns:** Return the column type.

### CellFormatOverride
Gets or sets the schedule table cell format override.

**Returns:** Returns the schedule table cell format override.

### PropertyName
Gets the property name.

**Returns:** Returns the property name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### PropertySetDefinitionName
Gets the property name.

**Returns:** Returns the property name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### FullPropertyName
Gets the property full name.

**Returns:** Returns the property full name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IsPropertyValid
Indicates if the property is valid.

**Returns:** Returns true if the property is valid, false otherwise.

### HideColumn
Indicates if the column is hide.

**Returns:** Return true, if the column is hide, false otherwise.

### Formula
Gets or sets the property defination formula.

**Returns:** Returns the property defination formula.

## Methods

### #ctor
Initializes a new instance of the ScheduleTableStyleColumn class.

### SetFormatId
Sets the format id.

**Returns:** The format id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CheckPropertyValid
Checks if the property is valid.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Evaluate
Evaluates the formula and return result with Quantity.

**Returns:** Returns the variant.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Evaluate(System.String&,System.Int32)
Evaluates the formula and return result with Quantity.

- **`formula`**: The formula string.
- **`quantity`**: The quantity.

**Returns:** Returns the variant.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
