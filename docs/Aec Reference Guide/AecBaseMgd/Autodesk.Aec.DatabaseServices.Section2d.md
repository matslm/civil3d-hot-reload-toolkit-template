---
title: Autodesk.Aec.DatabaseServices.Section2d
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > Section2d
---

# Autodesk.Aec.DatabaseServices.Section2d

## Summary
Represents a section 2D.

## Properties

### IsSavedEdits
Determine if it is saved edits.

**Returns:** true if it is saved edits, false otherwise.

### IsSingleSegment
Determine if it is single segment.

**Returns:** true if it is single segment, false otherwise.

### SingleSegment
Gets the section segment.

**Returns:** The section segment.

### SingleSegmentId
Gets the single segment ID.

**Returns:** The single segment ID.

### Vertices
Gets the vertices.

**Returns:** The section vertex collection.

### Segments
Gets the segments.

**Returns:** The section segment collection.

### SegmentGroups
Gets the segment groups.

**Returns:** The segment group collection.

### ShrinkWrapSegmentGroup
Gets the shrink wrap segment group.

**Returns:** The shrink wrap segment group.

### ClipVolumeId
Gets or sets the clip volume ID.

**Returns:** The clip volume ID.

### MainSectionId
Gets or sets the main section ID.

**Returns:** The main section ID.

### ShrinkWrapProfile
Gets or sets the shrink wrap profile.

**Returns:** The shrink wrap profile.

### HatchRegions
Gets the hatch regions.

**Returns:** The hatchregions.

### HasUserEdits
Determine if it has user edits.

**Returns:** true if it has user edits, false otherwise.

### HasObjectDisplayPropertyInformation
Determine if it has object display property information.

**Returns:** true if it has object display property information, false otherwise.

### HatchRegionsCount
Gets the number of hatch regions.

**Returns:** The number of hatch regions.

## Methods

### #ctor
Initializes a new instance of the Section2d class.

### SetIsSingleSegment(System.Boolean,System.UInt32)
Sets if it is single segment.

- **`value`**: true if it is single segment, false otherwise.
- **`segmentId`**: The segment ID.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IntegrateLineWork(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.ComponentType,System.Int16,Autodesk.Aec.DatabaseServices.LineWorkType,System.Boolean,System.Boolean)
Integrate line work.

- **`startPoint`**: The start point.
- **`endPoint`**: The end point.
- **`materialId`**: The material ID.
- **`componentType`**: The component type.
- **`userComponentId`**: The user component ID.
- **`lineworkType`**: The line work type.
- **`isManual`**: true if it is manual, false otherwise.
- **`isEdit`**: true if it is edit, false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MergeLineWork(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d,System.Int16,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.LineWorkType,System.Boolean)
Merge line work.

- **`startPoint`**: The start point.
- **`endPoint`**: The end point.
- **`componentId`**: The component ID.
- **`materialId`**: The material ID.
- **`lineworkType`**: The line work type.
- **`mergeExactOnly`**: true to merge exact only, false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### MergeSection2d(Autodesk.Aec.DatabaseServices.Section2d,System.Boolean,System.Boolean,System.Boolean)
Merge section 2D.

- **`section`**: The section.
- **`doComponentEdits`**: true to do component edits, false otherwise.
- **`doMergeEdits`**: true to do merge edits, false otherwise.
- **`removeSegments`**: true to remove segments, false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveAllLineWork
Remove all line work.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveAllButUserEdits
Removes all but user edits.

### SaveEditInPlaceChanges
Save edit in place changes.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### HasAssociatedModelSpaceView(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Determine if it has association with model space view.

- **`viewTableRecordId`**: true if it has association with model space view, false otherwise.

**Returns:** true if it has association with model space view, false otherwise.

### SetAssociatedModelSpaceView(Autodesk.AutoCAD.DatabaseServices.ViewTableRecord)
Sets the association with model space view.

- **`viewTableRecord`**: The view table record.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveObjectPropertyDependencies
Remove object property dependencies.
