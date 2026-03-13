---
title: Autodesk.Aec.Modeler.Body
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > Body
---

# Autodesk.Aec.Modeler.Body

## Summary
Represents a body.

## Properties

### Area
Gets the area of the body.

**Returns:** The area of the body.

### Volume
Gets the volume of the body.

**Returns:** The volume of the body.

### Centroid
Gets the centroid of the body.

**Returns:** The centroid of the body.

### Moments
Gets the moments of the body.

**Returns:** The moments of the body.

### Products
Gets the products of the body.

**Returns:** The products of the body.

### Next
Gets or sets the next body.

**Returns:** The resulting body.

### IsValid
Determines if the body is valid.

**Returns:** Returns true if the body is valid.

### Interval
Returns the interval of the body.

**Returns:** The interval of the body.

### IsNull
Gets to know whether the body is null or not.

**Returns:** True if the body is null.

### IsNegated
Gets to know whether the body is negated or not.

**Returns:** True if the body is negated.

### ContainsNonManifoldEdges
Gets to know whether this body contains non-mainfold edges.

**Returns:** True if this body contains non-mainfold edges.

### Faces
Gets the face collection.

**Returns:** The face collection.

### Surfaces
Gets the surface collection.

**Returns:** The surface collection.

### Curves
Gets the curve collection.

**Returns:** The curve collection.

### Vertices
Gets the vertex collection.

**Returns:** The vertex collection.

### PhysicalEdges
Gets physical edges of the body.

**Returns:** Returns an array contains all physical edges.

### PhysicalVertices
Gets physical vertices of the body.

**Returns:** Returns an array contains all physical vertices.

## Methods

### Create(System.IntPtr,System.Boolean)
Creates a wrapper class for Body.

- **`unmanagedPointer`**: The native pointer.
- **`autoDelete`**: If it is auto deleted.

### #ctor
Initializes a new instance of the Body class.

### Copy
Makes a copy of the body.

**Returns:** A new copy of the body.

### Modified
Sets the body modified.

### BooleanOperation(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.BooleanOperatorType)
Performs a boolean operation.

- **`body`**: The other body.
- **`type`**: The boolean operation.

**Returns:** The resulting body.

### Section(Autodesk.AutoCAD.Geometry.Plane,System.Boolean)
Sections the body.

- **`plane`**: Cutting plane.
- **`keepInputBodyWhenFails`**: Preserves the body if the operation fails.

### op_Addition(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body)
Adds two Body objects.

- **`body1`**: Body one.
- **`body2`**: Body two.

**Returns:** The resulting body.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### Add(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body)
Adds two Body objects.

- **`body1`**: Body one.
- **`body2`**: Body two.

**Returns:** The resulting body.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### op_Subtraction(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body)
Subtracts two Body objects.

- **`body1`**: Body one.
- **`body2`**: Body two.

**Returns:** The resulting body.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### Subtract(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body)
Subtracts two Body objects.

- **`body1`**: Body one.
- **`body2`**: Body two.

**Returns:** The resulting body.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### op_Multiply(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body)
Multiplies two Body objects.

- **`body1`**: Body one.
- **`body2`**: Body two.

**Returns:** The resulting body.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### Multiply(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body)
Multiplies two Body objects.

- **`body1`**: Body one.
- **`body2`**: Body two.

**Returns:** The resulting body.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### op_Equality(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body)
Check if the bodies are equal.

- **`body1`**: The first body.
- **`body2`**: The second body.

**Returns:** true, if the bodies are equal; false, otherwise.

### op_Inequality(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body)
Check if the bodies are not equal.

- **`body1`**: The first body.
- **`body2`**: The second body.

**Returns:** True if the bodies are not equal, otherwise false.

### Equals(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body)
Check if the bodies are equal.

- **`body1`**: The first body.
- **`body2`**: The second body.

**Returns:** true, if the bodies are equal; false, otherwise.

### op_Subtraction(Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Plane)
Subtracts the Plane from Body1.

- **`body`**: The body.
- **`plane`**: The plane.

**Returns:** The resulting body.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### Subtract(Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Plane)
Subtracts the plane from body.

- **`body`**: The body.
- **`plane`**: The plane.

**Returns:** The resulting body.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### Contains(Autodesk.AutoCAD.Geometry.Point3d)
Determines the position of a point relative to the body.

- **`point`**: The point.

**Returns:** Returns information about the point location.

### PlaneIntersectsBody(Autodesk.AutoCAD.Geometry.Plane)
Determines if a plane intersects the body.

- **`plane`**: The plane.

**Returns:** Returns true if the plane intersects the body.

### Combine(Autodesk.Aec.Modeler.Body)
Combines the body with another body.

- **`body`**: The other body.

**Returns:** The resulting body.

### Translate(Autodesk.AutoCAD.Geometry.Vector3d)
Translates the body location.

- **`vector`**: The translation vector.

**Returns:** The resulting body.

### Rotate(Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double)
Rotates the body.

- **`axis`**: The axis to rotate about.
- **`angle`**: The angle of rotation.

**Returns:** The resulting body.

