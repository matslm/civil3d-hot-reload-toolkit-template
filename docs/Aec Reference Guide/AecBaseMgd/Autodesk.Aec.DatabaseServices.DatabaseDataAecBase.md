---
title: Autodesk.Aec.DatabaseServices.DatabaseDataAecBase
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DatabaseDataAecBase
---

# Autodesk.Aec.DatabaseServices.DatabaseDataAecBase

## Summary
Represents a Database Data of AecBase.

## Properties

### ObjectRelationGraph
Gets the object relation graph.

### DisplayRepresentationManager
Gets the display representation manager.

### CachedVariableId
Gets or sets the cached variable id.

### CachedLayerZeroId
Gets the cached layer zero id.

### DeepClonedSet
Gets the deep cloned set.

### LongTransactionSet
Gets the long transaction set.

### ReferenceEditPostUpdateEcsSet
Gets the reference edit post update set.

### LayoutCopyHandPurgeDictionaryIds
Gets the layout copy hand purge dictionary ids.

### DeepCloneIsActive
Gets if deep clone is active.

### DxfInIsActive
Gets if dxf in is active.

### DxfOutIsActive
Gets if dxf out is active.

### WblockIsActive
Gets if wblock is active.

### FastWblockIsActive
Gets if fast wblock is active.

### InsertIsActive
Gets if insert is active.

### LayoutCopyIsActive
Gets if layout copy is active.

### CloneToSameDatabaseActive
Gets if clone to same database is active.

### CloningMixedVersionOfObjects
Gets if cloning mixed version of objects.

### DwgSaveIsActive
Gets if dwg save is active.

### DwgReadIsActive
Gets if dwg read is active.

### DidDictionaryAuditPass1
Get if did dictionary audit pass 1.

### DidDictionaryAuditPass2
Gets if did dictionary autit pass 2.

### RecoverActive
Gets if recover is active.

### DetectedMunichStairDisplayProperties
The stair calculator was overloaded in the Munich product and had a different rule for calculating the stair values. To successfully upgrade R2 drawings we need to determine from a drawing if it has been created by Munich or Mannheim.  The way we do this is to check if we could find a display property from the Munich Product within this database, this is probably as close as we can get to determine this.

**Returns:** Specify whether detect any display properties.

### PartialOpenVetoed
Checks whether partial open vetoed.

**Returns:** Specify whether partial open vetoed.

### DxfInFieldsTriggered
Checks whether Dxf In fields triggered.

**Returns:** Specify whether Dxf In fields triggered.

### DwgInFieldsTriggered
Checks whether Dwg In fields triggered.

**Returns:** Specify whether Dwg In fields triggered.

### InitDwgCalled
Checks whether initializing Dwg is called.

**Returns:** Specify whether initializing Dwg is called.

### PostProcessDictionaryMergeInfo
Gets post process dictionary merge information.

**Returns:** Post process dictionary merge information.

### StyleManagerCloningActive
Checks whether style manager cloning is active.

**Returns:** Specify whether style manager cloning is active.

### InplaceEditorMap
Gets inplace editor map.

**Returns:** The output inplace editor map.

### LastXrefSubcommandActivity
Gets or sets last Xref subcommand activity.

**Returns:** Last Xref subcommand activity.

### XrefSubcommandType
Gets or sets Xref subcommand type.

**Returns:** Xref subcommand type.

### XreferenceIds
Gets Xreference Ids.

**Returns:** Gets Xreference Ids.

### RestoreInsUnitsOnBTRAfterInsert
Gets or sets restore ins units on BTR after inserting.

### InsertedBlockName
Gets or sets inserted block name.

**Returns:** Gets inserted block name.

### PreKyotoSectionElevationLinesRequiringUpdate
Gets pre Kyoto section elevation lines requiring update.

**Returns:** The objects.

### IsGsMarkerHighlightingEnabled
Checks whether GsMarker highlighting is enabled.

**Returns:** Specify whether GsMarker highlighting is enabled.

### IsGsMarkerUnhighlightingEnabled
Checks whether GsMarker Unhighlighting is enabled.

**Returns:** Specify whether GsMarker Unhighlighting is enabled.

