---
title: Autodesk.Aec.PropertyData.DatabaseServices.PropertyDataServices
hierarchy: AecPropDataMgd > Autodesk > Aec > PropertyData > DatabaseServices > PropertyDataServices
---

# Autodesk.Aec.PropertyData.DatabaseServices.PropertyDataServices

## Summary
Represents the property data services.

## Methods

### UsePropertySetInclusive(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Collections.Specialized.StringCollection,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
Determines if a property set definition applies to ANY of the entity types in the entity filter.

- **`propertySetDefinitionId`**: Input the object id for the property set definition.
- **`entityFilter`**: Input a string collection of entity type names to query for.
- **`filterReadOnlySets`**: Input true to indicate a read-only PropertySetDefinition should be ignored. Returns false if PropertySetDefinition is read-only.
- **`filterHiddenSets`**: Input true to indicate a hidden PropertySetDefinition should be ignored. Returns false if PropertySetDefinition is read-only.
- **`includeExtendedClasses`**: Input true to include "extended" classes (i.e. styles) in the query.
- **`matchTypes`**: Input true to match the property set with the type of entities in entityFilter. For example, if matchTypes == true, and entityFilter contains entities ( entitiesAreStyles == false ), and propSetDef applies to styles (styleBased == true), then this returns false.
- **`entitiesAreStyles`**: Input true to indicate that the objects in the entityFilter are styles, not entities.

**Returns:** True if a property set applies to ANY of the entity types, or false otherwise.

### UsePropertySetInclusiveMatchClassifications(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Collections.Specialized.StringCollection,Autodesk.Aec.DatabaseServices.ClassificationCollection,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
Determines if a property set definition applies to ANY of the entity type names in an entity filter, and ALL of the input classifications match the classifications of the property set definition.  A first pass is done using UsePropertySetInclusive, so please see its description for additional information.

- **`propertySetDefinitionId`**: Input the object id for the property set definition.
- **`entityFilter`**: Input a string collection of entity type names to query for.
- **`matchingClassifications`**: Input thje classifications to query for.
- **`filterReadOnlySets`**: Input true to indicate a read-only PropertySetDefinition should be ignored. Returns false if PropertySetDefinition is read-only.
- **`filterHiddenSets`**: Input true to indicate a hidden PropertySetDefinition should be ignored. Returns false if PropertySetDefinition is read-only.
- **`includeExtendedClasses`**: Input true to include "extended" classes (i.e. styles) in the query.
- **`matchTypes`**: Input true to match the property set with the type of entities in entityFilter. For example, if matchTypes == true, and entityFilter contains entities ( entitiesAreStyles == false ), and propSetDef applies to styles (styleBased == true), then this returns false.
- **`entitiesAreStyles`**: Input true to indicate that the objects in the entityFilter are styles, not entities.

**Returns:** True if it applies to ANY of the entity type names specified and matches ALL of the classifications, or false otherwise.

### UsePropertySetExclusive(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Collections.Specialized.StringCollection,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
Determines if a property set definition applies to ALL of the entity types in the entity filter.

- **`propertySetDefinitionId`**: Input the object id for the property set definition.
- **`entityFilter`**: Input a string collection of entity type names to query for.
- **`filterReadOnlySets`**: Input true to indicate a read-only PropertySetDefinition should be ignored. Returns false if PropertySetDefinition is read-only.
- **`filterHiddenSets`**: Input true to indicate a hidden PropertySetDefinition should be ignored. Returns false if PropertySetDefinition is read-only.
- **`includeExtendedClasses`**: Input true to include "extended" classes (i.e. styles) in the query.
- **`matchTypes`**: Input true to match the property set with the type of entities in entityFilter. For example, if matchTypes == true, and entityFilter contains entities ( entitiesAreStyles == false ), and propSetDef applies to styles (styleBased == true), then this returns false.
- **`entitiesAreStyles`**: Input true to indicate that the objects in the entityFilter are styles, not entities.

**Returns:** True if a property set applies to ALL of the entity type names, or false otherwise.

