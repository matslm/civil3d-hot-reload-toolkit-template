---
title: Autodesk.Aec.PropertyData.ScheduleTableVariantMatrix
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > ScheduleTableVariantMatrix
---

# Autodesk.Aec.PropertyData.ScheduleTableVariantMatrix

## Summary
Represents a schedule table variant matrix.

## Properties

### NumberOfRows
Gets the number of rows.

**Returns:** Returns the number of rows.

### NumberOfColumns
Gets the number of columns.

**Returns:** Returns the number of columns.

### StyleId
Gets the style id used.

**Returns:** Returns the style id used.

## Methods

### #ctor
Initializes a new instance of the ScheduleTableVariantMatrix class.

### #ctor(System.Int32,System.Int32,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Initializes a new instance of the ScheduleTableVariantMatrix class using the specified the numbers of row and column and the style id.

- **`rows`**: The number of rows.
- **`columns`**: The number of columns.
- **`styleId`**: The style id.

### SetValue(System.Int32,System.Int32,System.Object)
Sets the value at the speficied row and column.

- **`row`**: The row.
- **`column`**: The column.
- **`variant`**: The variant to set.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### SetValue(System.Int32,System.Int32,System.Object,System.Boolean)
Sets the value at the speficied row and column.

- **`row`**: The row.
- **`column`**: The column.
- **`variant`**: The variant to set.
- **`raw`**: Determines if the row and column are raw value. When row == false, need indirection via our indexing arrays.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetValue(System.Int32,System.Int32)
Gets the variant at the specifed row and column.

- **`row`**: The row.
- **`column`**: The column.

**Returns:** Returns the variant.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### GetValue(System.Int32,System.Int32,System.Boolean)
Gets the variant at the specifed row and column.

- **`row`**: The row.
- **`column`**: The column.
- **`raw`**: Determines if the row and column are raw value. When row == false, need indirection via our indexing arrays.

**Returns:** Returns the variant.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### SwapColumns(System.Int32,System.Int32)
Swaps two columns.

- **`column1`**: The first column to be swapped.
- **`column2`**: The second column to be swapped.

**Returns:** Returns a boolean to indicate if the row or column is out of range.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

### SortRows(Autodesk.Aec.PropertyData.ScheduleTableColumnOrder[])
Sorts by row data given order.

- **`order`**: Input the order.

### SortRows(Autodesk.Aec.PropertyData.ScheduleTableColumnOrder)
Sorts by row data given order.

- **`order`**: Input the order.

### SortedRowIndex(System.Int32)
Gets the row index after being sorted.

- **`row`**: The input row.

**Returns:** Returns the row index after being sorted.

### CreateQuantity(System.Int32,System.Int32,System.Int32,System.Boolean)
Creates quantity matrix from the given, pre-sorted matrix.

- **`desiredQuantityColumn`**: The desire quantity column.
- **`dataColumn`**: The data column, dataColumn must be a numeric data type.
- **`desiredProductColumn`**: The desired product column.
- **`repeatFirstColumn`**: Indicates if repeat the first column.

**Returns:** Returns quantity matrix from the given, pre-sorted matrix.

### GetRowDataAt(System.Int32)
Gets the row data at the specifed row index.

- **`row`**: The row.

### GetRowDataAt(System.Int32,System.Boolean)
Gets the row data at the specifed row index.

- **`row`**: The row.
- **`sorted`**: Indicates if has been sorted.

### AppendRowDataAt(System.Int32,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Appends the row data at the specified row.

- **`row`**: The row.
- **`entityId`**: The id of entity.
- **`blockReferencePathIdArray`**: An id array of block reference path.

### AppendRowDataAt(System.Int32,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,System.Boolean)
Appends the row data at the specified row.

- **`row`**: The row.
- **`entityId`**: The id of entity.
- **`blockReferencePathIdArray`**: An id array of block reference path.
- **`sorted`**: Indicates if has been sorted.

### AppendRowDataAt(System.Int32,Autodesk.Aec.DatabaseServices.ObjectIdAndBlockReferencePathCollection)
Appends the row data at the specified row.

- **`row`**: The row.
- **`idAndBlockReferencePathContainer`**: A container of id and block reference path.

### AppendRowDataAt(System.Int32,Autodesk.Aec.DatabaseServices.ObjectIdAndBlockReferencePathCollection,System.Boolean)
Appends the row data at the specified row.

- **`row`**: The row.
- **`idAndBlockReferencePathContainer`**: A container of id and block reference path.
- **`sorted`**: Indicates if has been sorted.