### Scale(Autodesk.AutoCAD.Geometry.Point3d,System.Double)
Scales the body.

- **`fixedPoint`**: The point to scale about.
- **`factor`**: The scale factor.

**Returns:** The resulting body.

### Scale(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Vector3d)
Scales the body.

- **`fixedPoint`**: The point to scale about.
- **`xyzFactors`**: The X, Y, and Z scale factors.

**Returns:** The resulting body.

### Stretch(Autodesk.AutoCAD.Geometry.LineSegment3d)
Stretches the body.

- **`line`**: The line to stretch about.

**Returns:** The resulting body.

### Mirror(Autodesk.AutoCAD.Geometry.Plane)
Mirrors the body.

- **`plane`**: The plane to mirror about.

**Returns:** The resulting body.

### Align(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d)
Aligns the body.

- **`source1`**: The first source point.
- **`source2`**: The second source point.
- **`source3`**: The third source point.
- **`destination1`**: The first destination point.
- **`destination2`**: The second destination point.
- **`destination3`**: The third destination point.

**Returns:** The resulting body.

### Align(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Vector3d)
Aligns the body.

- **`source1`**: The first source point.
- **`source2`**: The second source vector.
- **`source3`**: The third source vector.
- **`destination1`**: The first destination point.
- **`destination2`**: The second destination vector.
- **`destination3`**: The third destination vector.

**Returns:** The resulting body.

### Align(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Vector3d)
Aligns the body.

- **`source1`**: The first source point.
- **`source2`**: The second source vector.
- **`destination1`**: The first destination point.
- **`destination2`**: The second destination vector.

**Returns:** The resulting body.

### Transform(Autodesk.AutoCAD.Geometry.Matrix3d)
Transforms the body.

- **`matrix`**: The transformation matrix.

**Returns:** The resulting body.

### op_UnaryNegation(Autodesk.Aec.Modeler.Body)
Negates the Body object.

- **`body`**: The Body to negate.

**Returns:** The negated body (volume).

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### Negate(Autodesk.Aec.Modeler.Body)
Negates the Body object.

- **`body`**: The Body to negate.

**Returns:** The negated body (volume).

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### Box(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Vector3d)
Creates a box.

- **`corner`**: The first corner of the box.
- **`sizes`**: The X, Y and Z sizes.

**Returns:** The resulting body.

### Sphere(Autodesk.AutoCAD.Geometry.Point3d,System.Double,System.Int32)
Creates a sphere.

- **`center`**: The center.
- **`radius`**: The radius.
- **`surfaceFacets`**: The number of facets.

**Returns:** The resulting body.

### Cylinder(Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double,System.Int32)
Creates a cylinder.

- **`axis`**: The axis.
- **`radius`**: The radius.
- **`surfaceFacets`**: The number of facets.

**Returns:** The resulting body.

### Cylinder(Autodesk.AutoCAD.Geometry.LineSegment3d,Autodesk.AutoCAD.Geometry.Vector3d,System.Double,System.Int32)
Creates a cylinder.

- **`axis`**: The axis.
- **`baseNormal`**: The normal vector.
- **`radius`**: The radius.
- **`surfaceFacets`**: The number of facets.

**Returns:** The resulting body.

### Cone(Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double,System.Double,System.Int32)
Creates a cone.

- **`axis`**: The axis.
- **`radius1`**: The first radius.
- **`radius2`**: The second radius.
- **`surfaceFacets`**: The number of facets.

**Returns:** The resulting body.

### Cone(Autodesk.AutoCAD.Geometry.LineSegment3d,Autodesk.AutoCAD.Geometry.Vector3d,System.Double,System.Double,System.Int32)
Creates a cone.

- **`axis`**: The axis.
- **`baseNormal`**: The normal vector.
- **`radius1`**: The first radius.
- **`radius2`**: The second radius.
- **`surfaceFacets`**: The number of facets.

**Returns:** The resulting body.

### TorusExtension(Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double,System.Double,System.Int32,System.Int32)
Creates a torus extension.

- **`axis`**: The axis.
- **`majorRadius`**: The major axis radius.
- **`minorRadius`**: The minor axis radius.
- **`majorSurfaceFacets`**: The number of major facets.
- **`minorSurfaceFacets`**: The number of minor facets.

**Returns:** The resulting body.

### Torus(Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double,System.Double,System.Int32,System.Int32)
Creates a torus.

- **`axis`**: The axis.
- **`majorRadius`**: The major axis radius.
- **`minorRadius`**: The minor axis radius.
- **`majorSurfaceFacets`**: The number of major facets.
- **`minorSurfaceFacets`**: The number of minor facets.

**Returns:** The resulting body.

### Pipe(Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double,System.Double,System.Int32)
Creates a pipe.

- **`axis`**: The axis.
- **`outerRadius`**: The outer radius.
- **`innerRadius`**: The inner radius.
- **`surfaceFacets`**: The number of facets.

**Returns:** The resulting body.

### Pipe(Autodesk.AutoCAD.Geometry.LineSegment3d,Autodesk.AutoCAD.Geometry.Vector3d,System.Double,System.Double,System.Int32)
Creates a pipe.