### IsGsMarkerComponentSelectionActive
Checks whether GsMarker component selection is active.

**Returns:** Specify whether GsMarker component selection is active.

### HidingObjectsIsActive
Gets or sets whether hiding objects is active.

**Returns:** Gets whether hiding objects is active.

### UnhidingObjectsIsActive
Gets or sets whether unhiding objects is active.

**Returns:** Gets whether unhiding objects is active.

### ReferenceEditCommandActive
Gets or sets whether reference edit command is active.

**Returns:** Gets whether reference edit command is active.

### ReferenceCloseCommandActive
Gets or sets whether reference close command is active.

**Returns:** Gets whether reference close command is active.

### DisableObjectUpdateDuringModify
Gets or sets whether disable object update during modify.

**Returns:** Gets whether disable object update during modify.

### DelaySpaceUpdateEnabled
Gets or sets whether delay space update is enabled.

**Returns:** Gets whether delay space update is enabled.

### ProgressiveUpdateCondition
Gets or sets current progressive update condition setups, which will disable the progressive update.

**Returns:** Returns current progressive update condition setups, which will disable the progressive update.

## Methods

### #ctor
Initializes a new instance of the DatabaseDataAecBase class.

### AppendCopiedObject(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Append copied object6.

- **`sourceId`**: The source object id.
- **`destinationId`**: The destination object id.

### GetNestedWblockCloneDictionary(System.String)
Get nested wblock clone dictionary.

- **`mainLevelDictionary`**: Main level dictionary.

**Returns:** The nested wblock clone dictionary.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddNestedWblockCloneDictionary(System.String,Autodesk.AutoCAD.DatabaseServices.DBDictionary)
Add nested wblock clone dictionary.

- **`mainLevelDictionary`**: Main level dictionary.
- **`destinationDictionary`**: Destination dictionary.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveNestedWblockCloneDictionary(System.String)
Remove nested wblock clone dictionary.

- **`mainLevelDictionary`**: Main level dictionary.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### LayoutCopyDoPostPurge
Layout copy do post purge.

### ResetAuditFlags
Reset audit flags.

### DoDictionaryAuditHack(Autodesk.AutoCAD.DatabaseServices.AuditInfo)
Do dictionary audit hack.

- **`info`**: The audit info.

### ResetPostProcessDictionaryMergeInfo
Resets post process dictionary merge information.

### AddToEndDeepCloneMvBlockProcessingArray(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds to end deep clone MvBlock processing array.

- **`idMvBlockReference`**: The given id MvBlock reference id.

### ResetEndDeepCloneMvBlockProcessingArray
Resets end deep clone MvBlock processing array.

### AddToEndDeepCloneUpdateViewBlockArray(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds to end deep clone update view block array.

- **`idMvBlockReference`**: The given MvBlock reference id.

### ResetEndDeepCloneUpdateViewBlockArray
Resets end deep clone update view block array.

### AppendPreKyotoSectionElevationLinesRequiringUpdate(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Appends pre kyoto section elevation lines requiring update.

- **`id`**: The given object id.

### RemoveAllKyotoSectionElevationLinesRequiringUpdate
Removes all Kyoto section elevation lines requiring update.

### RemoveFromKyotoSectionElevationLinesRequiringUpdate(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Removes from Kyoto section elevation lines requiring update.

- **`id`**: The given object id.

### SetGsMarkerHighlightingEnabled(System.Boolean)
Sets whether GsMarker highlighting is enabled.

- **`enableHighlighting`**: Sets whether GsMarker highlighting is enabled.

### SetGsMarkerUnhighlightingEnabled(System.Boolean)
Sets whether GsMarker unhighlighting is enabled.

- **`enableHighlighting`**: Sets whether GsMarker unhighlighting is enabled.

### SetGsMarkerComponentSelectionActive(System.Boolean)
Sets whether GsMarker component selection is active.

- **`componentSelectionActive`**: Sets whether GsMarker component selection is active.

### PopAnnotationScaleFromStream
Pop annotation scale from stream.

### NotifySpatialTreeMessageObject
Notify spatial tree message object.
