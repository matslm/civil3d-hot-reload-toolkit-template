---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertySetDefinition
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertySetDefinition
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertySetDefinition

## Summary
Represents a property set definition.

## Properties

### AppliesToFilter
Gets the object (or style) names that the set applies to.

**Returns:** Returns the object (or style) names that the set applies to.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AppliesToAll
Gets or sets whether the definition applies to all.

**Returns:** Returns whether the definition applies to all.

### ClassificationFilter
Gets the classification filter collection. Perform add/remove operations on the collection.

**Returns:** Returns the classification collection.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
When there are no classifications present, an empty collection is provided that classification definition Ids can be added to.

### IsVisible
Gets or sets the value that determines if the definition is visible.

**Returns:** Returns the value that determines if the definition is visible.

### IsWriteable
Gets or sets the value that determines if the definition is writable.

**Returns:** Returns the value that determines if the definition is writable.

### IsStyleBased
Gets the value that indicates that the definition is style based.

**Returns:** Returns true if the definition is style based.

### Definitions
Gets the collection of property definitions.

**Returns:** Returns the collection of property definitions.

## Methods

### #ctor
Initializes a new instance of the PropertySetDefinition class.

### GetValue(System.Int32,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Gets the value of the specified property.

- **`propertyId`**: The property id.
- **`id`**: The object id.
- **`blockRefPath`**: The block reference paths.

**Returns:** Returns the value of the specified property, or null if not found.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetValue(System.Int32,Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Gets the value of the specified property.

- **`propId`**: The property id.
- **`obj`**: The object.
- **`blockRefPath`**: The block reference paths.

**Returns:** Returns the value of the specified property, or null if not found.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAppliesToFilter(System.Collections.Specialized.StringCollection,System.Boolean)
Sets the object (or style) names that the set applies to.

- **`filter`**: The object (or style) names.
- **`byStyle`**: Determines if the filter is style or object based.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RecordAsModified
Triggers a message by checking if the object was opened for write.

### IsEquivalent(Autodesk.Aec.PropertyData.DatabaseServices.PropertySetDefinition)
Determines if the definition is equivalvent to the specified definition.

- **`otherDef`**: The other definition.

**Returns:** Returns true if the definition is equivalvent to the specified definition.

### SetDisplayOrder(Autodesk.Aec.PropertyData.DatabaseServices.PropertySetDefinition)
Sets the display order of the specified definition.

- **`propertyDef`**: The property definition.
- **`order`**: The new display order.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
