---
title: Autodesk.Aec.DatabaseServices.GsMarkerInformationNode
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > GsMarkerInformationNode
---

# Autodesk.Aec.DatabaseServices.GsMarkerInformationNode

## Summary
Represents a node of the GsMarker information.

## Properties

### GsMarker
Gets or sets the GsMarker of the node.

**Returns:** The GsMarker of the node.

### ParentNode
Gets or sets the parent of the node.

**Returns:** The parent of the node.

### ParentTree
Gets or sets the parent tree of the node.

**Returns:** The parent tree of the node.

### Name
Gets the name of the node.

**Returns:** The name of the node.

## Methods

### #ctor(Autodesk.Aec.DatabaseServices.GsMarkerInformationTree,Autodesk.Aec.DatabaseServices.GsMarkerInformationNode)
Initializes a new instance of the GsMarkerInformationNode class using the specified with the specified parent tree and parent node.

- **`parentTree`**: The specified parent tree.
- **`parentNode`**: The specified parent node.

### Clear
Clear the node and its children nodes.

### ContentToString(System.Boolean,System.Boolean)
Converts the GsMarker of the node to string.

- **`getName`**: The specified boolean value indicates if the name of the node should be added into the string collection.
- **`continueWithNextLevelNodes`**: The specified boolean value indicates if the GsMarkers of the children nodes should be converted to the strings.

**Returns:** The string collection contains the GsMarkers infomation.

### InformationNodeForGsMarker(System.IntPtr)
Gets the node specified by the GsMarker in the children nodes set.

- **`value`**: The specified GsMarker.

**Returns:** The node specified by the GsMarker.

### InformationNodesForGsMarker(System.IntPtr)
Gets all nodes specified by the GsMarker in the children nodes set.

- **`value`**: The specified GsMarker.

**Returns:** All nodes specified by the GsMarker.

### Add(Autodesk.Aec.DatabaseServices.GsMarkerInformationNode)
Adds the specified node to the children nodes set.

- **`node`**: The specified node to be added.

### CollectInformationNodes
Collects all children nodes of the node.

**Returns:** All children nodes of the node.

### CollectInformationNodes(Autodesk.AutoCAD.Runtime.RXClass,System.Boolean)
Collects the children nodes of the node, which have the same type as the specified class type.

- **`nodeClass`**: The specified class type.
- **`recursive`**: The boolean value indicates if the children of the nodes in the next level should be collected.

**Returns:** The children nodes have the same type as the specified class type.

### CollectLeafNodeGsMarkers
Gets the GsMarkers of all leaf nodes.

**Returns:** The GsMarkers of all leaf nodes.

### CollectLeafNodeGsMarkers(System.Boolean)
Gets the GsMarkers of all leaf nodes.

- **`collectAll3DBodyGsMarkers`**: The boolean value indicates if the GsMarkers of all 3D bodies should be collected.

**Returns:** The GsMarkers of all leaf nodes.

### ObjectIdFromOldId(System.Int32)
Gets the object id from the old id form.

- **`oldId`**: The specified old id.

**Returns:** The object id.
