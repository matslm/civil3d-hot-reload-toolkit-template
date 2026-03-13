---
title: Autodesk.Aec.Modeler.Utility
hierarchy: AecBaseMgd > Autodesk > Aec > Modeler > Utility
---

# Autodesk.Aec.Modeler.Utility

## Summary
Represents some utility functions in AModeler.

## Methods

### #ctor
Initializes a new instance of the Utility class.

### ArcToBulge(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d)
Converts from bulge to arc.

- **`point1`**: The first point.
- **`point2`**: The second point.
- **`pointOnArc`**: A point on the arc.
- **`pointCenter`**: The center point.

### BulgeToCircle(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d,System.Double)
Converts from bulge to circle.

- **`point1`**: The first point.
- **`point2`**: The second point.
- **`bulge`**: The bulge.

### ModelerError(Autodesk.Aec.Modeler.ErrorCode)
Modeler Error.

- **`err`**: Error code.

### DisplayFailedBodyMsg(Autodesk.Aec.Modeler.ErrorCode,Autodesk.Aec.DatabaseServices.Operation)
Displays failed body message.

- **`err`**: Error code.
- **`operation`**: Operation.

### DisplayFailedBodyMsg(Autodesk.Aec.Modeler.ErrorCode)
Displays failed body message.

- **`err`**: Error code.

### DisplayFailedBodyMsg(System.String)
Displays failed body message.

- **`message`**: System.String.

### GetBodySlice(Autodesk.Aec.Modeler.Body,Autodesk.AutoCAD.Geometry.Plane,Autodesk.AutoCAD.Geometry.Matrix3d)
Gets body slice.

- **`body`**: Body.
- **`polyPlane`**: Poly plane.
- **`to2dPlane`**: Matrix used to conver plane to 2dPlane.

### GetBodySlice(Autodesk.Aec.Modeler.Body,System.Double,System.Boolean)
Gets body slice.

- **`body`**: Body.
- **`height`**: The height at which to slice the body, in the body's coordinate system.
- **`copyAttributes`**: Whether or not to copy attributes from the sliced faces to the profile segments.

### SliceBody(Autodesk.Aec.Modeler.Body,System.Double,System.Double)
Slices off two pieces of a body, one below bottom height and the other above top height, in the body's coordinate system.

- **`body`**: Body.
- **`bottom`**: The height below which to slice, in the body's coordinate system.
- **`top`**: The height above which to slice, in the body's coordinate system.

### GetHolesInFace(System.Collections.ArrayList@,Autodesk.Aec.Modeler.Edge)
Gets holes in face.

- **`holeEdgeArrays`**: Edge array.
- **`startEdge`**: Start edge.

**Returns:** Edge.

### NumberOfVertices(Autodesk.Aec.Modeler.Body)
Gets number of vertexs.

- **`body`**: Body.

**Returns:** Number of vertexs.

### NumberOfFaces(Autodesk.Aec.Modeler.Body)
Gets number of faces.

- **`body`**: Body.

**Returns:** Number of faces.

### NumberOfEdges(Autodesk.Aec.Modeler.Edge)
Gets number of edges.

- **`edge`**: Edge.

**Returns:** Number of edges.

### BottomLeftMostEdge(Autodesk.Aec.Modeler.Face)
Get bottom left most edge.

- **`face`**: Face.

**Returns:** Edge.

### InitFlagAndCount(Autodesk.Aec.Modeler.Body,System.Int32)
Initialize the flag and count.

- **`body`**: Body.
- **`flag`**: Flag used to initialize.

**Returns:** Count.

### InitFlagAndCount(Autodesk.Aec.Modeler.Body)
Initialize with flag = 0 and count.

- **`body`**: Body.

**Returns:** Count.

### ListBody(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.ListFlags)
Lists the information of body.

- **`body`**: Body.
- **`flags`**: List flags.

### ListBody(Autodesk.Aec.Modeler.Body)
Lists the information of body.

- **`body`**: Body.

### SetParamOnBaseCurve(Autodesk.AutoCAD.Geometry.Curve3d,System.Double,System.Boolean)
Sets parameters on basecurve.

- **`baseCurve`**: Base curve.
- **`offset`**: Offset.
- **`isFromEnd`**: True make it from end, false otherwise.

### SetParamOnBaseCurve(Autodesk.AutoCAD.Geometry.Curve3d,System.Double)
Sets parameters on basecurve.

