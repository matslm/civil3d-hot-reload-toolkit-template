---
title: Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableCellFormat
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > ScheduleTableCellFormat
---

# Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableCellFormat

## Summary
Represents a Schedule table cell format.

## Properties

### TextStyleId
Gets the text style id.

**Returns:** The text style id.

### TextStyleIdString
Gets the text style id string.

### Alignment
Gets or sets the alignment.

### Width
Gets or sets the width.

**Returns:** The width.

### Height
Gets or sets the height.

### Gap
Gets or sets the gap.

### RotationType
Gets or sets the rotation type.

### MatrixSymbolType
Gets or sets the matrix symbol type.

### UseMatrixForTrueFalse
Gets or sets the use matrix for true false.

## Methods

### #ctor
Initializes a new instance of the ScheduleTableCellFormat class.

### ExtentsWidth(System.String)
Extents width.

- **`string`**: The string.

**Returns:** The width.

### ExtentsHeight(System.String)
Extents height.

- **`string`**: The string.

**Returns:** The extented height.

### ExtentsCellWidth(System.String)
Extents cell width.

- **`string`**: The string.

**Returns:** The extented cell width.

### ExtentsCellHeight(System.String)
Extents cell height.

- **`string`**: The string.

**Returns:** The extented cell height.

### CellHeight(System.String,System.Double)
Cell height.

- **`string`**: The string.
- **`fixedWidth`**: The fixed width.

**Returns:** The cell height.

### GetRotatedTextCellWidth(System.String,System.Double)
Gets the rotated text cell width.

- **`string`**: The string.
- **`fixedWidth`**: The fixed width.

**Returns:** The rotated text cell width.

### MatrixExtentsCellWidth(System.Int32)
Matrix extents cell width.

- **`count`**: The count.

**Returns:** The matrix extents cell width.

### MatrixExtentsCellHeight(System.Int32)
The matrix extents cell height.

- **`count`**: The count.

**Returns:** The matrix extents cell height.