- **`axis`**: The axis.
- **`baseNormal`**: The normal vector.
- **`outerRadius`**: The outer radius.
- **`innerRadius`**: The inner radius.
- **`surfaceFacets`**: The number of facets.

**Returns:** The resulting body.

### PipeConic(Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double,System.Double,System.Double,System.Double,System.Int32)
Creates a conic pipe.

- **`axis`**: The axis.
- **`outerRadius1`**: The first outer radius.
- **`innerRadius1`**: The first inner radius.
- **`outerRadius2`**: The second outer radius.
- **`innerRadius2`**: The second inner radius.
- **`surfaceFacets`**: The number of facets.

**Returns:** The resulting body.

### PipeConic(Autodesk.AutoCAD.Geometry.LineSegment3d,Autodesk.AutoCAD.Geometry.Vector3d,System.Double,System.Double,System.Double,System.Double,System.Int32)
Creates a conic pipe.

- **`axis`**: The axis.
- **`baseNormal`**: The normal vector.
- **`outerRadius1`**: The first outer radius.
- **`innerRadius1`**: The first inner radius.
- **`outerRadius2`**: The second outer radius.
- **`innerRadius2`**: The second inner radius.
- **`surfaceFacets`**: The number of facets.

**Returns:** The resulting body.

### Tetrahedron(Autodesk.AutoCAD.Geometry.Point3dCollection)
Creates a tetrahedron.

- **`points`**: The collection of 4 points.

**Returns:** The resulting body.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### ReducingElbow(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d,System.Double,System.Double,System.Int32,System.Int32)
Creates a reducing elbow.

- **`elbowCenter`**: The center point.
- **`endCenter1`**: The first end point.
- **`endCenter2`**: The second end point.
- **`endRadius1`**: The first end radius.
- **`endRadius2`**: The second end radius.
- **`majorSurfaceFacets`**: The number of major facets.
- **`minorSurfaceFacets`**: The number of minor facets.

**Returns:** The resulting body.

### RectangleToCircleReducer(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Vector2d,Autodesk.AutoCAD.Geometry.CircularArc3d,System.Int32)
Creates a reducer.

- **`baseCorner`**: The corner of the rectangle base.
- **`baseSizes`**: The X, Y and Z sizes of the rectangle.
- **`topCircle`**: The top circle.
- **`surfaceFacets`**: The number of facets.

**Returns:** The resulting body.

### ConvexHull(Autodesk.AutoCAD.Geometry.Point3dCollection)
Creates a convex hull.

- **`points`**: A points collection.

**Returns:** The resulting body.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### RayIntersectionStatus(Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double)
Gets the status indicating what type of entity (if any) has been intersected.

- **`ray`**: Input the ray to be intersected.
- **`tolerance`**: Input the tolerance to decide whether the ray intersects an edge or a vertex.

**Returns:** Returns the status indicating what type of entity (if any) has been intersected.

### ClosestEntityOfRayIntersection(Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double)
Gets the closest intersected entity.

- **`ray`**: Input the ray to be intersected.
- **`tolerance`**: Input the tolerance to decide whether the ray intersects an edge or a vertex.

**Returns:** Returns the closest intersected entity.

### ClosestDistanceOfRayIntersection(Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double)
Gets the distance of the closest intersected entity from the ray point.

- **`ray`**: Input the ray to be intersected.
- **`tolerance`**: Input the tolerance to decide whether the ray intersects an edge or a vertex.

**Returns:** Returns the distance of the closest intersected entity from the ray point.

### Extrusion(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Point3d,System.Double,System.Double)
Extrudes the given profile polygon along the extrusionVector.

- **`points`**: Input the points of the profile polygon.
- **`vertexData`**: Input the vertices data of profile polygon.
- **`numberOfVertices`**: Input the number of vertices.
- **`polygonNormal`**: Input the polygon normal vector to determine the orientation of arcs.
- **`extrusionVector`**: Input the extrusion vector.
- **`scaleTwistFixedPoint`**: Input the center of the scaling/rotation and must lie in the profile polygon plane.
- **`scaleFactor`**: Input the scale factor to allow profile to be scaled while being extruded.
- **`twistAngle`**: Input the twist angle to allow profile to be rotating while being extruded.

**Returns:** Return the extruded profile polygon.

### Extrusion(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Point3d,System.Double)
Extrudes the given profile polygon along the extrusionVector.

- **`points`**: Input the points of the profile polygon.
- **`vertexData`**: Input the vertices data of profile polygon.
- **`numberOfVertices`**: Input the number of vertices.
- **`polygonNormal`**: Input the polygon normal vector to determine the orientation of arcs.
- **`extrusionVector`**: Input the extrusion vector.
- **`scaleTwistFixedPoint`**: Input the center of the scaling/rotation and must lie in the profile polygon plane.
- **`scaleFactor`**: Input the scale factor to allow profile to be scaled while being extruded.

**Returns:** Return the extruded profile polygon.

### Extrusion(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Vector3d)
Extrudes the given profile polygon along the extrusionVector.