- **`baseCurve`**: Base curve.
- **`offset`**: Offset.

### SetParamsOnBaseCurve(Autodesk.AutoCAD.Geometry.Curve3d,System.Double,System.Double)
Sets parameters on basecurve.

- **`baseCurve`**: Base curve.
- **`startOffset`**: Start offset.
- **`endOffset`**: End offset.

### GetBodyFromCutPlane(Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.Vector3d,System.Boolean)
Gets body from cut plane.

- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`profile`**: Profile.
- **`cutPlaneNormal`**: Normal of cut plane.
- **`isFromEnd`**: True make it from end, false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromCutPlane(Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.Vector3d)
Gets body from cut plane.

- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`profile`**: Profile.
- **`cutPlaneNormal`**: Normal of cut plane.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromCutPlane(Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Point3d,System.Boolean)
Gets body from cut plane.

- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`profile`**: Profile.
- **`cutPlaneNormal`**: Normal of cut plane.
- **`originalPoint`**: Original point.
- **`isFromEnd`**: True make it from end, false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromCutPlane(Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.Vector3d,Autodesk.AutoCAD.Geometry.Point3d)
Gets body from cut plane.

- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`profile`**: Profile.
- **`cutPlaneNormal`**: Normal of cut plane.
- **`originalPoint`**: Original point.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromCutPlane(Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.Vector3d,System.Double,System.Boolean)
Gets body from cut plane.

- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`profile`**: Profile.
- **`cutPlaneNormal`**: Normal of cut plane.
- **`startOffset`**: Start offset.
- **`isFromEnd`**: True make it from end, false otherwise.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromCutPlane(Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.Vector3d,System.Double)
Gets body from cut plane.

- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`profile`**: Profile.
- **`cutPlaneNormal`**: Normal of cut plane.
- **`startOffset`**: Start offset.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromCutPlanes(Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.Vector3d,System.Double,Autodesk.Aec.Geometry.Profile,Autodesk.AutoCAD.Geometry.Vector3d,System.Double)
Gets body from cut plane.

- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`startProfile`**: Start profile.
- **`startCutPlaneNormal`**: Normal of start cut plane.
- **`startOffset`**: Start offset.
- **`endProfile`**: End profile.
- **`endCutPlaneNormal`**: Normal of end cutplane.
- **`endOffset`**: End offset.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyExtrusionFromProfilesLineSeg(Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,System.Double,System.Double,System.Int32)
Gets body extrusion from profile's line segments.

- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`profile`**: Profile.
- **`profileRotation`**: Rotation of profile.
- **`deviation`**: Deviation.
- **`maxFacetsOnCircle`**: Max facets on circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyExtrusionFromProfilesLineSeg(Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,System.Double,System.Double)
Gets body extrusion from profile's line segments.

- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`profile`**: Profile.
- **`profileRotation`**: Rotation of profile.
- **`deviation`**: Deviation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyExtrusionFromProfilesLineSeg(Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,System.Double)
Gets body extrusion from profile's line segments.

- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`profile`**: Profile.
- **`profileRotation`**: Rotation of profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyExtrusionFromProfilesLineSeg(Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,System.Double,System.Int32)
Gets body extrusion from profile's line segments.

- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`profile`**: Profile.
- **`deviation`**: Deviation.
- **`maxFacetsOnCircle`**: Max facets on circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyExtrusionFromProfilesLineSeg(Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile)
Gets body extrusion from profile's line segments.

- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`profile`**: Profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromRingCurveSweep(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Ring,System.Double,Autodesk.Aec.Geometry.Ring,System.Double,Autodesk.Aec.Geometry.ProfileExtrusionDirection,System.Double,System.Int32)
Gets body from ring curve sweep.

- **`points`**: Points array.
- **`pathVertexData`**: Vertex datas of the polygon path.
- **`startProfileEcs`**: Start profile ecs.
- **`endProfileEcs`**: End profile ecs.
- **`ecs`**: Matrix ecs.
- **`startRing`**: Start ring.
- **`startRotation`**: Start rotation.
- **`endRing`**: End ring.
- **`endRotation`**: End rotation.
- **`extrusionDirection`**: Extrusion direction.
- **`deviation`**: Deviation.
- **`maxFacetsOnCircle`**: Max facets on circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromRingCurveSweep(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Ring,System.Double,Autodesk.Aec.Geometry.Ring,System.Double,Autodesk.Aec.Geometry.ProfileExtrusionDirection,System.Double)
Gets body from ring curve sweep.

