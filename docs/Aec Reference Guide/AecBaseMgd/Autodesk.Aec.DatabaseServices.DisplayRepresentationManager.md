---
title: Autodesk.Aec.DatabaseServices.DisplayRepresentationManager
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplayRepresentationManager
---

# Autodesk.Aec.DatabaseServices.DisplayRepresentationManager

## Summary
Represents a manager class of display representations.

## Properties

### DisplayConfigurationIdForCurrentViewport
Gets the  display configuration id for current viewport.

**Returns:** Returns the  display configuration id for current viewport.

### DefaultDisplayConfigurationId
Gets or sets the default display configuration id.

**Returns:** Returns the default display configuration id.

### DisplayRepresentationsDictionaryId
Gets the object id of dictionary for display representations.

**Returns:** Returns the object id of dictionary for display representations.

### DisplayRepresentaionToObjectTypeMap
Gets the map of display representation class and object id collection.

**Returns:** Returns the map of display representation class and object id collection.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DisplayDxfName
Indicates whether display of the dxf name is currently on or off.

**Returns:** True if display of dxf name is turned on, otherwise false.

### Initialization
Gets the top element of initialization stack of display representation manager.

**Returns:** Returns the top element of initialization stack of display representation manager.

## Methods

### #ctor
Initializes a new instance of the DisplayRepresentationManager class with default database.

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database)
Initializes a new instance of the DisplayRepresentationManager class with specified database.

- **`db`**: Inputs the specified database.

### #ctor(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.GraphicsInterface.ViewportDraw)
Initializes a new instance of the DisplayRepresentationManager class.

- **`viewportId`**: Inputs the object id of viewport.
- **`viewDirection`**: Inputs the direction vector of view.
- **`entityDatabase`**: Inputs the database of entity.
- **`contextDatabase`**: Inputs the database of context.
- **`viewportDraw`**: Inputs the viewport draw.

### #ctor(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.DatabaseServices.Database)
Initializes a new instance of the DisplayRepresentationManager class.

- **`viewportId`**: Inputs the object id of viewport.
- **`viewDirection`**: Inputs the direction vector of view.
- **`entityDatabase`**: Inputs the database of entity.
- **`contextDatabase`**: Inputs the database of context.

### GetDisplayConfigurationId(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the display configuration id from particular object.

- **`id`**: Inputs the particular object id.

