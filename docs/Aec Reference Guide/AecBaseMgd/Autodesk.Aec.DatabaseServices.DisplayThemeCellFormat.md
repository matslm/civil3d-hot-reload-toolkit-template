---
title: Autodesk.Aec.DatabaseServices.DisplayThemeCellFormat
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplayThemeCellFormat
---

# Autodesk.Aec.DatabaseServices.DisplayThemeCellFormat

## Summary
Represents a display theme cell format.

## Properties

### TextStyleId
Gets or sets text style id.

**Returns:** Text style id.

### TextStyleIdString
Gets test style id string.

**Returns:** Text style id string.

### Height
Gets or sets height.

**Returns:** Height.

### Gap
Gets or sets gap.

**Returns:** Gap.

### RotationType
Gets or sets rotation type.

**Returns:** Rotation type.

### ThemeSymbolType
Gets or sets theme symbol type.

**Returns:** Theme symbol type.

## Methods

### #ctor
Initializes a new instance of the DisplayThemeCellFormat class.

### ScaleBy(System.Double)
Scale by.

- **`scale`**: Scale.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetWidth(System.String)
Gets the extents width.

- **`text`**: Text.

### GetHeight(System.String)
Gets the extents height.

- **`text`**: Text.

### GetCellHeightWithFixedWidth(System.String,System.Double)
Gets cell height.

- **`text`**: Text.
- **`fixedWidth`**: Fixed width.

**Returns:** Cell height.

### GetActualTextHeight(System.String,System.Double)
Gets actual text height.

- **`text`**: String text.
- **`textHeightScale`**: Text height scale.

**Returns:** Actual text height.

### GetRotatedTextCellWidth(System.String,System.Double)
Gets rotated text cell width.

- **`text`**: String.
- **`fixedWidth`**: Fixed width.

**Returns:** Rotated text cell width.

### GetSymbolWidth(System.Int32)
Gets the symbol width.

- **`count`**: Count.

### GetSymbolHeight(System.Int32)
Gets the symbol height.

- **`count`**: Count.
