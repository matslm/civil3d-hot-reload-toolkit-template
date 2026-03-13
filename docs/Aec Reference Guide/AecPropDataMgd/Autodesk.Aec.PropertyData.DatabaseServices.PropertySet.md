---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertySet
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertySet
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertySet

## Summary
Represents a property set.

## Properties

### ObjectAttachedTo
Gets or sets the id of the object that the property set is attached to.

**Returns:** The id of the object that the property set is attached to.

### PropertySetDefinition
Gets or sets the property set definition.

**Returns:** Returns the property set definition.

### PropertySetDefinitionName
Gets the property set definition name.

**Returns:** Returns the property set definition name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### PropertySetData
Gets the collection of property set data.

**Returns:** Returns the collection of property set data.

## Methods

### #ctor
Initializes a new instance of the PropertySet class.

### PropertyNameToId(System.String)
Gets the id for the specified property name.

- **`name`**: The property name.

**Returns:** Returns the id for the specified property name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### PropertyIdToName(System.Int32)
Gets the property name for the specified property id.

- **`propertyId`**: The property id.

**Returns:** Returns the property name for the specified property id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAt(System.Int32)
Gets the property data for the specified property id.

- **`propertyId`**: The property id.

**Returns:** Returns the property data for the specified property id, or null if not found.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAt(System.Int32,Autodesk.Aec.DatabaseServices.UnitType)
Gets the property data for the specified property id.

- **`propertyId`**: The property id.
- **`unitType`**: The unit type.

**Returns:** Returns the property data for the specified property id, or null if not found.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAt(System.Int32,Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets the property data for the specified property id.

- **`propertyId`**: The property id.
- **`dbObject`**: The object.

**Returns:** Returns the property data for the specified property id, or null if not found.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAt(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,System.Int32)
Gets the property data indicated by the specified object id, block reference paths, and property id.

- **`id`**: The object id.
- **`blockRefPath`**: The collection of block reference paths to uniquely refer to the object.
- **`propertyId`**: The property id.

**Returns:** Returns the property data indicated by the specified object id, block reference paths, and property id, or null if not found.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAt(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,System.Int32)
Gets the property data indicated by the specified object, block reference paths, and property id.

- **`dbObject`**: The object.
- **`blockRefPath`**: The collection of block reference paths to uniquely refer to the object.
- **`propertyId`**: The property id.

**Returns:** Returns the property data indicated by the specified object, block reference paths, and property id, or null if not found.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAt(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,System.Int32,Autodesk.Aec.DatabaseServices.UnitType)
Gets the property data indicated by the specified object, block reference paths, property id and unit type.

- **`dbObject`**: The object.
- **`blockRefPath`**: The collection of block reference paths to uniquely refer to the object.
- **`propertyId`**: The property id.

**Returns:** Returns the property data indicated by the specified object, block reference paths, property id and unit type, or null if not found.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertySetDataAt(System.Int32)
Gets the property set data for the specified property.

- **`propertyId`**: The property id.

**Returns:** Returns the property set data for the specified property.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAt(System.Int32,System.String)
Sets the property data for the specified property id.

- **`propertyId`**: The property id.
- **`data`**: The property data value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAt(System.Int32,System.Boolean)
Sets the property data for the specified property id.

- **`propertyId`**: The property id.
- **`data`**: The property data value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAt(System.Int32,System.Object)
Sets the property data for the specified property id.

- **`propertyId`**: The property id.
- **`data`**: The property data value.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.
- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAt(System.Int32,System.Object,Autodesk.Aec.DatabaseServices.UnitType)
Sets the property data for the specified property id.

- **`propertyId`**: The property id.
- **`data`**: The property data value.
- **`unitType`**: The unit type.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.
- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAt(System.Int32,System.Int32)
Sets the property data for the specified property id.

- **`propertyId`**: The property id.
- **`data`**: The property data value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAt(System.Int32,System.Double)
Sets the property data for the specified property id.

- **`propertyId`**: The property id.
- **`data`**: The property data value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAt(System.Int32,System.Double,Autodesk.Aec.DatabaseServices.UnitType)
Sets the property data for the specified property id.

- **`propertyId`**: The property id.
- **`data`**: The property data value.
- **`unitType`**: The unit type.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Synchronize(Autodesk.Aec.PropertyData.DatabaseServices.PropertySetDefinition,Autodesk.AutoCAD.DatabaseServices.DBObject)
Synchronizes the property set by updating its state.

- **`propertySetDefinition`**: The property set definition.
- **`db`**: The database.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetCurrentAutoIncrementValue(Autodesk.Aec.PropertyData.DatabaseServices.PropertySetDefinition,System.Int32)
Gets the highest value across all property sets that use the specified definition.

- **`propertySetDefinition`**: The property set definition.
- **`propertyId`**: The property id.

**Returns:** Returns the current auto-increment value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetCurrentAlphaIncrementValue(Autodesk.Aec.PropertyData.DatabaseServices.PropertySetDefinition,System.Int32)
Gets the current alpha-increment value.

- **`propertySetDefinition`**: The property set definition.
- **`propertyId`**: The property id.

**Returns:** Returns the current alpha-increment value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CompareAlphaIncrementValues(System.String,System.String)
Compares two alpha-increment values.

- **`string1`**: The first alpha-increment value.
- **`string2`**: The second alpha-increment value.

**Returns:** A value representing the result of the comparison.

**Remarks:**
Returns -1 if string1 < string2.  Returns  0 if string1 = string2.  Returns  1 if string1 > string2.

### IncrementAlphaValue(System.String)
Increments the specified alphabetical value.

- **`alpha`**: The alphabetical value.

**Returns:** The incremented alphabetical value.

**Remarks:**
Assumes that all characters in the string are either upper or lower case.

### UpdateAutoIncrementProperties
Updates the auto-increment properties.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### UpdateReferencingAttributes
Updates the referencing attributes.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetValueAndUnitAt(System.Int32)
Gets the property value and unit type for the specified property id.

- **`propertyId`**: The property id.

**Returns:** Returns the property value and unit type for the specified property id, or null if not found.

- **Exception `T:System.NotSupportedException`**: System.NotSupportedException.
- **Exception `T:System.Runtime.InteropServices.InvalidOleVariantTypeException`**: System.Runtime.InteropServices.InvalidOleVariantTypeException.
- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetValueAndUnitAt(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,System.Int32)
Gets the property value and unit type for the specified property id.

- **`id`**: The object id.
- **`blockRefPath`**: The collection of block reference paths to uniquely refer to the object.
- **`propertyId`**: The property id.

**Returns:** Returns the property value and unit type for the specified property id, or null if not found.

- **Exception `T:System.NotSupportedException`**: System.NotSupportedException.
- **Exception `T:System.Runtime.InteropServices.InvalidOleVariantTypeException`**: System.Runtime.InteropServices.InvalidOleVariantTypeException.
- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