### UsePropertySetExclusiveMatchEntityClassifications(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Collections.Specialized.StringCollection,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
Determines if a property set definition applies to ALL of the entity type names in an entity filter, and ALL of the entities in the input id array have the same classifications as the property set definition.  A first pass is done using UsePropertySetExclusive, so please see its description for additional information.

- **`propertySetDefinitionId`**: Input the object id for the property set definition.
- **`entityFilter`**: Input a string collection of entity type names to query for.
- **`matchingEntities`**: ?= Input thje classifications to query for.
- **`filterReadOnlySets`**: Input true to indicate a read-only PropertySetDefinition should be ignored. Returns false if PropertySetDefinition is read-only.
- **`filterHiddenSets`**: Input true to indicate a hidden PropertySetDefinition should be ignored. Returns false if PropertySetDefinition is read-only.
- **`includeExtendedClasses`**: Input true to include "extended" classes (i.e. styles) in the query.
- **`matchTypes`**: Input true to match the property set with the type of entities in entityFilter. For example, if matchTypes == true, and entityFilter contains entities ( entitiesAreStyles == false ), and propSetDef applies to styles (styleBased == true), then this returns false.
- **`entitiesAreStyles`**: Input true to indicate that the objects in the entityFilter are styles, not entities.

**Returns:** True if it applies to ALL of the entity type names specified and matches ALL of the entity classifications, or false otherwise.

### UsePropertySetExclusiveMatchClassifications(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Collections.Specialized.StringCollection,Autodesk.Aec.DatabaseServices.ClassificationCollection,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
Determines if a property set definition applies to ALL of the entity type names in an entity filter, and ALL of the input classifications match the classifications of the property set definition.  A first pass is done using UsePropertySetExclusive, so please see its description for additional information.

- **`propertySetDefinitionId`**: Input the object id for the property set definition.
- **`entityFilter`**: Input a string collection of entity type names to query for.
- **`matchingClassifications`**: Input thje classifications to query for.
- **`filterReadOnlySets`**: Input true to indicate a read-only PropertySetDefinition should be ignored. Returns false if PropertySetDefinition is read-only.
- **`filterHiddenSets`**: Input true to indicate a hidden PropertySetDefinition should be ignored. Returns false if PropertySetDefinition is read-only.
- **`includeExtendedClasses`**: Input true to include "extended" classes (i.e. styles) in the query.
- **`matchTypes`**: Input true to match the property set with the type of entities in entityFilter. For example, if matchTypes == true, and entityFilter contains entities ( entitiesAreStyles == false ), and propSetDef applies to styles (styleBased == true), then this returns false.
- **`entitiesAreStyles`**: Input true to indicate that the objects in the entityFilter are styles, not entities.

**Returns:** True if it applies to ALL of the entity type names specified and matches ALL of the classifications, or false otherwise.

### AddExtendedClasses(System.Collections.Specialized.StringCollection)
Adds extended classes.

- **`entityFilter`**: Input entity type names.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ResolvePropertySetLocations(Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@)
From the input objects, resolves the property set locations and appends to the appripriate collection of ids.

- **`originalIds`**: Input the ids to resolve.
- **`resolvedIds`**: This collection will be appended to indicating the ids that were resolved. (input/output parameter)
- **`forwardedIds`**: This collection will be appended to indicating the ids that were forwarded. (input/output parameter)
- **`duplicateIds`**: This collection will be appended to indicating the ids that were duplicate. (input/output parameter)

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ResolvePropertySetLocationsAndFilterLockedLayers(Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection@,System.Boolean)
From the input objects, resolves the property set locations and appends to the appripriate collection of ids.

