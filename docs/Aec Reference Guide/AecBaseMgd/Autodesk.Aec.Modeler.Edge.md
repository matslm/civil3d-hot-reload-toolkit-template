---
title: Autodesk.Aec.Modeler.Edge
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > Edge
---

# Autodesk.Aec.Modeler.Edge

## Summary
Represents an edge.

## Properties

### Vertex
Gets or sets the vertex.

**Returns:** The vertex.

### Face
Gets or sets the face.

**Returns:** The face.

### Partner
Gets or sets the partner edge.

**Returns:** The partner edge.

### Curve
Gets the curve.

**Returns:** The curve.

### Color
Gets the color type.

**Returns:** The color type.

### PartnerBridgeEdge
Check for the bridge partners, i.e. a partner that has the same face as the edge.

**Returns:** Returns NULL if not a bridge.

### NextSkipBridge
Get next skip bridge.

**Returns:** The next skip bridge.

### PrevSkipBridge
Gets the previous skip bridge.

**Returns:** The previous skip bridge.

### Circle
Returns parameters of a circle if the edge lies on a geometric circle.

**Returns:** The circle.

### AngleBetweenFaces
Returns angle between the two faces sharing the "real" edge (or 0 if it is a non-manifold edge). For convex edges, the angle is less than pi;for concave edges, the angle is greater than pi.

**Returns:** The angle.

### AngleBetweenEdges
Returns angle between this edge and the previous edge. The angle is measured in the plane of the face owning these two edges.

**Returns:** The angle.

### Point
Returns coordinates of the point of the edge vertex.

**Returns:** The coordinates of the point of the edge vertex.

### Vector
Returns vector of the edge.

**Returns:** The vector of the edge.

### UnitVector
Returns unit vector of the edge.

**Returns:** The unit vector of the edge.

### Line
Returns a Line3d object with the edge geometry (point and vector).

**Returns:** Returns a Line3d object with the edge geometry (point and vector).

### Normal
Returns a unit normal vector to the edge. The direction of the normal vector is inside the face owning this edge.

**Returns:** The unit normal vector.

### VertexNormal
Returns a unit normal vector at the vertex of the edge.

**Returns:** The unit normal vector.

### Plane
Gets the plane.

**Returns:** The plane.

### Surface
Gets the surface.

**Returns:** The surface.

### IsOnCircle
Check if it is on circle.

**Returns:** True if it is on circle, false otherwise.

### IsOnFullCircle
Check if it is on full circle.

**Returns:** True if it is on full circle, false otherwise.

### IsManifold
Check if it is manifold.

**Returns:** True if it is manifold, false otherwise.

### AngleBetweenFacesIsConvex
Check if the angle between faces is convex.

**Returns:** True if the angle between faces is convex, false otherwise.

### AngleBetweenFacesIsConcave
Check if th angle between faces is concave.

**Returns:** True if the angle between faces is concave, false otherwise.

### AngleBetweenFacesIsStraight
Check if the angle between faces is straight.

**Returns:** True if the angle between faces is straight, false otherwise.

### IsBridge
Check if it is bridge.

**Returns:** True if it is bridge, false otherwise.

### IsApprox
Check if it is approx.

**Returns:** True if it is approx, false otherwise.

### BridgeFlag
Sets the bridge flag.

### IsEulerEdge
Check if it is euler edge.

**Returns:** Ture if it is euler edge, false otherwise.

### EulerEdge
Gets the euler edge.

**Returns:** The euler edge.

## Methods

### Create(System.IntPtr,System.Boolean)
Creates a wrapper class for Edge.

### #ctor
Initializes a new instance of the Edge class.

### #ctor(Autodesk.Aec.Modeler.Vertex,Autodesk.Aec.Modeler.Face,Autodesk.Aec.Modeler.Edge,Autodesk.Aec.Modeler.Edge,Autodesk.Aec.Modeler.Curve)
Initializes a new instance of the Edge class using the specified vertex, face, previous edge, partner edge and curve.

- **`vertex`**: The vertex.
- **`face`**: The face.
- **`previousEdge`**: The previous edge.
- **`partner`**: The partner edge.
- **`curve`**: The curve.

### #ctor(Autodesk.Aec.Modeler.Vertex,Autodesk.Aec.Modeler.Face,Autodesk.Aec.Modeler.Edge,Autodesk.Aec.Modeler.Edge)
Initializes a new instance of the Edge class using the specified vertex, face, previous edge, partner edge.

- **`vertex`**: The vertex.
- **`face`**: The face.
- **`previousEdge`**: The previous edge.
- **`partner`**: The partner edge.

### SetCurve(Autodesk.Aec.Modeler.Curve,System.Boolean)
Sets the curve.

- **`curve`**: The curve.
- **`partnersAlso`**: Determine if it set curve also to partners.

### SetColor(Autodesk.Aec.Modeler.ColorType,System.Boolean)
Sets the color.

- **`colorType`**: The color to be set.
- **`partnersAlso`**: Determine if it set color to its partners.

### AddPartner(Autodesk.Aec.Modeler.Edge)
Add partner edge.

- **`partnerEdge`**: The edge to be add.

### RemovePartner
Remove the partner edge.

### OrderPartnerEdgesAroundEulerEdge
Orders the partner edges around a non-manifold Euler edge so that the partner pointer of each edge is going to point to the edge whose face geometrically immediately follows the face of the edge, when going around the Euler edge.

### Collapse
Deletes the edge and its partners, fixing the adjacent topology so that  the edge is reduced to the start vertex of the edge. If edgeLoop() of the face points to an edge that will be deleted, it is changed to point  to the next edge in the loop (or to NULL if it was the only edge in the  loop)

### HasPartner(Autodesk.Aec.Modeler.Edge)
Check if it has partner.

- **`edge`**: The edge.

**Returns:** True if it has partner, false otherwise.

### CanMergeWithPrevious(System.Boolean)
Check if it can merge with previous edge.

- **`sameColorOnly`**: If merge with the same color only.

**Returns:** True if it can merge with previous edge.

### MergeLoopsSharingEdge
Merge loops sharing edge.

### MergeLoopsAddBridgeEdge(Autodesk.Aec.Modeler.Edge)
Merge loops add bridge edge.

- **`innerEdge`**: The inner edge.

### GetAllEdgesSharingSameFaces(System.Boolean)
Get all edges sharing same faces.

- **`connectedSequenceOnly`**: If connectedSequenceOnly is false, all edges are returned, possibly forming more than one connected sequence.

**Returns:** The edges sharing same faces.

### GetAllEdgesStartingFromVertex
Get all edges starting from vertex.

**Returns:** The edges starting from vertex.

### GetAllEdgesEndingInVertex
Get all edges ending in vertex.

**Returns:** The edges ending in vertex.

### GetAllConnectedEdgesSharingVertex
Get all connected edges sharing vertex.

**Returns:** The edges sharing vertex.

### Split(Autodesk.Aec.Modeler.Vertex)
Splits at vertex.

- **`vertex`**: The vertex to be split.

### Merge
Merges with previous edge.
