---
title: Autodesk.Aec.Modeler.Face
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > Face
---

# Autodesk.Aec.Modeler.Face

## Summary
Represents a Face.

## Properties

### Surface
Gets or sets the surface of the face.

**Returns:** Returns the surface of the face.

### FaceColor
Gets or sets the color of this face.

**Returns:** Returns the color of the face.

### Attribute
Gets or sets the customized attribute of the face.

**Returns:** Returns the customized attribute of the face.

### Area
Gets the area of the face.

**Returns:** Returns the area of the face.

### Plane
Gets the plane of the face.

**Returns:** Returns the plane of the face.

### IsSelfIntersecting
Gets to know whether this face is self intersecting.

**Returns:** True if this face is self intersecting.

### Edges
Gets all edges in the face.

## Methods

### #ctor
Initializes a new instance of the Face class.

### #ctor(Autodesk.Aec.Modeler.Body)
Initializes a new instance of the Face class using the specified body.

- **`body`**: Input the body.

### #ctor(Autodesk.Aec.Modeler.Surface,Autodesk.Aec.Modeler.Body)
Initializes a new instance of the Face class using the specified surface and body.

- **`surface`**: Input the surface.
- **`body`**: Input the body.

### #ctor(Autodesk.Aec.Modeler.Edge,Autodesk.Aec.Modeler.Surface,Autodesk.Aec.Modeler.Body)
Initializes a new instance of the Face class using the specified edge, surface, and body.

- **`edge`**: Input the edge.
- **`surface`**: Input the surface.
- **`body`**: Input the body.

### #ctor(Autodesk.AutoCAD.Geometry.CircularArc3d,Autodesk.Aec.Modeler.DirectionType,System.Int32,Autodesk.Aec.Modeler.Body)
Creates a circular face.

- **`circle`**: Input the circle.
- **`type`**: Input the direction type.
- **`approximation`**: Input the approximation of the approximation of the whole 2*pi angle.
- **`body`**: Input the body.

### #ctor(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,Autodesk.AutoCAD.Geometry.Vector3d,System.Int32,System.Boolean,Autodesk.Aec.Modeler.Body)
Creates a face from polygon data.

- **`points`**: Input the points of the profile polygon.
- **`vertexData`**: Input the vertices data of profile polygon.
- **`numberOfVertices`**: Input the number of vertices.
- **`polygonNormal`**: Input the polygon normal vector to determine the orientation of arcs.
- **`type`**: Input the direction type.
- **`checkPlanarity`**: Input the check planarity.
- **`body`**: Input the body.

### Modified
Modifies the face in some ways.

### SetSpecifiedColor(Autodesk.Aec.Modeler.ColorType,System.Boolean,System.Boolean)
Sets the specified color of the face.

- **`value`**: Input the color type of the face.
- **`edgesAlso`**: True if sets the color of the edges.
- **`partnerEdgesAlso`**: True if sets the color of the bridge edges.

### SetSpecifiedColor(Autodesk.Aec.Modeler.ColorType,System.Boolean)
Sets the specified color of the face.

- **`value`**: Input the color type of the face.
- **`edgesAlso`**: True if sets the color of the edges.

### Negate
Sets the face to be nagative.

### Paint(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.ColorType,System.Boolean,System.Boolean)
Paints the face with specified color.

- **`body`**: Input the owning body.
- **`color`**: Input the color type.
- **`dae`**: 
- **`dbe`**: 

### Paint(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.ColorType,System.Boolean)
Paints the face with specified color.

- **`body`**: Input the owning body.
- **`color`**: Input the color type.
- **`dae`**: 

### Paint(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.ColorType)
Paints the face with specified color.

- **`body`**: Input the owning body.
- **`color`**: Input the color type.

### PerimeterOfMass(Autodesk.Aec.Modeler.Body,System.Boolean,System.Boolean)
Gets the perimeter of the mass.

- **`body`**: Input the body of the mass.
- **`dae`**: 
- **`dbe`**: 

**Returns:** Returns the perimeter of the mass.

### AreaOfMass(Autodesk.Aec.Modeler.Body,System.Boolean,System.Boolean)
Gets the area of the mass.

- **`body`**: Input the body of the mass.
- **`dae`**: 
- **`dbe`**: 

**Returns:** Returns the area of the mass.

### CentroidOfMass(Autodesk.Aec.Modeler.Body,System.Boolean,System.Boolean)
Gets the centroid of the mass.

- **`body`**: Input the body of the mass.
- **`dae`**: 
- **`dbe`**: 

**Returns:** Returns the centroid of the mass.

### Lift(Autodesk.AutoCAD.Geometry.Matrix3d,System.Boolean,Autodesk.Aec.Modeler.Body)
Lifts the face from its current location to a new location.

- **`transform`**: Input the transformation matrix.
- **`checkPlanarity`**: True if checking the planarity of the lifted face.
- **`owningBody`**: Input the owning body.

### ExtractAllLoops
Extracts all edge loops of the face, skipping the bridge edges.

**Returns:** Returns the extracted edge loops of the face.

### Split(Autodesk.Aec.Modeler.Edge,Autodesk.Aec.Modeler.Edge,Autodesk.Aec.Modeler.Body)
Splits the face at the vertice of two supplied edges.

- **`edgeA`**: Input the first edge on the face to get vertex.
- **`edgeB`**: Input the second edge on the face to get vertex.
- **`body`**: Input the owning body.

**Returns:** Returns the newly created face by spliting.

### InsertHoles(Autodesk.Aec.Modeler.Face[],Autodesk.Aec.Modeler.Body)
Inserts holes on the face.

- **`holeFaces`**: Input the holes to insert on face.
- **`body`**: Input the owning body.

**Returns:** Returns resulting faces after inserting holes.

### DecomposeIntoContiguousFaces(Autodesk.Aec.Modeler.Body)
Decomposes this face into contiguous faces.

- **`body`**: Input the owning body.

**Returns:** Returns an array of contiguous faces.

### DeletePlane
Deletes the plane of the face.

### DeleteInterval
Deletes the interval in the face.

### DeleteProjectionInterval
Deletes the projection interval in the face.

### IsPointInside(Autodesk.AutoCAD.Geometry.Point3d)
Gets to know whether speicified point is in this face.

- **`point`**: Input the specified point.

**Returns:** True if the specified point is in this face.

### IsPlanar(System.Double)
Gets to know whehter this face is planar.

- **`epsilon`**: Input the epsilon value.

**Returns:** True if the face is planar.
