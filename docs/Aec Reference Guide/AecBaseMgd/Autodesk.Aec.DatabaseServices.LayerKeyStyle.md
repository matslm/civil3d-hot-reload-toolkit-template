---
title: Autodesk.Aec.DatabaseServices.LayerKeyStyle
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > LayerKeyStyle
---

# Autodesk.Aec.DatabaseServices.LayerKeyStyle

## Summary
Represents a layer key style.

## Properties

### OverrideCount
Gets the override count.

**Returns:** Returns the override count.

### Standard
Gets or sets the name of the layer standard on which to base the key style.

**Returns:** Returns the name of the layer standard on which to base the key style.

### OverridesEnabled
Determines if overrides are enabled.

**Returns:** Returns true if overrides are enabled.

**Remarks:**
Specifies whether override values are applied to newly generated key-based layers.

### KeyDefinitions
Gets all key definitions in the layer key definition..

## Methods

### #ctor
Initializes a new instance of the LayerKeyStyle class.

### OverrideExists(System.String)
Determines if the specified override key exists.

- **`name`**: The override key name.

**Returns:** Returns true if the specified override key exists.

### GetOverrideAt(System.String,System.String)
Gets the override value for the specified key name.

- **`name`**: The override key name.
- **`value`**: The override value.

**Returns:** Returns the override value for the specified key name.

**Remarks:**
The name will be equivalent to a descriptive field from the layer standard on which this key style is based.

### GetOverrideAt(System.Int32,System.String,System.String)
Gets the override key name and value at the specified index.

- **`index`**: The index.
- **`name`**: The key name.
- **`value`**: The value.

**Returns:** Returns the override key name and value at the specified index.

- **Exception `T:System.ArgumentOutOfRangeException`**: System.ArgumentOutOfRangeException.

**Remarks:**
The name will be equivalent to a descriptive field from the layer standard on which this key style is based.

### SetOverrideAt(System.String,System.String)
Sets the override value for the specified key name.

- **`name`**: The key name.
- **`value`**: The value.

**Remarks:**
The name will be equivalent to a descriptive field from the layer standard on which this key style is based.

### SetOverrideAt(System.Int32,System.String)
Sets the override value at the specified index.

- **`index`**: The index.
- **`value`**: The value.

**Remarks:**
The name will be equivalent to a descriptive field from the layer standard on which this key style is based.
