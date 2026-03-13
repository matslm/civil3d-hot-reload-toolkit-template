---
title: Autodesk.Aec.DatabaseServices.GsMarkerInformationTree
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GsMarkerInformationTree
---

# Autodesk.Aec.DatabaseServices.GsMarkerInformationTree

## Summary
Represents a tree contains the GsMakerInformation nodes.

## Properties

### StartGsMarker
Gets or sets the specified start GsMarker of the tree.

### NextGsMarker
Gets the next GsMarker of the tree.

**Returns:** The next GsMarker of the tree.

### CurrentGsMarker
Gets the current GsMarker of the tree.

**Returns:** The current GsMarker of the tree.

### ObjectId
Gets the object id of the tree.

**Returns:** The object id of the tree.

### CurrentGsMarkerInformationNode
Gets the current GsMarker information node.

**Returns:** The current GsMarker information node.

### PopulateTree
Gets or sets the specified boolean value to indicate if the tree should be poplulated.

### PushCustomOverrideNode
Gets or sets the specified boolean value to indicate if the custom overrided node should be pushed into the stack.

### EntityIsFromCustomBlock
Gets the boolean value to indicate if the entity is from the custom block.

**Returns:** The boolean value indicates if the entity is from the custom block.

### CustomBlockOwnerEntityId
Gets the object id of the custom block owner entity.

**Returns:** The object id of the custom block owner entity.

### CustomBlockGsMarker
Gets the GsMarker of the custom block.

**Returns:** The GsMarker of the custom block.

### IsDrawingCustomBlock
Gets or sets the boolean value to indicate if the custom block should be drawn.

**Returns:** The boolean value indicates if the custom block should be drawn.

### AreComponentsSelected
Gets the boolean value to indicate if the components are selected.

**Returns:** The boolean value indicates if the components are selected.

### HasGsMarkersForHoverHighlighting
Gets the boolean value to indicate if the tree has GsMarkers for hover high lighting.

**Returns:** The boolean value indicates if the tree has GsMarkers for hover high lighting.

### GsMarkersForHoverHighlighting
Gets the GsMarker for hover high lighting.

**Returns:** The GsMarker for hover high lighting.

### GsMarkersForHoverHighliting
Sets the GsMarker for hover high lighting.

### SetSelectedObjectDisplayRepresentaionId
Sets the specified display representation of the selected object.

### SelectedObjectDisplayRepresentationId
Gets the display representation of the selected object.

**Returns:** The object id of the display reprensentation for the specified object.

### IsDrawingWithDisplayTheme
Gets the boolean value to indicate if the tree is drawing with the display theme.

**Returns:** The boolean value indicates if the tree is drawing with the display theme.

### IsEntity2dSectionType
Gets the boolean value to indicate if the entity is the 2d secion.

**Returns:** The boolean value indicates if the entity is the 2d secion.

### Entity2dSectionType
Sets the specified boolean value to indicate if the entity is the 2d secion.

## Methods

### #ctor
Initializes a new instance of the GsMarkerInformationTree class.

### #ctor(Autodesk.Aec.DatabaseServices.ObjectId)
Initializes a new instance of the GsMarkerInformationTree class.

- **`id`**: The specified object id.

### #ctor(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Initializes a new instance of the GsMarkerInformationTree class using the specified refernce path of the database.and the specified object id.

- **`id`**: The specified object id.
- **`dbReferencePath`**: The specified refernce path of the database.

### HasDatabaseReferencePath(Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Gets the boolean value to indicate if the node has the specified database reference path.

- **`path`**: The specified path.

**Returns:** The boolean value indicates if the node has the specified database reference path.

### AddGsMarkerInformationNode(Autodesk.Aec.DatabaseServices.GsMarkerInformationNode,System.Boolean)
Add the specified GsMarker information node to the tree.

- **`node`**: The specified node.
- **`pushIntoCurrentNodeStack`**: The boolean value indicates if the specified node should be pushed into the current node stack.

### PopViewportInformationNode
Pops the last viewport information node off the viewport information node stack.

### AddDisplayRepresentationInformationNode(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Boolean)
Adds the specified display representation information node to the tree.

- **`id`**: The specified object id of the display representation information node.
- **`pushIntoCurrentNodeStack`**: The boolean value indicates if the the specified node should be pushed into the current node stack.

### AddDisplayComponentInformationNode(Autodesk.Aec.DatabaseServices.DisplayComponentEntity,System.Boolean)
Adds the specified display component information node to the tree.

- **`componentEntity`**: The specified display component information node.
- **`pushIntoCurrentNodeStack`**: The boolean value indicates if the specified node should be pushed into the current node stack.

### AddDisplayComponentInformationNode(System.String,System.Boolean)
Adds the specified display component information node to the tree.

- **`componentName`**: The name of the specified display component information node.
- **`pushIntoCurrentNodeStack`**: The boolean value indicates if the specified node should be pushed into the current node stack.

### AddDisplayThemeInformationNode(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32,System.Boolean)
Adds the node of the the display theme information to the tree.

- **`id`**: The specified object id of the display theme information.
- **`componentIndex`**: The specified component index of the display theme.information.
- **`pushIntoCurrentNodeStack`**: The boolean value indicates if the node should be pushed into the current node stack.

### AddCustomInformationNode(System.IntPtr,System.Boolean)
Adds the custom information node specified by the GsMarker to the tree.

- **`value`**: The specified GsMarker.
- **`pushIntoCurrentNodeStack`**: The boolean value indicates if the node should be pushed into the current node stack.

### AddBranchInformationNode(System.Boolean)
Adds the branch information node to the tree.