- **`points`**: Input the points of the profile polygon.
- **`vertexData`**: Input the vertices data of profile polygon.
- **`numberOfVertices`**: Input the number of vertices.
- **`polygonNormal`**: Input the polygon normal vector to determine the orientation of arcs.
- **`extrusionVector`**: Input the extrusion vector.

**Returns:** Return the extruded profile polygon.

### Pyramid(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Point3d)
Extrudes the given profile polygon to the point pyramid apex.

- **`points`**: Input the points of the profile polygon.
- **`vertexData`**: Input the vertices data of profile polygon.
- **`numberOfVertices`**: Input the number of vertices.
- **`polygonNormal`**: Input the polygon normal vector to determine the orientation of arcs.
- **`pyramidApex`**: Input the point pyramid apex.

**Returns:** Return the extruded profile polygon.

### AxisRevolution(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double,System.Int32,Autodesk.AutoCAD.Geometry.Point3d,System.Double,System.Double)
Revolves the given profile polygon around the given axis.

- **`points`**: Input the points of the profile polygon.
- **`vertexData`**: Input the vertices data of profile polygon.
- **`numberOfVertices`**: Input the number of vertices.
- **`polygonNormal`**: Input the polygon normal vector to determine the orientation of arcs.
- **`axis`**: Input the axis to revolve the given profile polygon.
- **`revolutionAngle`**: Input the revolution angle.
- **`approximation`**: Input the approximation of the approximation of the whole 2*pi angle.
- **`scaleTwistFixedPoint`**: Input the center of the scaling/rotation and must lie in the profile polygon plane.
- **`scaleFactor`**: Input the scale factor to allow profile to be scaled while being extruded.
- **`twistAngle`**: Input the twist angle to allow profile to be rotating while being extruded.

**Returns:** Returns the revolved profile polygon.

### AxisRevolution(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double,System.Int32,Autodesk.AutoCAD.Geometry.Point3d,System.Double)
Revolves the given profile polygon around the given axis.

- **`points`**: Input the points of the profile polygon.
- **`vertexData`**: Input the vertices data of profile polygon.
- **`numberOfVertices`**: Input the number of vertices.
- **`polygonNormal`**: Input the polygon normal vector to determine the orientation of arcs.
- **`axis`**: Input the axis to revolve the given profile polygon.
- **`revolutionAngle`**: Input the revolution angle.
- **`approximation`**: Input the approximation of the approximation of the whole 2*pi angle.
- **`scaleTwistFixedPoint`**: Input the center of the scaling/rotation and must lie in the profile polygon plane.
- **`scaleFactor`**: Input the scale factor to allow profile to be scaled while being extruded.

**Returns:** Returns the revolved profile polygon.

### AxisRevolution(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.LineSegment3d,System.Double,System.Int32)
Revolves the given profile polygon around the given axis.

- **`points`**: Input the points of the profile polygon.
- **`vertexData`**: Input the vertices data of profile polygon.
- **`numberOfVertices`**: Input the number of vertices.
- **`polygonNormal`**: Input the polygon normal vector to determine the orientation of arcs.
- **`axis`**: Input the axis to revolve the given profile polygon.
- **`revolutionAngle`**: Input the revolution angle.
- **`approximation`**: Input the approximation of the approximation of the whole 2*pi angle.

**Returns:** Returns the revolved profile polygon.

### EndPointRevolution(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,Autodesk.AutoCAD.Geometry.Vector3d,System.Double,System.Int32)
Revolves the given profile polygon about the axis defined by the first and the last point of the profile.

- **`points`**: Input the points of the profile polygon.
- **`vertexData`**: Input the vertices data of profile polygon.
- **`numberOfVertices`**: Input the number of vertices.
- **`polygonNormal`**: Input the polygon normal vector to determine the orientation of arcs.
- **`revolutionAngle`**: Input the revolution angle.
- **`approximation`**: Input the approximation of the approximation of the whole 2*pi angle.

**Returns:** Returns the revolved profile polygon.

### ExtrusionAlongPath(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,System.Boolean,System.Boolean,Autodesk.AutoCAD.Geometry.Point3d,System.Double,System.Double,Autodesk.Aec.Modeler.MorphingMap,System.Boolean,Autodesk.AutoCAD.Geometry.IntegerCollection,Autodesk.AutoCAD.Geometry.IntegerCollection)
Creates a body by extruding the given start profile along the given path with the end profile.

- **`startProfile`**: Input the start profile.
- **`endProfile`**: Input the end profile.
- **`pathPolygon`**: Input the points of the polygon path.
- **`pathVertexData`**: Input the vertex data of the polygon path.
- **`numberOfPathVertices`**: Input the number of the vertices in the path.
- **`pathIsClosed`**: True if path is closed.
- **`checkBodyValidity`**: True if checking body validity.
- **`scaleTwistFixedPoint`**: Input the center of the scaling/rotation and must lie in the profile polygon plane.
- **`scaleFactor`**: Input the scale factor to allow profile to be scaled while being extruded.
- **`twistAngle`**: Input the twist angle to allow profile to be rotating while being extruded.
- **`morphingMap`**: Input the morphing map to specify how the topology of the start profile morph to the topology of the end profile.
- **`calculateMorphingMapAutomatically`**: True if calculate morphing map automatically.
- **`startProfileSignificantVertices`**: Input the significant vertices of the start profile.
- **`endProfileSignificantVertices`**: Input the significant vertices of the end profile.