**Returns:** Returns the display configuration id from particular object.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetDisplayConfigurationId(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Sets the display configuration id for particular object.

- **`id`**: Inputs the particular object id.
- **`configurationId`**: Inputs the display configuration id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RegisterDisplayRepresentation(Autodesk.AutoCAD.Runtime.RxClassRXClass,System.String)
Registers the display representation with system along with which display representation set it wants to be a part of default.

- **`viewClass`**: Inputs the the display representation.
- **`viewSetName`**: Inputs the name of the display representation set.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RegisterDisplayRepresentation(Autodesk.AutoCAD.Runtime.RxClassRXClass)
Registers the display representation with system.

- **`viewClass`**: Inputs the the display representation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RegisterDisplayRepresentation(Autodesk.AutoCAD.Runtime.RxClassRXClass,System.Collections.Specialized.StringCollection)
Registers the display representation with system along with all display representation sets it wants to be a part of default.

- **`viewClass`**: Inputs the the display representation.
- **`viewSetNames`**: Inputs the names of the display representation sets.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### UnregisterDisplayRepresentation(Autodesk.AutoCAD.Runtime.RxClass)
Unregisters the display representation with system.

- **`viewClass`**: Inputs the the display representation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetDisplayRepresentationsDictionary(Autodesk.Aec.DatabaseServices.Database)
Gets the dictionary of display representations.

- **`db`**: Inputs the database.

**Returns:** Returns the dictionary of display representations.

### GetDisplayRepresentationId(Autodesk.AutoCAD.Runtime.RxClass)
Gets the object id of  the specified display representation.

- **`viewClass`**: Inputs the the display representation.

**Returns:** Returns the object id of  the specified display representation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetDisplayRepresentationIdFromXref(Autodesk.Aec.DatabaseServices.DisplayRepresentation,Autodesk.AutoCAD.DatabaseServices.Database)
Gets the display representation in the supplied database that is of the type supplied by the viewClass argument.

- **`view`**: Input the type of display representation.
- **`db`**: Input the supplied database.

**Returns:** Returns the the object id of this display representation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAllDisplayRepresentationsWorkForSpecifiedClass(Autodesk.AutoCAD.Runtime.RxClass)
Gets all display representations that work for a given class.

- **`worksWithClass`**: Inputs the specified class that works with some display representations.

**Returns:** Returns the object id collection of all display representations that work for a given class.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetDisplayRepresentationIdsFromCurrentViewport(Autodesk.AutoCAD.Runtime.RxClass)
Gets object ids of display representations from current viewport for specified class type.

- **`classType`**: Inputs the class type.

**Returns:** Returns the object id collection of display representations from current viewport.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetDisplayRepresentationIdsFromCurrentViewport(Autodesk.AutoCAD.Runtime.RxClass,Autodesk.AutoCAD.Runtime.RxClass)
Gets object ids of display representations from current viewport for specified class type and anchor type.

- **`classType`**: Inputs the class type.
- **`anchorType`**: Inputs the anchor type.

**Returns:** Returns the object id collection of display representations from current viewport.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateUserDisplayRepresentation(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.String,System.Int32)
Creates user's default display representation.

- **`id`**: Inputs the id.
- **`name`**: Inputs the name.
- **`flags`**: Inputs the flags.

**Returns:** Returns the object id of  created user's default display representation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateUserDisplayRepresentation(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.String)
Creates user's default display representation.

- **`id`**: Inputs the id.
- **`name`**: Inputs the name.

**Returns:** Returns the object id of  created user's default display representation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateUserDefaultDisplayProperty(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.String,System.Int32)
Creates user's default display property.

- **`id`**: Inputs the id.
- **`name`**: Inputs the name.
- **`flags`**: Inputs the flags.

**Returns:** Returns the object id of  created user's default display property.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CreateUserDefaultDisplayProperty(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.String)
Creates user's default display property.

- **`id`**: Inputs the id.
- **`name`**: Inputs the name.

**Returns:** Returns the object id of  created user's default display property.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### CopyOverridenDisplayProperties(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Copies overriden display properties.

- **`sourceId`**: Inputs the source id.
- **`userId`**: Inputs the user id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### UpdateMaskBlockDisplayRepresentations(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Updates mask block display representations.

- **`sourceId`**: Inputs the source id.
- **`userId`**: Inputs the user id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetConfigurationOverrideFromInsertPath(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the configuration id from insert path.

- **`blockStack`**: Inputs the stack of block.

**Returns:** Returns the configuration id from insert path.

### GetXrefInsertConfigurationOverride(Autodesk.AutoCAD.DatabaseServices.BlockReference)
Gets the overriden configuration id of the Xref INSERT.

- **`reference`**: Inputs the block reference as Xref INSERT.

**Returns:** Returns the object id of the overriden configuration id.

### GetXrefInsertOverlayDabase(Autodesk.AutoCAD.DatabaseServices.BlockReference)
Gets the overlay database of the Xref INSERT.

- **`reference`**: Inputs the block reference as Xref INSERT.

**Returns:** Returns the overlay database of the Xref INSERT.

### SetXrefInsertConfigurationOverride(Autodesk.AutoCAD.DatabaseServices.BlockReference,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Boolean)
Sets Xref of insert configuration override.

- **`blockReference`**: Inputs the reference of block.
- **`configurationId`**: Inputs the configuration id.
- **`inverseOverlayOverride`**: Inputs the value to indicate whether inversing the overlay override.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveXrefInsertConfigurationOverride(Autodesk.AutoCAD.DatabaseServices.BlockReference)
Removes the Xref of insert configuration override.

- **`blockReference`**: Inputs the block reference.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IsGSViewportDraw(Autodesk.AutoCAD.GraphicsInterface.ViewportDraw)
Checks whether the specified viewport draw is GS.

- **`draw`**: Inputs the viewport draw.

**Returns:** True if the specified viewport draw is GS, otherwise false.

### EnsureDisplayRepresentaionsHaveUniqueDictionaryNames
Ensures that the display representations have the unique dictionary names.

### DisplayConfigurationId(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.Geometry.Vector3d)
Gets the display configuration id.

- **`viewportId`**: Inputs the id of viewport.
- **`viewDirection`**: Inputs the display representation direction.

**Returns:** Returns the display configuration id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DisplayRepresentationSet(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.Geometry.Vector3d)
Gets the set of display representation.

- **`viewportId`**: Inputs the id of viewport.
- **`viewDirection`**: Inputs the display representation direction.

**Returns:** Returns the set of display representation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ActualDisplayRepresentationDirection(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.Geometry.Vector3d)
Gets the actual direction of display representation.

- **`viewportId`**: Inputs the id of viewport.
- **`viewDirection`**: Inputs the display representation direction.

**Returns:** Returns the actual direction of display representation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetActiveDisplayRepresentationSets(Autodesk.AutoCAD.DatabaseServices.Database)
Gets the sets of active display representation.

- **`db`**: Inputs the database.

**Returns:** Returns the sets of active display representation.

### PushInitialization(System.Boolean)
Pushes the value on the top of the initialization stack of display representation manager.

- **`doInitialization`**: This argument indicates whether is necessary to do initialization before using display representation manager.

### PushInitialization
Pushes the value of "true" on the top of the initialization stack of display representation manager.

### PopInitialization
Pops the top element of the initialization stack of display representation manager.
