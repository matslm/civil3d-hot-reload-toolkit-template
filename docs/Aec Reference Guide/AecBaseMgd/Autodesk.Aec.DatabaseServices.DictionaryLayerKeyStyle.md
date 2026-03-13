---
title: Autodesk.Aec.DatabaseServices.DictionaryLayerKeyStyle
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DictionaryLayerKeyStyle
---

# Autodesk.Aec.DatabaseServices.DictionaryLayerKeyStyle

## Summary
Represents a layer key style dictionary.

## Methods

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database)
Initializes a new instance of the DictionaryLayerKeyStyle class using the specified database.

- **`db`**: The database.

### GetStandardStyle(Autodesk.AutoCAD.DatabaseServices.Database)
Gets the standard style id.

- **`db`**: The database.

**Returns:** Returns the standard style id.

### GenerateLayer(System.String)
Generates the layer for the specified layer key.

- **`layerKey`**: The layer key name.

**Returns:** The layer id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
Creates the Layer using the current Layer Key Style.  If the Layer exists already the ObjectId of that existing layer is returned.  If the LayerKey does not exist in the Style or there is no current Layer Key Style the ObjectId of the current later is returned.
