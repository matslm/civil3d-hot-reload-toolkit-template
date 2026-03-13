---
title: Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTable
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > ScheduleTable
---

# Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTable

## Summary
Represents a schedule table.

## Properties

### Title
The title.

**Returns:** The title.

### LayerWildcard
Gets or sets the layer wild card.

**Returns:** The layer wild card.

### SelectionSet
Gets the seletion set.

**Returns:** The selection set.

### AddNewEntriesAutomatically
If add new entities automatically.

**Returns:** True if success, false otherwise.

### ScanBlockReferences
Gets or sets if scan block references.

**Returns:** True if scan block references, false otherwise.

### ScanExternalReferences
Gets or sets if scan external references.

**Returns:** True if scan external references, false otherwise.

### AutomaticUpdate
Gets or sets automatic update.

### IsOutOfDate
Gets if it is out of data.

### Scale
Scale.

**Returns:** Scale.

### XFormMatrix
Gets the xform matrix.

### ColumnCount
Gets the column count.

### RowCount
Gets the row count.

### TotalRow
Total row.

**Returns:** Total row.

### MatrixHeaderHeight
Get matrix header height.

### HeaderHeight
Gets header height.

### TotalRowHeight
Gets total row height.

### UpperLeftPoint
Gets upper left point.

### LowerLeftPoint
Gets lower left point.

### UpperRightPoint
Gets the upper right point.

### LowerRightPoint
Gets the lower right point.

### CenterPoint
Get the center point.

### TableWidth
Gets the table width.

### TableHeight
Gets the table height.

### TitleHeight
Gets the title height.

### TitleIsHorizontal
Gets the title is horizontal.

### TitleWidth
Gets the title width.

### TitleHeightOffset
Gets the title height offset.

**Returns:** The title height offset.

### TitleWidthOffset
Gets the title width offset.

### PageDirection
Gets or sets page direction.

### PageSpacing
Gets or sets the page spacing.

**Returns:** The page spacing.

### RepeatTitle
Gets or sets repeat title.

### RepeatHeaders
Gets or sets repeat headers.

**Returns:** Repeat headers.

### UseManualHeights
Gets or sets use manual heights.

**Returns:** Use manual heights.

### PageMaxHeight
Gets or sets the page max height.

**Returns:** The page max height.

### BasePageWidth
Gets the base page width.

**Returns:** The base page width.

### MinimumRowHeight
Gets the minimum row height.

**Returns:** The minimum row height.

### ScheduleDrawing
Gets or sets the schedule drawing.

**Returns:** The schedule drawing.

### IsModelGeometry
Gets is model geometry.

**Returns:** True if it is model geometry, false otherwise.

### PageMaxHeights
Gets page max heights.

**Returns:** The page max heights.

## Methods

### #ctor
Initializes a new instance of the ScheduleTable class.

### SetSelectionSet(Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Set the selection set.

- **`entityIds`**: The entity object idcollection.
- **`entityFiltered`**: The entity filted.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddToSelectionSet(Autodesk.AutoCAD.DatabaseServices.Entity)
Add entity to section set.

- **`entity`**: The entity.

**Returns:** True if success, false if it is rejected.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddToSelectionSet(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Add entity id to selection set.

- **`entityId`**: The entity id.

**Returns:** If it is filted.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddToSelectionSet(Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Add entity id collection to selection set.

- **`entityIds`**: The entity id collection.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveFromSelectionSet(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Remove from selection Set.

- **`entityId`**: The entity id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RegenerateTable(System.Boolean)
Regenerate table.

- **`forceUpdate`**: Force update.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RegenerateSampleTable(System.Boolean)
Regenerate sample table.

- **`forceUpdate`**: Force update.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ObjectsAtRow(System.Int32)
Objects at row.

- **`row`**: The row.

### CellText(System.Int32,System.Int32)
Cell text.

- **`row`**: Row.
- **`column`**: Column.

**Returns:** Cell text.

### CellData(System.Int32,System.Int32)
Cell data.

- **`row`**: Row.
- **`column`**: Column.

**Returns:** The cell data.

### SetCellData(System.Int32,System.Int32,System.Object)
Set cell data.

- **`row`**: Row.
- **`column`**: Column.
- **`cvar`**: Cvar.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RowHeight(System.Int32)
Row height.

- **`row`**: The row.

**Returns:** The row height.

### RowHeightSum(System.Int32)
Row height sum.

- **`row`**: The row.

### GetMarker(System.Int32,System.Int32)
Get marker.

- **`row`**: The row.
- **`column`**: The column.

**Returns:** The marker.

### GetRow(System.IntPtr)
Get row.

- **`pickedMarker`**: Picked marker.

**Returns:** The row.

### GetColumn(System.IntPtr)
Get column.

- **`pickedMarker`**: The picked marker.

**Returns:** Get column.

### GetRowMarkers(System.Int32)
Gets row markers.

- **`row`**: The row.

### GetColumnMatrix(System.Int32)
Gets column matrix.

- **`index`**: The index.

**Returns:** The column matrix.

### GetHeaderPosition(Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableStyleHeaderNode)
Gets header position.

- **`node`**: The node.

**Returns:** The header position.

### GetHeaderPositionIterator
Gets the header position iterator.

**Returns:** The header position.

### GetPageBreaks
Gets page breaks.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPageWidths
Gets the page widths.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPageHeights
Gets page heights.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetScheduleDrawingName
Gets the schedule drawing name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetScheduleDrawingName(System.Boolean)
Gets schedule drawing name.

- **`fullPathIfRelative`**: Full path if relative.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetScheduleDrawingName(System.String)
Sets the schedule drawing name.

- **`scheduleDrawingName`**: The schedule drawing name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### EvaluateFieldCodes
Evaluate field codes.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ForceUseCachedData(System.Boolean)
Force use cached data.

- **`forceUseCache`**: If force use cache.

### GetRasterImageId(System.Object)
Gets raster image id.

- **`varValue`**: The variant value.

**Returns:** The raster image id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