**Returns:** Returns the extruded profile.

### ExtrusionAlongPath(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,System.Boolean,System.Boolean,Autodesk.AutoCAD.Geometry.Point3d,System.Double,System.Double,Autodesk.Aec.Modeler.MorphingMap,System.Boolean,Autodesk.AutoCAD.Geometry.IntegerCollection)
Creates a body by extruding the given start profile along the given path with the end profile.

- **`startProfile`**: Input the start profile.
- **`endProfile`**: Input the end profile.
- **`pathPolygon`**: Input the points of the polygon path.
- **`pathVertexData`**: Input the vertex data of the polygon path.
- **`numberOfPathVertices`**: Input the number of the vertices in the path.
- **`pathIsClosed`**: True if path is closed.
- **`checkBodyValidity`**: True if checking body validity.
- **`scaleTwistFixedPoint`**: Input the center of the scaling/rotation and must lie in the profile polygon plane.
- **`scaleFactor`**: Input the scale factor to allow profile to be scaled while being extruded.
- **`twistAngle`**: Input the twist angle to allow profile to be rotating while being extruded.
- **`morphingMap`**: Input the morphing map to specify how the topology of the start profile morph to the topology of the end profile.
- **`calculateMorphingMapAutomatically`**: True if calculate morphing map automatically.
- **`startProfileSignificantVertices`**: Input the significant vertices of the start profile.

**Returns:** Returns the extruded profile.

### ExtrusionAlongPath(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,System.Boolean,System.Boolean,Autodesk.AutoCAD.Geometry.Point3d,System.Double,System.Double,Autodesk.Aec.Modeler.MorphingMap,System.Boolean)
Creates a body by extruding the given start profile along the given path with the end profile.

- **`startProfile`**: Input the start profile.
- **`endProfile`**: Input the end profile.
- **`pathPolygon`**: Input the points of the polygon path.
- **`pathVertexData`**: Input the vertex data of the polygon path.
- **`numberOfPathVertices`**: Input the number of the vertices in the path.
- **`pathIsClosed`**: True if path is closed.
- **`checkBodyValidity`**: True if checking body validity.
- **`scaleTwistFixedPoint`**: Input the center of the scaling/rotation and must lie in the profile polygon plane.
- **`scaleFactor`**: Input the scale factor to allow profile to be scaled while being extruded.
- **`twistAngle`**: Input the twist angle to allow profile to be rotating while being extruded.
- **`morphingMap`**: Input the morphing map to specify how the topology of the start profile morph to the topology of the end profile.
- **`calculateMorphingMapAutomatically`**: True if calculate morphing map automatically.

**Returns:** Returns the extruded profile.

### ExtrusionAlongPath(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,System.Boolean,System.Boolean,Autodesk.AutoCAD.Geometry.Point3d,System.Double,System.Double,Autodesk.Aec.Modeler.MorphingMap)
Creates a body by extruding the given start profile along the given path with the end profile.

- **`startProfile`**: Input the start profile.
- **`endProfile`**: Input the end profile.
- **`pathPolygon`**: Input the points of the polygon path.
- **`pathVertexData`**: Input the vertex data of the polygon path.
- **`numberOfPathVertices`**: Input the number of the vertices in the path.
- **`pathIsClosed`**: True if path is closed.
- **`checkBodyValidity`**: True if checking body validity.
- **`scaleTwistFixedPoint`**: Input the center of the scaling/rotation and must lie in the profile polygon plane.
- **`scaleFactor`**: Input the scale factor to allow profile to be scaled while being extruded.
- **`twistAngle`**: Input the twist angle to allow profile to be rotating while being extruded.
- **`morphingMap`**: Input the morphing map to specify how the topology of the start profile morph to the topology of the end profile.

**Returns:** Returns the extruded profile.

### ExtrusionAlongPath(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,System.Boolean,System.Boolean,Autodesk.AutoCAD.Geometry.Point3d,System.Double,System.Double)
Creates a body by extruding the given start profile along the given path with the end profile.

- **`startProfile`**: Input the start profile.
- **`endProfile`**: Input the end profile.
- **`pathPolygon`**: Input the points of the polygon path.
- **`pathVertexData`**: Input the vertex data of the polygon path.
- **`numberOfPathVertices`**: Input the number of the vertices in the path.
- **`pathIsClosed`**: True if path is closed.
- **`checkBodyValidity`**: True if checking body validity.
- **`scaleTwistFixedPoint`**: Input the center of the scaling/rotation and must lie in the profile polygon plane.
- **`scaleFactor`**: Input the scale factor to allow profile to be scaled while being extruded.
- **`twistAngle`**: Input the twist angle to allow profile to be rotating while being extruded.

**Returns:** Returns the extruded profile.

