---
title: Autodesk.Aec.DatabaseServices.Entity
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > Entity
---

# Autodesk.Aec.DatabaseServices.Entity

## Summary
Represents an AEC entity.

## Properties

### Overrides
Gets Overrides.

### DisplayName
Gets the display name.

**Returns:** Returns the display name.

### TypeIcon
Gets the type icon.

**Returns:** Returns the type icon.

### Description
Gets or sets the description.

**Returns:** Returns the description.

### ProjectState
Gets or sets the project state.

**Returns:** Returns the project state.

### LayerKey
Gets the layer key.

**Returns:** Returns the layer key.

**Remarks:**
The LayerKey method returns the default Layer Key name for the object.  For example, a MassElement has the default Layer Key of "MASSELEM".

### Classifications
Gets the classification collection. Perform add/remove operations on the collection.

**Returns:** Returns the classification collection.

**Remarks:**
When there are no classifications present, an empty collection is provided that classification definition Ids can be added to.

### StyleId
Gets or sets the style id.

**Returns:** Returns the style id.

### SupportsBaseCurveCommands
Gets the value indicating if base curve commands are supported.

**Returns:** Returns the value indicating if base curve commands are supported.

### BaseCurve
Gets the base curve.

**Returns:** Returns the base curve.

### SupportsProfileCommands
Gets the value indicating if profile commands are supported.

**Returns:** Returns the value indicating if profile commands are supported.

### NeedsPromoting
Gets or sets the value indicating that promoting is needed.

**Returns:** Returns the value indicating that promoting is needed.

### SwappingReferences
Gets or sets the value indicating that references are being swapped.

### AutomaticallyBoundSpaces
Gets or sets whether this object acts as an automatic space boundary.

**Returns:** AutomaticSpaceBoundary.Yes indicates it will act as an automatic space boundary.  AutomaticSpaceBoundary.No indicates it will NOT act as an automatic space boundary.  AutomaticSpaceBoundary.ByStyle indicates it the style governs whether it can act as an automatic space boundary.  AutomaticSpaceBoundary.NotApplicableToThisObject indicates it can not act as an automatic space boundary.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IsHighlighting
Gets whether the entity is keeping highlighted.

**Returns:** Returns whether the entity is keeping highlighted.

## Methods

### SetDefaultLayer()
Uses the default layer key for an AEC entity and sets the layer. It also generates the layer if it does not exist.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetMaterialComponents(Autodesk.AutoCAD.Geometry.IntegerCollection@,System.Collections.Specialized.StringCollection@,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@)
Returns the component ids, component names, and material ids.

- **`componentIds`**: The component ids.
- **`componentNames`**: The component names.
- **`materialIds`**: The material ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
The order of the items in the array must be the same as in SetMaterialComponents.

### SetMaterialComponents(Autodesk.AutoCAD.Geometry.IntegerCollection,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Sets the component ids and material ids.

- **`componentIds`**: The component ids.
- **`materialIds`**: The material ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetMaterialLocations(Autodesk.AutoCAD.Geometry.IntegerCollection@,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@)
Returns the location ids and material style ids.

- **`locationIds`**: The location ids.
- **`styleIdArray`**: The style ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetToStandard(Autodesk.AutoCAD.DatabaseServices.Database)
Initializes data to realistic values after object construction.

- **`db`**: The database.

### GetLocalModelCachedExtents(Autodesk.AutoCAD.Geometry.BoundBlock3d@)
Gets a bound block representing the local model cached extents.

- **`extents`**: The extents.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetLocalModelExtentsDirty
Sets the local model extents dirty flag.

### GetLocalExtents(Autodesk.AutoCAD.Geometry.BoundBlock3d@)
Gets a bound block representing the local extents.

- **`extents`**: The extents.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetLocalExtents(Autodesk.AutoCAD.Geometry.BoundBlock3d,System.Int32)
Sets the bound block representing the local extents.

- **`extents`**: The extents.
- **`flags`**: The extent options.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
0:AcceptAll, 1:IgnoreX, 2:IgnoreY, 4:IgnoreZ.

### GetWorldExtents(Autodesk.AutoCAD.Geometry.BoundBlock3d@)
Returns the extents in WCS.

- **`extents`**: The extents.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetWorldExtents(Autodesk.AutoCAD.Geometry.BoundBlock3d)
Sets the extents in WCS.

- **`extents`**: The extents.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

**Remarks:**
This method is virtual and does not have a base implementation. It will always throw the eNotApplicable exception, unless it is overridden.

### GetAutomaticallyBoundSpaces(NAMESPACE_ACDB::ObjectIdCollection^,[System::Runtime::InteropServices::OutAttribute]NAMESPACE_AECDB::AutomaticSpaceBoundary%)
Gets the bound spaces property, in the context of blockRefPath.

- **`blockRefPath`**: The block ref path.
- **`boundSpaces`**: The current value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetAutomaticallyBoundSpaces(NAMESPACE_ACDB::ObjectIdCollection^,NAMESPACE_AECDB::AutomaticSpaceBoundary)
Sets the bound spaces property. If blockRefPath is not empty this will store the new value as an override on the topmost block ref.

- **`blockRefPath`**: The block ref path.
- **`boundSpaces`**: The new value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetProfile(Autodesk.AutoCAD.Geometry.Plane)
Get the profile resulting from the cut plane.

- **`cutPlane`**: The cut plane.

**Returns:** Returns the profile resulting from the cut plane.

### GetUsageArea(Autodesk.AutoCAD.Geometry.Plane)
Gets the usage area resulting from the cut plane.

- **`cutPlane`**: The cut plane.

**Returns:** Returns the usage area resulting from the cut plane.

### GetBaseProfile(Autodesk.AutoCAD.Geometry.Matrix3d@)
Gets the base profile.

- **`toWcs`**: The WCS transformation matrix.

**Returns:** Returns the base profile.

### SetBaseProfile(Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.Matrix3d)
Sets the base profile.

- **`profile`**: The base profile.
- **`matrix`**: The transformation matrix.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
