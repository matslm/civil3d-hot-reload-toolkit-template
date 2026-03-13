---
title: Autodesk.Aec.DatabaseServices.DisplayRepresentation
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplayRepresentation
---

# Autodesk.Aec.DatabaseServices.DisplayRepresentation

## Summary
Represents a display representation base class.

## Properties

### WorksWith
Gets the class that works with current display representation.

**Returns:** Returns the class that works with current display representation.

### DefaultVisibility
Gets or sets to know whether current display representation is default visible or not.

**Returns:** True if current display representation is default visible, otherwise false.

### ViewTypeDisplayName
Gets the view type display name.

**Returns:** Returns the view type display name.

### DisplayRepresentationName
Gets the display representation name.

**Returns:** Returns the display representation name.

### DefaultDisplayPropertiesId
Gets or sets the default display properties.

**Returns:** Returns the default display properties.

### DisplayPropertiesClass
Gets the run time extension class type of display properties.

**Returns:** Returns the run time extension class type of display properties.

### UseObjectSnapCache
Gets whether the display representation uses object snap caching or not.

**Returns:** True if the display representation uses object snap caching.

### IsSimilarTo
Gets the isSimilarTo value.

**Returns:** The isSimilartTo string.

### HasReliableGsMarkers
Gets to know whether the display representation has reliable Gs markers.

**Returns:** True if it has reliable Gs markers.

### BaseGsMarkerValue
Gets the base Gs marker value for this display representation.

**Returns:** Returns the base Gs marker value for this display representation.

### StateIcon
Gets the state icon.

**Returns:** Returns the state icon.

### StateImageIndex
Gets the state image index.

**Returns:** Returns the state image index.

### DefaultRecordName
Gets the default record name of the display representation.

**Returns:** Returns the default record name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CurrentMaterialComponentDisplayInformation
Gets or sets the current material componenet display information.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IsUserDisplayRepresentation
Gets to know whether this display representatino is user display representation.

**Returns:** True if  this display representatino is user display representation. Otherwise false.

### IsNewToThisDrawing
Gets to know whether this display representatino is new to this drawing.

**Returns:** True if  this display representatino is new to this drawing. Otherwise false.

### SymbolName
Gets or sets the symbol name the display representation.

**Returns:** Returns the symbol name.

### CanBeDeleted
Gets to know this display representation can be deleted or not.

**Returns:** True if this display representation can be deleted. Otherwise false.

## Methods

### #ctor
Initializes a new instance of the DisplayRepresentation class.

### GetDisplayPropertiesLocationIds(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets the display properties location ids for specified database object.

- **`object`**: Returns a collection of the display properties ids.

### GetDisplayPropertiesLocationLabels(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets the display properties labels for specified database object.

- **`object`**: Returns a collection of the display properties location labels.

### CreateNewDisplayProperties
Creates the new display properties.

**Returns:** Returns the newly created display properties.

### GetGripPoints(Autodesk.Aec.DatabaseServices.Entity)
Gets grip points for the specified entity.

- **`entity`**: Inputs the entity.

**Returns:** Returns the collection of grip points for the specified entity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetGripOnapModes(Autodesk.Aec.DatabaseServices.Entity)
Gets grip onap modes for the specified entity.

- **`entity`**: Inputs the entity.

**Returns:** Returns the collection of grip onap modes for the specified entity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetGripGeometryIds(Autodesk.Aec.DatabaseServices.Entity)
Gets grip geometry ids for the specified entity.

- **`entity`**: Inputs the entity.

**Returns:** Returns the collection of grip geometry ids for the specified entity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MoveGripPointsAt(Autodesk.Aec.DatabaseServices.Entity,Autodesk.AutoCAD.Geometry.IntegerCollection,Autodesk.AutoCAD.Geometry.Vector3d)
Moves the grip selected by the user the specified amount.

- **`entity`**: Inputs the entity to process grip points.
- **`indices`**: Inputs the indices into the supplied point array of the points the user selected.
- **`offset`**: Inputs the distance the user has moved the points.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetStretchPoints(Autodesk.Aec.DatabaseServices.Entity)
Gets the list of stretch points the display representation wants to contribute to the entity.

- **`entity`**: Inputs the entity currently being processed.

**Returns:** Returns the set of points that this representation wants to contribute to the entity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MoveStretchPointsAt(Autodesk.Aec.DatabaseServices.Entity,Autodesk.AutoCAD.Geometry.IntegerCollection,Autodesk.AutoCAD.Geometry.Vector3d)
Moves the selected stretch points.

- **`entity`**: Inputs the entity currently being processed.
- **`indices`**: Inputs the indices into the list of supplied points.
- **`offset`**: Inputs the direction and amount the user wants to move the selected points.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetOverriddenDisplayPropertiesDefaults(Autodesk.Aec.DatabaseServices.DisplayProperties)
Sets the overriden display properties defaults.

- **`properties`**: Inputs the display properties.

### SetEnforcedOverridenDisplayPropertiesValues(Autodesk.Aec.DatabaseServices.DisplayProperties)
Sets the enforced overriden display properties values.

- **`properties`**: Inputs the display properties.

### FindDisplayPropertiesOverride(Autodesk.AutoCAD.DatabaseServices.DBObject)
Finds display properties overrides the db object.

- **`object`**: Inputs the db object.

**Returns:** Returns the object id of the display properties.

### GetDisplayPropertiesId(Autodesk.AutoCAD.DatabaseServices.DBObject)
- **`object`**: Inputs the db object.

**Returns:** Returns the display properties.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetDisplayPropertiesId(Autodesk.AutoCAD.DatabaseServices.DBObjectCollection)
Gets display properties for specified db object collection.

- **`objects`**: Inputs the collection of db object.

**Returns:** Returns the display properties.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetStateIcon(Autodesk.Aec.DatabaseServices.DisplayRepresentationImageIndex)
Gets the state icon of the display representation with specified image index.

- **`value`**: Inputs the image index of display representation.

**Returns:** Returns the state icon.

### CreateRecordName(System.String)
Creates the record name with the specified symbol name.

- **`symbolName`**: Inputs the symbol name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateUniqueRecordName(Autodesk.AutoCAD.DatabaseServices.Database)
Creates the unique record name in specified database.

- **`db`**: Inputs the dabase.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IsVisible(Autodesk.AutoCAD.Runtime.RXClass,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Helper function to check if a particular display representation for an object is loaded in the current view.

- **`representation`**: Inputs the runtime extensin class type of particular display representation.
- **`id`**: Inputs the object id of the database object.

**Returns:** True if a particular display representation for an object is loaded in the current view. Otherwise false.

### StandardDisplayRepresentationTypeName(Autodesk.Aec.DatabaseServices.DisplayRepresentationTypeName)
Standardizes the display representation type to string name.

- **`type`**: Inputs the display representation type.

**Returns:** Returns the string name of the display representation type.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