- **`originalIds`**: Input the ids to resolve.
- **`resolvedIds`**: This collection will be appended to indicating the ids that were resolved. (input/output parameter)
- **`forwardedIds`**: This collection will be appended to indicating the ids that were forwarded. (input/output parameter)
- **`duplicateIds`**: This collection will be appended to indicating the ids that were duplicate. (input/output parameter)
- **`lockedIds`**: This collection will be appended to indicating the ids that were on locked layers. (input/output parameter)
- **`speak`**: Input true to output information about this operation tot he command-line, or false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetNearestPropertySet(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the nearest property set definiton id.

- **`id`**: Input an object id.
- **`blockRefPath`**: Input the block reference path ids.
- **`propertySetDefinitionId`**: Input the property set definition id.

**Returns:** The nearest property set definiton id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetNearestPropertySet(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the nearest property set definiton id.

- **`objectInstance`**: Input an open for read database resident object.
- **`blockRefPath`**: Input the block reference path ids.
- **`propertySetDefinitionId`**: Input the property set definition id.

**Returns:** The nearest property set definiton id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetNearestPropertySet(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the nearest property set definiton id.

- **`objectInstance`**: Input an open for read database resident object.
- **`propertySetDefinitionId`**: Input the property set definition id.

**Returns:** The nearest property set definiton id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### PropertyExists(Autodesk.AutoCAD.DatabaseServices.Database,System.String,System.Int32&)
Determines whether a property exists.

- **`db`**: Input database.
- **`fullPropertyName`**: Input string representing the full property name. (This format includes the definition and set names in like the format from a tag.)
- **`propertyId`**: Ouptut to be filled in with the property definition id.

**Returns:** The object id of the property set definition.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SearchPathForPropertySet(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,System.String)
Returns the property set id found based on input parameters.

- **`object`**: Input object. Must be open for read.
- **`blockRefPathIds`**: Input block reference path ids.
- **`propertySetName`**: Input property set name.

**Returns:** Property set id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SearchPathForPropertySet(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,System.String)
Returns the property set id found based on input parameters.

- **`entityId`**: Input entity id.
- **`blockRefPathIds`**: Input block ref path.
- **`propertySetName`**: Input property set name.

**Returns:** Property set id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ExtractExtendedObjects(Autodesk.AutoCAD.DatabaseServices.ObjectId)
This tells which "extended" objects can have PropertySets attached that are applicable to the given object (i.e. for a Door, it will return the DoorStyle). This is an easy way to get the owner of the style-based property sets for a given object.  If you pass in the style's object id, you will get the classifications for the style.

- **`id`**: Input the Object Id to extract the extended objects for.

**Returns:** An object id colection containing the supporting objects of the specified object.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertySets(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets the property sets for the specified object.

- **`obj`**: The object.

**Returns:** Returns the property sets for the specified object.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertySets(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Gets the property sets for the specified object id, override container and block ref path.

- **`id`**: The property owner.
- **`idOverrideContainerOwner`**: The override container.
- **`blockRefPath`**: The block reference path.

**Returns:** Returns the property sets for the specified object id, override container and block ref path.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertySet(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the property set for the specified object and property set definition id.

- **`obj`**: The object.
- **`propertySetDefinitionId`**: The property set definition id.

**Returns:** Returns the property set for the specified object and property set definition id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertySet(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the property set for the specified object id, override container, block ref path and property set definition id.

- **`id`**: The object id.
- **`idOverrideContainerOwner`**: The override container owner id.
- **`blockRefPath`**: The block ref path.
- **`propertySetDefinitionId`**: The property set definition id.

**Returns:** Returns the property set for the specified object id, override container, block ref path and property set definition id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddPropertySet(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds the specified property set to the object.

- **`obj`**: The object.
- **`propertySetDefinitionId`**: The property set definition id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddPropertySet(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds the specified property set to the object.

- **`id`**: The object id.
- **`idOverrideContainerOwner`**: The override container owner id.
- **`blockRefPath`**: The block ref path.
- **`propertySetDefinitionId`**: The property set definition id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemovePropertySet(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Removes the specified property set from the object.

- **`obj`**: The object.
- **`propertySetDefinitionId`**: The property set definition id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemovePropertySet(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Removes the specified property set from the object.

- **`id`**: The object id.
- **`idOverrideContainerOwner`**: The override container owner id.
- **`blockRefPath`**: The block ref path.
- **`propertySetDefinitionId`**: The property set definition id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertySetDefinitionsUsed(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets the ids of the property set definitions used by the object.

- **`obj`**: The object.

**Returns:** Gets the ids of the property set definitions used by the object.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertySetDefinitionsUsed(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Gets the ids of the property set definitions used for the object.

- **`id`**: The object id.
- **`idOverrideContainerOwner`**: The override container owner id.
- **`blockRefPath`**: The block ref path.

**Returns:** Returns the ids of the property set definitions used for the object.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### PurgeDuplicatePropertySets(Autodesk.AutoCAD.DatabaseServices.DBObject,System.Boolean)
Purges duplicate property sets.

- **`obj`**: The object.
- **`verbose`**: Determines if messages are displayed.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAllPropertySetsUsingDefinition(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Boolean)
Gets all property sets that use the specified property set definition.

- **`propertySetDefinition`**: The property set definition id.
- **`allowErased`**: Determines if erased property sets are included.

**Returns:** Returns all property sets that use the specified property set definition.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### FindOverrideContainer(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Boolean)
Determines the override container for the block reference.

- **`idBlockReference`**: The block reference id.
- **`createIfNotFound`**: Determines if the container is created if not found.

**Returns:** Returns the override container for the block reference.

### FormatValue(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.UnitType,System.Object,Autodesk.AutoCAD.Runtime.ErrorStatus)
Formats the value using the specified property data format.

- **`idPropertyFormat`**: The property data format id.
- **`unitType`**: The unit type.
- **`propertyValue`**: The property value to be formatted.
- **`readStatus`**: The error status returned in the exception thrown while retrieving the property value, or OK.

**Returns:** Returns the formatted value as a string.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.
- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.
- **Exception `T:System.NotSupportedException`**: System.NotSupportedException.
- **Exception `T:System.Runtime.InteropServices.InvalidOleVariantTypeException`**: System.Runtime.InteropServices.InvalidOleVariantTypeException.

**Remarks:**
Proper formatting depends on the status returned by PropertySet.GetAt or PropertySet.GetValueAndUnitAt.

### FindAutomaticSourceNames(System.String,Autodesk.AutoCAD.DatabaseServices.Database)
Find automatic source names.

- **`objectName`**: The object name.
- **`db`**: The database.

**Returns:** Returns the automatic source names.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### FindEligibleClassNames
Find the names of the eligible classes to which the schedule table system can apply.

**Returns:** Returns the eligible class names.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertyValueExt(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32)
Get the property value.

- **`objectId`**: The object id.
- **`blockReferencePath`**: The block reference path.
- **`propertySetDefinitionId`**: The property set definition id.
- **`propertyId`**: The property id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertyValueExt(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32)
Get the property value.

- **`dbObject`**: The database object.
- **`blockReferencePath`**: The block reference path.
- **`propertySetDefinitionId`**: The property set definition id.
- **`propertyId`**: The property id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertyValueUnitExt(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32)
Get the property value and unit.

- **`objectId`**: The object id.
- **`blockReferencePath`**: The block reference path.
- **`propertySetDefinitionId`**: The property set definition id.
- **`propertyId`**: The property id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertyValueUnitExt(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.String)
Get the property value and unit.

- **`objectId`**: The object id.
- **`blockReferencePath`**: The block reference path.
- **`propertySetDefinitionId`**: The property set definition id.
- **`globalName`**: The global name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertyValueUnitExt(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32)
Get the property value and unit.

- **`dbObject`**: The database object.
- **`blockReferencePath`**: The block reference path.
- **`propertySetDefinitionId`**: The property set definition id.
- **`propertyId`**: The property id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPropertyValueUnitExt(Autodesk.AutoCAD.DatabaseServices.DBObject,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32,System.Boolean)
Get the property value and unit.

- **`dbObject`**: The database object.
- **`blockReferencePath`**: The block reference path.
- **`propertySetDefinitionId`**: The property set definition id.
- **`propertyId`**: The property id.
- **`searchByName`**: If search by name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DataToString(System.Object)
Variant to string.

- **`variantObject`**: The variant object.