- **`pushIntoCurrentNodeStack`**: The boolean value indicates if the node should be pushed into the current node stack.

### AddCustomBlockInformationNode(System.Boolean)
Adds the custom block information node to the tree.

- **`pushIntoCurrentNodeStack`**: The boolean value indicates if the node should be pushed into the current node stack.

### AddUnsupportedGraphicsInformationNode(System.Boolean)
Adds the unsupported graphics information node to the tree.

- **`pushIntoCurrentNodeStack`**: The boolean value indicates if the node should be pushed into the current node stack.

### PushCurrentGsMarkerInformationNode(Autodesk.Aec.DatabaseServices.GsMarkerInformationNode)
Pushes the specified GsMarker information node to the current GsMarker information node stack.

- **`node`**: The specified GsMarker information node.

### PopCurrentGsMarkerInformationNode
Pops the last GsMarker information node off the current GsMarker information node stack.

### PopCurrentGsMarkerInformationNode(Autodesk.AutoCAD.Runtime.RXClass,System.Boolean)
Pops the last GsMarker information node specified by the class type off the current GsMarker information node stack.

- **`nodeInformationClass`**: The specified class type of the nodes.
- **`checkForDerivedTypes`**: The boolean value indicates if the node should be checked for the derived types.

### SetDisplayPropertiesForCurrentDisplayInformationNode(Autodesk.Aec.DatabaseServices.DisplayProperties)
Sets the specified display properties for the current display information node.

- **`properties`**: The specified display properties.

### ResetTransientDisplayPropertiesInformationForCurrentDisplayInformationNode
Resets the transient display properties information for current display information node.

### InformationNodeForGsMarkerAndInformationType(System.IntPtr,Autodesk.AutoCAD.Runtime.RXClass,System.Boolean)
Gets the information node specified by the GsMarker and the information type.

- **`value`**: The specified GsMarker value.
- **`nodeType`**: The specified class type.
- **`doIsKindOfTest`**: The boolean value indicates if the test on the type should be done.

**Returns:** The specified information node.

### ResetCurrentNodeStack
Resets the current node stack.

### SetParentCustomBlockOwnerInformation(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.IntPtr)
Sets the parent of the custom block owner information.

- **`id`**: The specified object id of the parent.
- **`customBlockGsMarker`**: The GsMarker of the custom block.

### CustomBlockInformationToString
Convert the custom block informations to strings.

**Returns:** The string collection contains the custom block informations.

### GetDisplayComponentNodesInCurrentViewport(Autodesk.AutoCAD.Geometry.IntPtrCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32)
Gets all information nodes for display components in the current viewport.

- **`gsMarkers`**: The specified GsMarkers for display components.
- **`id`**: The object id of specified viewport.
- **`viewportNumber`**: The index of the specified viewport.

**Returns:** All information nodes for display components in the current viewport.

### GetSelectedComponentsInformation
Gets all components information of selected entities.

**Returns:** All components information of selected entities.

### AddSelectedComponentInformation(Autodesk.AutoCAD.Geometry.IntPtrCollection)
Adds all selected component informations to the tree.

- **`gsMarkers`**: The specified GsMarkers of all selected component informations.

### AddSelectedComponentInformation(Autodesk.Aec.DatabaseServices.EntitySelectedComponentInformation)
Adds the specified component information of the selected entity to the GsMarker information tree.

- **`information`**: The specified component information of the selected entity.

### UpdateSelectedComponentInformation(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32)
Updates the information of the selected component.

- **`id`**: The specified object id of the selected component.
- **`index`**: The specified index.

### ClearSelectedComponentsGsMarkers
Clear all GsMarkers of the selected components.

### GetSelectedComponentGsMarkersForHighligting
Gets the GsMarkers of the selected components for high lighting.

**Returns:** The GsMarkers of the selected components for high lighting.

### GetSelectedComponentGsMarkersOnByMaterialChange(Autodesk.Aec.DatabaseServices.EntitySelectedComponentInformation)
Gets the GsMarkers of the selected components on ByMaterial change.

- **`information`**: The specified component information of the selected entity.

**Returns:** The GsMarkers of the selected components on ByMaterial change.

### CleanupGsMarkersForHoverHighliting
Cleans up all GsMarkers for hover high lighting.

### ClearSelectedObjectDisplayRepresentationInformation
Clears the display representation informations of the selected object.

### CollectNonViewportInformationNodesInViewport(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32,Autodesk.AutoCAD.Runtime.RXClass,System.Boolean)
Gets the information nodes only in the specified viewport.

- **`viewportId`**: The specified object id.of the viewport.
- **`viewportIndex`**: The specified index of the viewport.
- **`nodeClass`**: The specified class type.
- **`recursive`**: The boolean value indicates if the children nodes should be collected.

**Returns:** The information nodes only in the specified viewport.

### CollectNonViewportInformationNodesInViewport(Autodesk.AutoCAD.DatabaseServices.ObjectId,System.Int32)
Gets the information nodes only in the specified viewport.

- **`viewportId`**: The specified object id.of the viewport.
- **`viewportIndex`**: The specified index of the viewport.

**Returns:** The information nodes only in the specified viewport.

### GetViewportIdFromViewportNode(System.IntPtr)
Gets the object id of the specified viewport.

- **`gsMarker`**: The specified GsMarker.

**Returns:** The object id of the specified viewport.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: The exception is thrown if the specified viewport is not found.

### GetViewportNumberFromViewportNode(System.IntPtr)
Gets the view port number from the viewport node.

- **`gsMarker`**: The specified GsMarker.

**Returns:** The view port number.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: The exception is thrown if the specified viewport is not found.