- **`points`**: Points array.
- **`pathVertexData`**: Vertex datas of the polygon path.
- **`startProfileEcs`**: Start profile ecs.
- **`endProfileEcs`**: End profile ecs.
- **`ecs`**: Matrix ecs.
- **`startRing`**: Start ring.
- **`startRotation`**: Start rotation.
- **`endRing`**: End ring.
- **`endRotation`**: End rotation.
- **`extrusionDirection`**: Extrusion direction.
- **`deviation`**: Deviation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromRingCurveSweep(Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Ring,System.Double,Autodesk.Aec.Geometry.Ring,System.Double,Autodesk.Aec.Geometry.ProfileExtrusionDirection)
Gets body from ring curve sweep.

- **`points`**: Points array.
- **`pathVertexData`**: Vertex datas of the polygon path.
- **`startProfileEcs`**: Start profile ecs.
- **`endProfileEcs`**: End profile ecs.
- **`ecs`**: Matrix ecs.
- **`startRing`**: Start ring.
- **`startRotation`**: Start rotation.
- **`endRing`**: End ring.
- **`endRotation`**: End rotation.
- **`extrusionDirection`**: Extrusion direction.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfileAndTranslate(Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Ring,System.Double,Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.AutoCAD.Geometry.IntegerCollection,System.Double,System.Int32)
Gets body from profile and translate.

- **`ecsMat`**: Matrix ecs.
- **`ring`**: Ring.
- **`profileRotation`**: Profile rotation.
- **`profilePoints`**: Profile points.
- **`hints`**: Int array.
- **`deviation`**: Deviation.
- **`maxFacetsOnCircle`**: Max facets on circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfileAndTranslate(Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Ring,System.Double,Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.AutoCAD.Geometry.IntegerCollection,System.Double)
Gets body from profile and translate.

- **`ecsMat`**: Matrix ecs.
- **`ring`**: Ring.
- **`profileRotation`**: Profile rotation.
- **`profilePoints`**: Profile points.
- **`hints`**: Int array.
- **`deviation`**: Deviation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfileAndTranslate(Autodesk.AutoCAD.Geometry.Curve3d,System.Double,Autodesk.AutoCAD.Geometry.Point3d,Autodesk.Aec.Geometry.Ring,System.Double,System.Double,System.Int32)
Gets body from profile and translate.

- **`baseCurve`**: Base curve.
- **`param`**: Parameter.
- **`point`**: Point.
- **`ring`**: Ring.
- **`profileRotation`**: Rotation of profile.
- **`deviation`**: Deviation.
- **`maxFacetsOnCircle`**: Max facets on circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfileAndTranslate(Autodesk.AutoCAD.Geometry.Curve3d,System.Double,Autodesk.AutoCAD.Geometry.Point3d,Autodesk.Aec.Geometry.Ring,System.Double,System.Double)
Gets body from profile and translate.

- **`baseCurve`**: Base curve.
- **`param`**: Parameter.
- **`point`**: Point.
- **`ring`**: Ring.
- **`profileRotation`**: Rotation of profile.
- **`deviation`**: Deviation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfileAndTranslate(Autodesk.AutoCAD.Geometry.Curve3d,System.Double,Autodesk.Aec.Geometry.Ring,System.Double,System.Double,System.Int32)
Gets body from profile and translate.

- **`baseCurve`**: Base curve.
- **`param`**: Parameter.
- **`ring`**: Ring.
- **`profileRotation`**: Rotation of profile.
- **`deviation`**: Deviation.
- **`maxFacetsOnCircle`**: Max facets on circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfileAndTranslate(Autodesk.AutoCAD.Geometry.Curve3d,System.Double,Autodesk.Aec.Geometry.Ring,System.Double,System.Double)
Gets body from profile and translate.

