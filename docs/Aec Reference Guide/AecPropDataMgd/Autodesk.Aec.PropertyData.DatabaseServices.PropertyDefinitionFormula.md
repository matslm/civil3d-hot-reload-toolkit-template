---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionFormula
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertyDefinitionFormula
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertyDefinitionFormula

## Summary
Represents a formula property definition.

## Remarks
Using a formula property definition, you can reference other properties and do custom calculation.  Before you can specify the formula string, you need to make sure it is added to a property set definition. This property set definition should be added to database, in other words, should have an object id. It is designed this way because we need to see whether a referenced property is local.  A local property means a property definition which has the same parent with the formula definition.  They belong to the same property set definition.  Local property is referenced without the scope definition like this "[PropertyName]". If you are referencing a property outside the parent property set definition, you need to specify the scope like this "[OtherPropertySetName:PropertyName]".

## Properties

### FormulaString
Gets the formula string. This is the equivalent of GetFormulaString().

**Returns:** Returns the formula string.

### UseFormulaForDescription
Gets or sets whether the formula string should be used as description of this property.

**Returns:** Returns whether the formula string should be used as description of this property.

### DisplayString
Gets the display string of the formula.

**Returns:** Returns the display string of the formula.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DisplayStringClean
Gets the display string of the formula. This property differs from the DisplayString property by removing the helper strings from the formula. E.g. &gt;Helper&lt;,&gt;/Helper&lt;

**Returns:** Returns the display string of the formula with helper strings cleaned.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### HasQuantity
Gets whether this formula contains quantity property.

**Returns:** Returns whether this formula contains quantity property.

### EnableQuantity
Gets or sets whether this formula can contain quantity property.

**Returns:** Returns whether this formula can contain quantity property.

### DataItems
Gets data items which support the formula calculation.

**Returns:** The data items which support the formula calculation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
When you call SetFormulaString to parse the formula string, it also constructs an array of data which stores the source of values.  When we evaluate the formula property, it uses this array to find values of the referenced properties and then accomplish the evaluation.  You can modify the items in this array directly.

## Methods

### #ctor
Initializes a new instance of the PropertyDefinitionFormula class.

### GetFormulaString
Gets the formula string.

**Returns:** Returns the formula string.

### SetFormulaString(System.String)
Sets the formula string.

- **`formula`**: The formula string.

**Returns:** True if the formula string is correctly parsed.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
This function parses the formula string and builds an array of data items (see DataItems property) to support the formula calculation.  Please make sure that this formula property is added to a property set definition which has an object id (or we say "is added to database") before you call SetFormulaString. Otherwise, an exception will be thrown.

### Value(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,System.Int32)
Gets the value by evaluating the formula with specified quantity.

- **`dbObject`**: The object.
- **`blockRefPath`**: The block reference path ids.
- **`quantity`**: The quantity.

**Returns:** The value of the calculation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