### ExtrusionAlongPath(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,System.Boolean,System.Boolean,Autodesk.AutoCAD.Geometry.Point3d,System.Double)
Creates a body by extruding the given start profile along the given path with the end profile.

- **`startProfile`**: Input the start profile.
- **`endProfile`**: Input the end profile.
- **`pathPolygon`**: Input the points of the polygon path.
- **`pathVertexData`**: Input the vertex data of the polygon path.
- **`numberOfPathVertices`**: Input the number of the vertices in the path.
- **`pathIsClosed`**: True if path is closed.
- **`checkBodyValidity`**: True if checking body validity.
- **`scaleTwistFixedPoint`**: Input the center of the scaling/rotation and must lie in the profile polygon plane.
- **`scaleFactor`**: Input the scale factor to allow profile to be scaled while being extruded.

**Returns:** Returns the extruded profile.

### ExtrusionAlongPath(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,System.Boolean,System.Boolean,Autodesk.AutoCAD.Geometry.Point3d)
Creates a body by extruding the given start profile along the given path with the end profile.

- **`startProfile`**: Input the start profile.
- **`endProfile`**: Input the end profile.
- **`pathPolygon`**: Input the points of the polygon path.
- **`pathVertexData`**: Input the vertex data of the polygon path.
- **`numberOfPathVertices`**: Input the number of the vertices in the path.
- **`pathIsClosed`**: True if path is closed.
- **`checkBodyValidity`**: True if checking body validity.
- **`scaleTwistFixedPoint`**: Input the center of the scaling/rotation and must lie in the profile polygon plane.

**Returns:** Returns the extruded profile.

### ExtrusionAlongPath(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,System.Boolean,System.Boolean)
Creates a body by extruding the given start profile along the given path with the end profile.

- **`startProfile`**: Input the start profile.
- **`endProfile`**: Input the end profile.
- **`pathPolygon`**: Input the points of the polygon path.
- **`pathVertexData`**: Input the vertex data of the polygon path.
- **`numberOfPathVertices`**: Input the number of the vertices in the path.
- **`pathIsClosed`**: True if path is closed.
- **`checkBodyValidity`**: True if checking body validity.

**Returns:** Returns the extruded profile.

### ExtrusionAlongPath(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],System.Int32,System.Boolean)
Creates a body by extruding the given start profile along the given path with the end profile.

- **`startProfile`**: Input the start profile.
- **`endProfile`**: Input the end profile.
- **`pathPolygon`**: Input the points of the polygon path.
- **`pathVertexData`**: Input the vertex data of the polygon path.
- **`numberOfPathVertices`**: Input the number of the vertices in the path.
- **`pathIsClosed`**: True if path is closed.

**Returns:** Returns the extruded profile.

### Skin(Autodesk.Aec.Modeler.BodyCollection,System.Int32,System.Boolean,System.Boolean,Autodesk.Aec.Modeler.MorphingMap[],System.Boolean,System.Boolean)
Creates a body which covers the given set of profiles(cross-sections).

- **`profiles`**: Input the profiles consisting of bodies, which each contains a single face.
- **`numberOfProfiles`**: Input the number of profiles.
- **`isClosed`**: Specify whether the created body is closed.
- **`checkPlanarity`**: Specify whether the generated faces should be checked for the planarity and broken into triangles if not planar.
- **`morphingMaps`**: Defines the topology morphing between the individual profiles.
- **`markInnerProfileEdgesAsApproximation`**: True if the edges corresponding to the inner profiles are marked as approximating.
- **`checkInputProfiles`**: True if the input profiles are checked for validity.

**Returns:** Returns the body with the given set of profiles.

### SetHiddenLineParameters(Autodesk.Aec.Modeler.HiddenLinesDisplay,System.Boolean,System.Boolean)
Sets the edge visibility characteristics.

- **`display`**: Input the display characteristics of edges.
- **`displayApproximationEdges`**: True if displaying the approximation edges.
- **`displayBridgeEdges`**: True if display bridge edges.

### SetHiddenLineParameters(Autodesk.Aec.Modeler.HiddenLinesDisplay,System.Boolean)
Sets the edge visibility characteristics.

- **`display`**: Input the display characteristics of edges.
- **`displayApproximationEdges`**: True if displaying the approximation edges.

### SetHiddenLineParameters(Autodesk.Aec.Modeler.HiddenLinesDisplay)
Sets the edge visibility characteristics.

- **`display`**: Input the display characteristics of edges.

### SetHiddenLineParameters
Sets the edge visibility characteristics.

### TriangulateFace(Autodesk.Aec.Modeler.Face)
Breaks the given face into several triangular faces.

- **`face`**: Input the face to be triangulated.

### TriangulateAllFaces
Breaks all faces body into many triangular faces.

**Remarks:**
Use this method with caution. It will create a large number of triangular faces which are not memory efficient.

### SaveToSAT(System.String,System.Boolean)
Save to ACIS SAT text file.

- **`fileName`**: Input the name of the saved file.
- **`colorsAlso`**: True if every face and edge receives a color-adesk-attrib.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### SaveToSAT(System.String)
Save to ACIS SAT text file.

- **`fileName`**: Input the name of the saved file.