- **`baseCurve`**: Base curve.
- **`param`**: Parameter.
- **`ring`**: Ring.
- **`profileRotation`**: Rotation of profile.
- **`deviation`**: Deviation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Point3dCollection,Autodesk.Aec.Modeler.PolygonVertexData[],Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,System.Double,Autodesk.Aec.Geometry.Profile,System.Double,Autodesk.Aec.Geometry.ProfileExtrusionDirection)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`points`**: Point array.
- **`pathVertexData`**: Vertex datas of the polygon path.
- **`startProfileEcs`**: Ecs of start profile.
- **`endProfileEcs`**: Ecs of end profile.
- **`ecs`**: Matrix ecs.
- **`startProfile`**: Start profile.
- **`startRotation`**: Rotation of start profile.
- **`endProfile`**: End profile.
- **`endRotation`**: Rotation of end profile.
- **`extrusionDirection`**: Extrusion direction.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,Autodesk.Aec.Geometry.Profile,Autodesk.Aec.Geometry.ProfileExtrusionDirection,System.Double,System.Int32)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`startProfile`**: Start profile.
- **`endProfile`**: End profile.
- **`extrusionDirection`**: Extrusion direction.
- **`deviation`**: Deviation.
- **`maxFacetsOnCircle`**: Max facets on circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,Autodesk.Aec.Geometry.Profile,Autodesk.Aec.Geometry.ProfileExtrusionDirection,System.Double)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`startProfile`**: Start profile.
- **`endProfile`**: End profile.
- **`extrusionDirection`**: Extrusion direction.
- **`deviation`**: Deviation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,Autodesk.Aec.Geometry.Profile,Autodesk.Aec.Geometry.ProfileExtrusionDirection)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`startProfile`**: Start profile.
- **`endProfile`**: End profile.
- **`extrusionDirection`**: Extrusion direction.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3dCollection,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.Profile,System.Double,Autodesk.Aec.Geometry.Profile,System.Double,System.Double,System.Int32)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`curves`**: Curve array.
- **`ecs`**: Matrix ecs.
- **`extrusionDirection`**: Extrusion direction.
- **`startProfile`**: Start profile.
- **`startRotation`**: Rotation of start profile.
- **`endProfile`**: End profile.
- **`endRotation`**: Rotation of end profile.
- **`deviation`**: Deviation.
- **`maxFacetsOnCircle`**: Max facets on circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3dCollection,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.Profile,System.Double,Autodesk.Aec.Geometry.Profile,System.Double,System.Double)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`curves`**: Curve array.
- **`ecs`**: Matrix ecs.
- **`extrusionDirection`**: Extrusion direction.
- **`startProfile`**: Start profile.
- **`startRotation`**: Rotation of start profile.
- **`endProfile`**: End profile.
- **`endRotation`**: Rotation of end profile.
- **`deviation`**: Deviation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3dCollection,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.Profile,System.Double,Autodesk.Aec.Geometry.Profile,System.Double)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`curves`**: Curve array.
- **`ecs`**: Matrix ecs.
- **`extrusionDirection`**: Extrusion direction.
- **`startProfile`**: Start profile.
- **`startRotation`**: Rotation of start profile.
- **`endProfile`**: End profile.
- **`endRotation`**: Rotation of end profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3dCollection,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.Profile,System.Double,Autodesk.Aec.Geometry.Profile)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`curves`**: Curve array.
- **`ecs`**: Matrix ecs.
- **`extrusionDirection`**: Extrusion direction.
- **`startProfile`**: Start profile.
- **`startRotation`**: Rotation of start profile.
- **`endProfile`**: End profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3dCollection,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.Profile,System.Double)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`curves`**: Curve array.
- **`ecs`**: Matrix ecs.
- **`extrusionDirection`**: Extrusion direction.
- **`startProfile`**: Start profile.
- **`startRotation`**: Rotation of start profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3dCollection,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.Profile)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`curves`**: Curve array.
- **`ecs`**: Matrix ecs.
- **`extrusionDirection`**: Extrusion direction.
- **`startProfile`**: Start profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.Profile,System.Double,Autodesk.Aec.Geometry.Profile,System.Double,System.Double,System.Int32)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`extrusionDirection`**: Extrusion direction.
- **`startProfile`**: Start profile.
- **`startRotation`**: Rotation of start profile.
- **`endProfile`**: End profile.
- **`endRotation`**: Rotation of end profile.
- **`deviation`**: Deviation.
- **`maxFacetsOnCircle`**: Max facets on circle.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.Profile,System.Double,Autodesk.Aec.Geometry.Profile,System.Double,System.Double)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`extrusionDirection`**: Extrusion direction.
- **`startProfile`**: Start profile.
- **`startRotation`**: Rotation of start profile.
- **`endProfile`**: End profile.
- **`endRotation`**: Rotation of end profile.
- **`deviation`**: Deviation.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.Profile,System.Double,Autodesk.Aec.Geometry.Profile,System.Double)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`extrusionDirection`**: Extrusion direction.
- **`startProfile`**: Start profile.
- **`startRotation`**: Rotation of start profile.
- **`endProfile`**: End profile.
- **`endRotation`**: Rotation of end profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.Profile,System.Double,Autodesk.Aec.Geometry.Profile)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`extrusionDirection`**: Extrusion direction.
- **`startProfile`**: Start profile.
- **`startRotation`**: Rotation of start profile.
- **`endProfile`**: End profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.Profile,System.Double)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`extrusionDirection`**: Extrusion direction.
- **`startProfile`**: Start profile.
- **`startRotation`**: Rotation of start profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetBodyFromProfilesCurveSweep(Autodesk.AutoCAD.DatabaseServices.Database,Autodesk.AutoCAD.Geometry.Curve3d,Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.ProfileExtrusionDirection,Autodesk.Aec.Geometry.Profile)
Gets body from profile curve sweep.

