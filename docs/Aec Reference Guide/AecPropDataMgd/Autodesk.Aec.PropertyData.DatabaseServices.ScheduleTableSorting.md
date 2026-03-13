---
title: Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableSorting
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > ScheduleTableSorting
---

# Autodesk.Aec.PropertyData.DatabaseServices.ScheduleTableSorting

## Summary
Represents a schedule table sorting.

## Properties

### SortOrder
Gets or sets the sort order.

**Returns:** The sort order.

### UseGroupHeader
Gets or sets the use group header.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GroupHeader
Gets or sets the group header.

### UseSubTotalHeader
Gets or sets if use sub total header.

### SubTotalHeader
Gets or sets the sub total header.

### FormulaColumn
Gets or sets formula column.

## Methods

### #ctor
Initializes a new instance of the ScheduleTableSorting class.

### GetColumnPropertySetDefinitionObjectId
The column object id.

**Returns:** The column object id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetColumnPropertyId
Gets the column property id.

**Returns:** The column property id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetColumn(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32,System.Boolean)
Sets the column.

- **`propertySetDefinitionId`**: The property set definition id.
- **`propertyId`**: The property id.
- **`isFormulaColumn`**: Is formula column.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