- **Exception `T:System.ArgumentNullException`**: System.ArgumentNullException.

### StitchFaces(System.Boolean,System.Boolean,System.Boolean)
Create the proper topological structure.

- **`splitEdges`**: True if the edges are split by these vertices lying on them.
- **`orientFaces`**: True if want to orient all the faces so that the result is a valid B-Rep of a solid body.
- **`addMissingFaces`**: True if want to add new faces when there are gaps in the boundary.

### StitchFaces(System.Boolean,System.Boolean)
Create the proper topological structure.

- **`splitEdges`**: True if the edges are split by these vertices lying on them.
- **`orientFaces`**: True if want to orient all the faces so that the result is a valid B-Rep of a solid body.

### StitchFaces(System.Boolean)
Create the proper topological structure.

- **`splitEdges`**: True if the edges are split by these vertices lying on them.

### StitchFaces
Create the proper topological structure.

### MergeCoplanarFaces(Autodesk.Aec.Modeler.Edge)
Merges coplanar faces to produce a smaller model.

- **`edgeBetweenFaces`**: Input the edge between coplanar faces.

### MergeEqualSurfaces
Finds surfaces that are geometrically equal and leaves just one surface for each group of equal surface objects.

### MakeArcTessellationsInExtrusionsCoincident(Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Vector3d)
Makes tessellated arcs in extrusions to be coincident.

- **`referenceExtrusion`**: Input the referenct extrusion body.
- **`extrusionVector`**: Input the extrusion vector.

**Returns:** Return false if some facets they should be adjusted might be left not adjusted.

- **Exception `T:System.Exception`**: System.Exception.

### CopyGeometryFrom(Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Matrix3d)
Copy the geometry from a given body to this body, and transform the geometry by the given transform.

- **`body`**: Input the body to be copied from.
- **`matrix`**: Input the transforming matrix.

### CopyGeometryFrom(Autodesk.Aec.Modeler.Body)
Copy the geometry from a given body to this body, and transform the geometry by the given transform.

- **`body`**: Input the body to be copied from.

### DecomposeIntoLumps
Decomposes the body into one or more lump bodies.

**Returns:** Returns the collection of lump bodies.

### GenerateUnspecifiedSurfaces(System.Double,System.Int32)
Generates unspecified surfaces with specified angle tolerance.

- **`angleTolerance`**: Input the angle tolerance.
- **`minNumberOfFacesInSurface`**: Input the minimum number of the faces in surface.

### GenerateUnspecifiedSurfaces(System.Double)
Generates unspecified surfaces with specified angle tolerance.

- **`angleTolerance`**: Input the angle tolerance.

### GenerateUnspecifiedSurfacesFromApproximationEdges(System.Int32)
Generates unspecified surfaces from approximation edges.

- **`minNumberOfFacesInSurface`**: Input the minimum number of the faces in surface.

### GenerateUnspecifiedSurfacesFromApproximationEdges
Generates unspecified surfaces from approximation edges.

### ConvertToTerrainBody(System.Double,System.Boolean)
Converts the body whose set of faces represents a terrain surface to a volumetric terrain body.

- **`height`**: Input the given height to indicate the distance of the newly generated bottom faces from the lowest vertex of the terrain surface.
- **`checkValidity`**: True if wants to check validity of the terrain body.

**Returns:** Returns all vertical side faces and horizontal bottom faces of a volumetric terrain body.

### SetColor(Autodesk.Aec.Modeler.ColorType)
Sets color type of the body.

- **`value`**: Input the value of color type.

### GetIsValid(Autodesk.Aec.Modeler.ValidityCheckingLevel)
Checks validity of topology and geometry of the body with specified level.

- **`level`**: Input the checking level of validity.

**Returns:** Returns true if this body is valid.

### SetApproximatingEdgeAndBridgeEdgeFlags(System.Boolean)
Makes the approximating edge and bridge edge flags to be set with some specified values or not.

- **`mark`**: True if want to set these flags.

### SetApproximatingEdgeAndBridgeEdgeFlags
Makes the approximating edge and bridge edge flags to be set.

### EvaluateVertexSurfaceData
Evaluates the vertex surface data.

### DeleteVertexSurfaceData
Deletes the vertex surface data.

### DeleteFaceIntervals
Deletes the face intervals.

### DeleteFaceIntervalsAndPlanes
Deletes intervals and planes of faces.

### DeleteMarkedFaces(System.UInt32)
Deletes all faces marked with specified flag.

- **`flag`**: Input the flag.

### DeleteMarkedSurfaces(System.UInt32)
Deletes all surfaces marked with specified flag.

- **`flag`**: Input the flag.

### DeleteMarkedCurves(System.UInt32)
Deletes all curves marked with specified flag.

- **`flag`**: Input the flag.

### DeleteMarkedVertices(System.UInt32)
Deletes all vertices marked with specified flag.

- **`flag`**: Input the flag.

### DeleteEmptyFaces
Deletes all empty faces.

### DeleteUnusedVerticesSurfacesCurves
Deletes unused vertices, surfaces and curves in the body.

