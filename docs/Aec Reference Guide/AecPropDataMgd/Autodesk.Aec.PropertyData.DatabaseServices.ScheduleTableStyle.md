---
title: Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyle
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > ScheduleTableStyle
---

# Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyle

## Summary
Represents a Schedule Table Style.

## Properties

### Title
Gets or sets the title.

**Returns:** The title.

### AppliesToFilter
Gets the entity filter.

**Returns:** The entity filter.

### EntityFilter
Sets the entity filter.

### Tree
Gets the tree.

**Returns:** The tree.

### Columns
Get the columns.

### Sortings
Get the sortings.

### AppliesToAll
Gets or sets applies to all.

### ClassificationFilter
Gets the classification filter.

**Returns:** The classification filter.

### DefaultCellFormat
Default cell format.

**Returns:** The default cell format.

### ColumnHeaderFormat
Column header format.

**Returns:** The column header format.

### MatrixHeaderFormat
Matrix header format.

**Returns:** The matrix header format.

### GroupHeaderFormat
Group header format.

**Returns:** The group header format.

### TotalHeaderFormat
Total header format.

**Returns:** The total header format.

### TitleFormat
Gets the title format.

### QuantityColumnHeading
Gets the quantity heading.

### HasQuantityColumn
Has quantity column.

**Returns:** True if has quantity column, false otherwise.

### HasFormulaColumn
Has formula column.

**Returns:** True if it has formula column, false otherwise.

### QuantityColumnNumber
Gets quantity column number.

**Returns:** The quantity column number.

### FormulaColumnTotalNumber
Gets the formula column total number.

**Returns:** The formula column total number.

### NextFormulaId
Gets next formula id.

**Returns:** The formula id.

### RepeatFirstColumn
Gets or sets the repeat first column.

## Methods

### #ctor
Initializes a new instance of the ScheduleTableStyle class.

### RemapFormulaColumnIds(Autodesk.Aec.PropertyData.DatabaseServices.PropertySetDefinition,Autodesk.Aec.PropertyData.DatabaseServices.PropertySetDefinition,Autodesk.AutoCAD.Geometry.IntegerCollection,Autodesk.AutoCAD.Geometry.IntegerCollection,Autodesk.AutoCAD.Geometry.IntegerCollection)
Remap formulat column ids.

- **`propertySetDefinition1`**: The first property set definition.
- **`propertySetDefinition2`**: The second property set definition.
- **`definition1PropertyIds`**: The first definition property id collection.
- **`definition2PropertyIds`**: The second definition property id collection.
- **`actions`**: The actions.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### FormatColumnVariant(System.Object,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Format column variant.

- **`data`**: The variant data.
- **`formatId`**: The format id.

**Returns:** The formated column variant.

### FormatColumnVariant(System.Object,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32)
Format column variant.

- **`data`**: The variant data.
- **`formatId`**: The format id.
- **`column`**: The column.

**Returns:** The formated column variant.

### AddClassification(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Add classification.

- **`classificationId`**: The classificationId.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveClassification(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Remove classification.

- **`classificationId`**: The classificationId.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetColumnFormat(System.Int32)
Gets the column format.

- **`column`**: The column.

**Returns:** The column format.

### SwapSortings(System.Int32,System.Int32)
Swap sorting.

- **`index1`**: The first index.
- **`index2`**: 

### AddQuantityColumn(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn)
Add quantity column.

- **`column`**: The column.

### AddFormulaColumn(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn)
Add formula column.

- **`column`**: The column.

### IsQuantityColumn(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn)
Is quantity column.

- **`column`**: The column.

**Returns:** True if it is quantity column, false otherwise.

### IsFormulaColumn(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleColumn)
Is formula column.

- **`column`**: The column.

**Returns:** True if it is formula column, false otherwise.

### SetValidityFlags
Sets the validity flags.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