- **`db`**: Database.
- **`baseCurve`**: Base curve.
- **`ecs`**: Matrix ecs.
- **`extrusionDirection`**: Extrusion direction.
- **`startProfile`**: Start profile.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetConnectedFaces(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Face,Autodesk.Aec.Modeler.Body@)
Gets connected faces.

- **`originalBody`**: Original body.
- **`selectedFace`**: Selected face.
- **`otherFaces`**: Returns faces not connected.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetConnectedFaces(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Face)
Gets connected faces.

- **`originalBody`**: Original body.
- **`selectedFace`**: Selected face.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetDisconnectedBodies(Autodesk.Aec.Modeler.Body)
Gets disconnected bodies.

- **`originalBody`**: original body.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetPointOnFace(Autodesk.Aec.Modeler.Face,Autodesk.AutoCAD.Geometry.Point3d@)
Gets points on face.

- **`face`**: Face.
- **`point`**: Returns point.

**Returns:** True if succeed to get point on face, false otherwise.

### FaceToProfile(Autodesk.Aec.Modeler.Face,Autodesk.AutoCAD.Geometry.Matrix3d)
Convert face to profile.

- **`face`**: Face.
- **`toXY`**: Transform matrix.

**Returns:** Profile.

### CreateUnspecifiedSurface(Autodesk.Aec.Modeler.Body,System.Int32,Autodesk.AutoCAD.Geometry.Point3dCollection,System.Int32,Autodesk.AutoCAD.Geometry.IntegerCollection)
Create unspecified surface.

- **`body`**: Body.
- **`vertexCount`**: Count of vertexs.
- **`vertexList`**: Vertex list.
- **`faceListSize`**: Size of face list.
- **`faceList`**: Face list.

**Returns:** Surface.

### BodyFromObject(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Gets body from object.

- **`id`**: Object id.
- **`blockReferencePath`**: Refrence path of block.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### BodyFromObject(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Gets body from object.

- **`entity`**: Entity.
- **`blockReferencePath`**: Reference path of block.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### EntityBodiesInterfere(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Check if interference of the given entity bodies.

- **`firstObjectId`**: First object id.
- **`firstObjectBlockReferencePath`**: Reference path of the first object block.
- **`secondObjectId`**: Second object id.
- **`secondObjectBlockReferencePath`**: Reference path of the second object block.

**Returns:** True if interfere, false otherwise.

### EntityBodiesInterfere(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Check if interference of the given entity bodies.

- **`firstEntity`**: First entity.
- **`firstObjectBlockReferencePath`**: Reference path of the first object block.
- **`secondObjectId`**: Second object id.
- **`secondObjectBlockReferencePath`**: Reference path of the second object block.

**Returns:** True if interfere, false otherwise.

### EntityBodiesInterfere(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Check if interference of the given entity bodies.

- **`firstEntity`**: First entity.
- **`firstObjectBlockReferencePath`**: Reference path of the first object block.
- **`secondEntity`**: Second entity.
- **`secondObjectBlockReferencePath`**: Reference path of the second object block.

**Returns:** True if interfere, false otherwise.

### BodiesEqual(Autodesk.Aec.Modeler.Body,Autodesk.Aec.Modeler.Body)
Check if the bodies are equal.

- **`body1`**: The first body.
- **`body2`**: The second body.

**Returns:** True if equal, false otherwise.