### SetFaceFlags(Autodesk.Aec.Modeler.OnOff,System.UInt32)
Sets the flags of all faces in the body.

- **`tag`**: Input the tag of the faces.
- **`flag`**: Input the flag of the faces.

### SetSurfaceFlags(Autodesk.Aec.Modeler.OnOff,System.UInt32)
Sets the flags of all surfaces in the body.

- **`tag`**: Input the tag of the surfaces.
- **`flag`**: Input the flag of the surfaces.

### SetCurveFlags(Autodesk.Aec.Modeler.OnOff,System.UInt32)
Sets the flags of all curves in the body.

- **`tag`**: Input the tag of the curves.
- **`flag`**: Input the flag of the curves.

### SetEdgeFlags(Autodesk.Aec.Modeler.OnOff,System.UInt32)
Sets the flags of all edges in the body.

- **`tag`**: Input the tag of the edges.
- **`flag`**: Input the flag of the edges.

### SetVertexFlags(Autodesk.Aec.Modeler.OnOff,System.UInt32)
Sets the flags of all vertices in the body.

- **`tag`**: Input the tag of the vertices.
- **`flag`**: Input the flag of the vertices.

### MergeCoincidentVertices
Merges distinct vertices with the same coordinates.

**Returns:** Returns true if some vertices were merged or false if not.

### CleanUpNonManifoldEdgesAndCoincidentFaces
Cleans up the body that was created by operations such as extrusion and skin that simply process the data and generate a mesh.

### ChangeVertexCoordinates(Autodesk.Aec.Modeler.Vertex[],Autodesk.AutoCAD.Geometry.Point3dCollection,System.Boolean)
Changes the coordinates of the selected vertices.

- **`changedVertices`**: Input the selected vertices.
- **`changedVertexCoordinates`**: Input the coordinates.
- **`checkPlanarity`**: True if want to check planarity.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### ChangeVertexCoordinates(Autodesk.Aec.Modeler.Vertex[],Autodesk.AutoCAD.Geometry.Point3dCollection)
Changes the coordinates of the selected vertices.

- **`changedVertices`**: Input the selected vertices.
- **`changedVertexCoordinates`**: Input the coordinates.

- **Exception `T:System.ArgumentException`**: System.ArgumentException.

### ExtractShell(Autodesk.Aec.Modeler.Face)
Extracts the shell that contains the given face from the body and returns it in a new body.

- **`faceInTheShell`**: Input the face in the shell to be extracted.

**Returns:** Returns the new body with the extracted face.

### ExtractShell
Extracts the shell that contains the first face from the body and returns it in a new body.

**Returns:** Returns the new body with the extracted face.

### ExtractFace(Autodesk.Aec.Modeler.Face)
Extracts a single face from the body and returns it in a new body.

- **`faceToExtract`**: Input the face to be extracted.

**Returns:** Returns the new body with the extracted face.

### ExtractFace
Extracts the first face from the body and returns it in a new body.

**Returns:** Returns the new body with the extracted face.

### MoveFace(Autodesk.Aec.Modeler.Face,Autodesk.AutoCAD.Geometry.Vector3d,System.Boolean,System.Boolean)
Moves the given face along the given vector in the direction of the face normal.

- **`faceToMove`**: Input the face to be moved.
- **`vector`**: Input the vector in the direction of the face normal.
- **`keepAdjacentFacePlanesFixed`**: True if keeps adjacent face planes fixed.
- **`keepFaceGeometryFixed`**: True if keeps face geometry fixed.

**Returns:** Returns the moved face.

### GetAllEdgesReferencingVertex(Autodesk.Aec.Modeler.Vertex)
Get all edges referencing the vertex.

- **`value`**: The vertex.

**Returns:** The collection for all these edges.

### ProfilesOrdered(Autodesk.Aec.Modeler.Body)
Determine if the profiles are ordered.

- **`body`**: The body.

**Returns:** True if the prfiles are ordered.

### BreakEdge(Autodesk.AutoCAD.Geometry.Point3d)
Determine if the profiles are ordered.

- **`point`**: The body.

**Returns:** True if the prfiles are ordered.

### BreakEdge(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d)
Break the edge with 2 points.

- **`p1`**: The first point.
- **`p2`**: The second point.

**Returns:** The edge.

### FindVertex(Autodesk.AutoCAD.Geometry.Point3d)
Find the vertex.

- **`point`**: The point.

**Returns:** The vertex.

### FindEdge(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d)
Find the Edge vie 2 points.

- **`p1`**: The first point.
- **`p2`**: The second point.

**Returns:** The edge.

### FindFace(Autodesk.AutoCAD.Geometry.Plane)
Find faces on the certain plane.

- **`plane`**: The plane.

**Returns:** The array of faces.

### GetVertexMin(Autodesk.AutoCAD.Geometry.Vector3d)
Get the min vertex on the certain vector.

- **`dir`**: The vector.

**Returns:** The min vertex.

### GetVertexMax(Autodesk.AutoCAD.Geometry.Vector3d)
Get the max vertex on the certain vector.

- **`dir`**: The vector.

**Returns:** The max vertex.
