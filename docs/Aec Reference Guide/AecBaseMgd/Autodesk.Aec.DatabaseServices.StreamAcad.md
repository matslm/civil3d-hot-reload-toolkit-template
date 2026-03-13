---
title: Autodesk.Aec.DatabaseServices.StreamAcad
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > StreamAcad
---

# Autodesk.Aec.DatabaseServices.StreamAcad

## Summary
This is an abstract base class that all Aec streams are derived from.  Derived streams may be used for collections, filters, calculations, summations, and interfaces into other systems.  A stream contains several stacks for storing the current color, linetype, lineweight, layer, gsmarker, transformation, linetype scale, rendermode, fill type, entity, view information, etc.  All properties pushed onto the stack should have a corresponding pop after the necessary geometry has been streamed through.

## Properties

### Layer
Gets the layer at the top of the layer stack; returns layerZero if empty.

**Returns:** The object id of the layer at the top of layer stack.

### FilterOffLayers
Gets or sets the boolean value that indicates if entities on OFF layers are ignored in stream.

**Returns:** The boolean value indicates if entities on OFF layers are ignored.

### FilterFrozenLayers
Gets or sets the boolean value that indicates if entities on FROZEN layers are ignored in stream.

**Returns:** The boolean value indicates if entities on FROZEN layers are ignored.

### ResolveByBlockTraits
Gets or sets the boolean value indicates if the ByBlock properties are resolved when objects are pushed into the stream.

**Returns:** The boolean value indicates if the ByBlock properties are resolved.

### ResolveByLayerTraits
Gets or sets the boolean value indicates if the ByLayer properties are resolved when objects are pushed into the stream.

**Returns:** The boolean value indicates if the ByLayer properties are resolved.

### IndependentLayerOffControl
Gets or sets the boolean value to indicate if the indipendent layer should be off control.

**Returns:** The boolean value indicates if the indipendent layer should be off control.

### IgnoreLiveSections
Gets or sets the boolean value to indicate if the live section should be ignored.

**Returns:** The boolean value indicates if the live section should be ignored.

### ApplySurfaceHatching
Gets the boolean value to indicate if the surface hatching should be applied.

**Returns:** The boolean value indicates if the surface hatching should be applied.

### BackfaceCullSurfaceHatching
Gets the boolean value to indicate if the surface hatching on the back face should be culled.

**Returns:** The boolean value indicates if the surface hatching on the back face should be culled.

### IsPerspectiveView
Gets the boolean value indicates if the view is perspective.

**Returns:** The boolean value indicates if the view is perspective.

### AlwaysResolveByLayerPlotStyles
Gets the boolean value to indicate if the ByLayer plot styles should be always resolvsed.

**Returns:** The boolean value indicates if the ByLayer plot styles should be always resolvsed.

### ColorIndex
Gets the index of the color at the top of the color stack; returns 7 if the color stack is empty.

**Returns:** The index of the color at the top of the color stack.

### TrueColor
Gets the color at the top of the color stack.

**Returns:** The color at the top of the color stack.

### Linetype
Gets the current line type.

**Returns:** The object id of the current line type.

### FillType
Gets the filltype at the top of the filltype stack.

**Returns:** The filltype at the top of the filltype stack.

### RenderMode
Gets the render mode at the top of the render mode stack.

**Returns:** The render mode at the top of the render mode stack.

### BodyEdgeColorMode
Gets the color mode at the top of the color mode stack for the body edge.

**Returns:** The color mode at the top of the color mode stack for the body edge.

### BodyFaceColorMode
Gets the color mode at the top of the color mode stack for the body face.

**Returns:** The color mode at the top of the color mode stack for the body face.

### GsMarker
Gets the GsMarker at the top of the GsMarker stack.

**Returns:** The GsMarker at the top of the GsMarker stack.

### GsMarkersValid
Gets or sets the boolean value to indicate if GsMarkers are valid.

**Returns:** The boolean value indicates if GsMarkers are valid.

### Entity
Gets the entity at the top of the entity stack.

**Returns:** The entity at the top of the entity stack.

### CurrentEntityDrawData
Gets the drawing data of the current entity.

**Returns:** The drawing data of the current entity.

### CurrentGsMarkerInfoTree
Gets the GsMarker information tree of the stream.

**Returns:** The GsMarker information tree of the stream.

### DisplaySetId
Gets the display set used by the stream.

**Returns:** The display set object id.

**Remarks:**
This is useful, for example, if you PushDisplayParameters with a display configuration, to get the associated display set.

### DisplayDirection
Gets the current display direction.

**Returns:** The current display direction.

### MaskingRequired
Gets the boolean value to indicate if any mask profiles are on the stack. If the live section is enabled, all masking will be disabled.

**Returns:** The boolean value indicates if any mask profiles are on the stack.

### LiveSectionRequired
Gets the boolean value to indicate if any live sections are on the stack.

**Returns:** The boolean value indicates if any live sections are on the stack.

### CurrentXform
Gets the current xform matrix from the xform matrix stack.

**Returns:** The current xform matrix.

### InverseXform
Gets the inverse of the current xform matrix.

**Returns:** The inverse of the current xform matrix.

### IsXform
Gets the boolean value to indicate if the current matrix is xform.

**Returns:** The boolean value indicates if the current matrix is xform.

### IsScaled
Gets the boolean value to indicate if the current matrix is scaled.

**Returns:** The boolean value indicates if the current matrix is scaled.

### IsUniScaled
Gets the boolean value to indicate if the current matrix is unit scaled.

**Returns:** The boolean value indicates if the current matrix is unit scaled.

### Scale
Gets the scale of the current matrix.

**Returns:** The scale of the current matrix.

### LineWeight
Gets the lineweight at the top of the lineweight stack or LineWeight000, if the lineweight stack is empty.

**Returns:** The lineweight at the top of the lineweight stack or LineWeight000.

### LineTypeScale
Gets the linetype scale at the top of the linetype scale stack.

**Returns:** The linetype scale at the top of the linetype scale stack.

### Material
Gets the material at the top of the material stack.

**Returns:** The definition of the material at the top of the material stack.

### CurrentSubObjectXform
Gets the current sub-object coordinate system.

**Returns:** The current sub-object coordinate system matrix.

### InverseSubObjectXform
Gets the inverse matrix of the current sub-object coordinate system.

**Returns:** The inverse matrix of the current sub-object coordinate system.

### CurrentInsertXform
Gets the matrix at the top of the insert xform stack.

**Returns:** The matrix at the top of the insert xform stack.

### InverseInsertXform
Gets the inverse of current matrix on the xform stack.

**Returns:** The inverse of current matrix on the stack.

### SkipPushPopDisplayPropertiesFlags
Gets or sets the current flags set that indicate to skip the pushing and popping display properties.

**Returns:** The current flags set that indicate to skip the pushing and popping display properties.

### VisualStyle
Gets the visual style at the top of the visual style stack.

**Returns:** The object id of the visual style at the top of the visual style stack.

### AutoCADRenderMaterial
Gets the current AutoCAD render material at the top of the AutoCAD render material stack.

**Returns:** The object id of the AutoCAD render material at the top of the AutoCAD render material stack.

### ViewportId
Gets the current viewport.

**Returns:** The object id of current viewport.

### UseLayerPropertyOverridePerViewportIfExists
Gets or sets the boolean value to indicate if the layer property override is used in every viewport if it exists.

**Returns:** The boolean value indicates if the layer property override is used in every viewport if it exists.

### SuppressShellAndMeshExtendedData
Gets or sets the boolean value to indicate if the shell and mesh extended data are suppressed.

**Returns:** The boolean value indicates if the shell and mesh extended data are suppressed.

### AnnotationScale
Gets the current annotation scale.

**Returns:** The current annotation scale.

### AttenuateColor
Gets or sets the boolean value to indicate if the color is attenuated.

**Returns:** The boolean value indicates if the color is attenuated.

### EnablePushPopXform
Gets or sets the boolean value to indicate if push/popXform is enable.

**Returns:** The boolean value indicates if push/popXform is enable.

### UseBodyInternalDeviation
Gets or sets the boolean value to indicate if push/popXform is enable.

**Returns:** The boolean value indicates if push/popXform is enable.

## Methods

### StreamDrawable(Autodesk.AutoCAD.GraphicsInterface.Drawable)
Pushes the specified drawable object to the stream.

- **`drawable`**: The spcified drawable object.

### Stream(Autodesk.AutoCAD.DatabaseServices.Entity)
Breaks down the specified entity into its primitive components and pushes them into the stream.

- **`entity`**: The specified entity with read permission.

### Stream(Autodesk.AutoCAD.DatabaseServices.Entity,System.Boolean)
Breaks down the specified entity into its primitive components and pushes them into the stream.

- **`entity`**: The specified entity with read permission.
- **`pushEntityProperties`**: The specified boolean value indicates if the layer, color and linetype of the entity should be pushed into the stream.

### Stream(Autodesk.AutoCAD.Geometry.BoundBlock3d)
Draws an extents cube.

- **`block`**: The specified boundary block.

### StreamBlock(Autodesk.AutoCAD.DatabaseServices.BlockTableRecord)
Iterates over each object in the specified block record and pushes it into the stream.

- **`blockRecord`**: The specified block record.

### StreamBlock(Autodesk.AutoCAD.DatabaseServices.BlockTableRecord,System.Boolean)
Iterates over each object in the specified block record and pushes it into the stream.

- **`blockRecord`**: The specified block record.
- **`showAttributeDefinitions`**: The boolean value indicates if the attribute definitions are displayed.

### StreamBlock(Autodesk.AutoCAD.DatabaseServices.BlockTableRecord,Autodesk.AutoCAD.DatabaseServices.DBObjectCollection)
Iterates over each object in the specified block record and pushes it into the stream.  Each non-database-resident attribute in the specified collection is also streamed through, if it is visible.

- **`blockRecord`**: The specified block record.
- **`nonDbAttributes`**: The specified attributes collection.

### Stream(Autodesk.Aec.Modeler.Body)
Pushes the specified body into the stream.

- **`body`**: The specified body.

### Stream(Autodesk.Aec.Modeler.Body,Autodesk.Aec.DatabaseServices.StreamColorToPropertiesMap)
Pushes the specified body into the stream.

- **`body`**: The specified body.
- **`colorToPropertiesMap`**: The specified map associates an object with a color of a body edge or face.

### Stream(Autodesk.AutoCAD.Geometry.CircularArc3d)
Pushes the specified circular arc into the stream.

- **`arc`**: The specified circular arc.

### Stream(Autodesk.AutoCAD.Geometry.EllipticalArc3d)
Pushes the specified elliptical arc into the stream.

- **`arc`**: The specified elliptical arc.

### Stream(Autodesk.AutoCAD.Geometry.LineSegment3d)
Pushes the specified line into the stream.

- **`line`**: The specified line.

### Stream(Autodesk.AutoCAD.Geometry.LineSegment3d,Autodesk.AutoCAD.Geometry.DoubleCollection)
Pushes each segment between each pair of the specfied parameters in the collection into the stream if it is not empty. Otherwise, pushes the specified line into the stream.

- **`line`**: The specified line.
- **`parameters`**: The specified collection contains the parameters of the points.

### Stream(Autodesk.AutoCAD.Geometry.Point3dCollection,System.Boolean,Autodesk.Aec.DatabaseServices.StreamEntityType)
Pushes all segments composed by the specfied points in the collection into the stream.

- **`points`**: The specified collection of points.
- **`closed`**: The boolean value indicates if the segment from the last point to first one should be streamed .
- **`intendedType`**: The specified type to stream entity.

### Stream(Autodesk.AutoCAD.Geometry.Point3d[],System.Boolean,Autodesk.Aec.DatabaseServices.StreamEntityType)
Pushes all segments composed by the specfied points in the array into the stream.

- **`points`**: The specified points array.
- **`closed`**: The boolean value indicates if the segment from the last point to first one should be streamed .
- **`intendedType`**: The specified type to stream entity.

### Stream(Autodesk.AutoCAD.Geometry.Point3d[],System.Boolean,Autodesk.Aec.DatabaseServices.StreamEntityType,Autodesk.AutoCAD.Geometry.Vector3d)
Pushes all segments composed by the specfied points in the array into the stream.

- **`points`**: The specified points array.
- **`closed`**: The boolean value indicates if the segment from the last point to first one should be streamed .
- **`intendedType`**: The specified type to stream entity.
- **`normal`**: The specified normal.

### Stream(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d)
Pushes the segment between two points into the stream.

- **`begin`**: The start point.
- **`end`**: The end point.

### Stream(Autodesk.AutoCAD.Geometry.Point3d[],Autodesk.AutoCAD.Geometry.IntegerCollection)
Pushes a face with edge visibilities into the stream.

- **`pts`**: The specified points array to denote the face.
- **`visibility`**: The collection indicates the visibility of each edge.

### Stream(Autodesk.AutoCAD.Geometry.CircularArc2d)
Converts the specified arc to a 3d arc and pushes it into the stream.

- **`arc`**: The specified circular arc.

### Stream(Autodesk.AutoCAD.Geometry.EllipticalArc2d)
Converts the specified ellipse to a 3d ellipse and pushes it into the stream.

- **`arc`**: The specified elliptical arc.

### Stream(Autodesk.AutoCAD.Geometry.LineSegment2d)
Pushes the specified line into the stream.

- **`line`**: The specified line.

### Stream(Autodesk.AutoCAD.Geometry.LineSegment2d,Autodesk.AutoCAD.Geometry.DoubleCollection)
Pushes each segment between each pair of the specfied parameters in the collection into the stream if it is not empty. Otherwise, pushes the specified line into the stream.

- **`line`**: The specified line.
- **`parameters`**: The specified collection contains the parameters of the points.

### Stream(Autodesk.AutoCAD.Geometry.Point2d,Autodesk.AutoCAD.Geometry.Point2d)
Pushes the segment between two points into the stream.

- **`begin`**: The start point.
- **`end`**: The end point.

### Stream(Autodesk.AutoCAD.Geometry.Curve3d)
Pushes the specified curve into the stream.

- **`curve`**: The specified curve.

### Stream(Autodesk.AutoCAD.Geometry.Curve2d)
Converts the specified curve to a 3d curve and pushes it into the stream.

- **`curve`**: The specified curve.

### StreamByMaterialHatch(Autodesk.Aec.DatabaseServices.Geo,Autodesk.Aec.DatabaseServices.DisplayComponentHatch,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.Geometry.Profile)
Given a boundary defined by the specified profile, fills with it with the hatch described by the specified hatch properties.

- **`fromEntity`**: The specified geometry is used to get the information of the entity coordinate system.
- **`hatchProperties`**: The specified hatch properties.
- **`materialId`**: The object id of the specified material.
- **`profile`**: The specified profile.

**Returns:** void.

### StreamByMaterialHatch(Autodesk.Aec.DatabaseServices.Geo,Autodesk.Aec.Geometry.Profile,Autodesk.Aec.DatabaseServices.DisplayComponentPushPopData)
Given a boundary defined by the specified profile, fills with it with the hatch described by the specified display properties.

- **`fromEntityt`**: The specified geometry is used to get the information of the entity coordinate system.
- **`profile`**: The specified profile.
- **`data`**: The specified data of the display properties' locations.

### StreamByMaterialHatch(Autodesk.Aec.DatabaseServices.Geo,Autodesk.Aec.DatabaseServices.DisplayComponentHatch,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.Geometry.Point3d[],System.Double[])
Given a boundary defined by points and bulges, fills with it with the hatch described by the specified hatch properties.

- **`fromEntity`**: The specified geometry is used to get the information of the entity coordinate system.
- **`hatchProperties`**: The specified hatch property.
- **`materialId`**: The object id of the specified material.
- **`points`**: The points defines the boundary.
- **`bulges`**: The bulges defines the boundary.

### StreamByMaterialHatch(Autodesk.Aec.DatabaseServices.Geo,Autodesk.AutoCAD.Geometry.Point3d[],System.Double[],Autodesk.Aec.DatabaseServices.DisplayComponentPushPopData)
Given a boundary defined by the specified points and bulges, fills with it with the hatch described by the specified display properties.

- **`fromEntity`**: The specified geometry is used to get the information of the entity coordinate system.
- **`points`**: The points defines the boundary.
- **`bulges`**: The bulges defines the boundary.
- **`data`**: The specified data of the display properties' locations.

### StreamByMaterialHatch(Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.DatabaseServices.DisplayComponentHatch,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.Geometry.Point3d[],System.Double[])
Given a boundary defined by points and bulges, fills with it with the hatch described by the specified hatch properties.

- **`ecsToWcs`**: The specified matrix converts the entity coordinate system to the world coordinate system.
- **`hatchInformation`**: The specified hatch properties.
- **`materialId`**: The object id of the specified material.
- **`points`**: The points defines the boundary.
- **`bulges`**: The bulges defines the boundary.

### StreamByMaterialHatch(Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.DatabaseServices.DisplayComponentHatch,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.Geometry.Profile)
Given a boundary defined by the specified profile, fills with it with the hatch described by the specified hatch properties.

- **`ecsToWcs`**: The specified matrix converts the entity coordinate system to the world coordinate system.
- **`hatchInformation`**: The specified hatch properties.
- **`materialId`**: The object id of the specified material.
- **`profile`**: The specified profile.

### StreamByMaterialHatch(Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.Geometry.Profile,Autodesk.Aec.DatabaseServices.DisplayComponentPushPopData)
Given a boundary defined by the specified profile, fills with it with the hatch described by the specified display properties.

- **`ecsToWcs`**: The specified matrix converts the entity coordinate system to the world coordinate system.
- **`profile`**: The specified profile.
- **`data`**: The specified data of the display properties' locations.

### StreamHatch(Autodesk.Aec.DatabaseServices.Geo,Autodesk.Aec.DatabaseServices.DisplayComponentHatch,Autodesk.AutoCAD.Geometry.Point3d[],System.Double[])
Given a boundary defined by points and bulges, fills with it with the hatch described by the specified hatch properties.

- **`fromEntity`**: The specified geometry is used to get the information of the entity coordinate system.
- **`hatchInformation`**: The specified hatch properties.
- **`points`**: The specified points defines the boundary.
- **`bulges`**: The specified bulges defines the boundary.

### StreamHatch(Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.DatabaseServices.DisplayComponentHatch,Autodesk.AutoCAD.Geometry.Point3d[],System.Double[])
Given a boundary defined by points and bulges, fills with it with the hatch described by the specified hatch properties.

- **`ecsToWcs`**: The specified matrix converts the entity coordinate system to the world coordinate system.
- **`hatchInformation`**: The specified hatch properties.
- **`points`**: The specified points defines the boundary.
- **`bulges`**: The specified bulges defines the boundary.

### StreamHatch(Autodesk.Aec.DatabaseServices.Geo,Autodesk.Aec.DatabaseServices.DisplayComponentHatch,Autodesk.Aec.Geometry.Profile)
Given a boundary defined by the specified profile, fills with it with the hatch described by the specified hatch properties.

- **`fromEntity`**: The specified geometry is used to get the information of the entity coordinate system.
- **`hatchInformation`**: The specified hatch properties.
- **`profile`**: The specified profile.

### StreamHatch(Autodesk.AutoCAD.Geometry.Matrix3d,Autodesk.Aec.DatabaseServices.DisplayComponentHatch,Autodesk.Aec.Geometry.Profile)
Pushes the specified hatch from an input DisplayComponentHatch into the stream.

- **`ecsToWcs`**: The specified geometry is used to get the information of the entity coordinate system.
- **`hatchInformation`**: The specified hatch information.
- **`profile`**: The specified profile.

### StreamHatch(Autodesk.AutoCAD.DatabaseServices.Hatch)
Pushes the specified hatch from an input AutoCAD Hatch entity into the stream.

- **`hatch`**: The specified hatch.

### StreamHatch(Autodesk.AutoCAD.DatabaseServices.Hatch,System.Boolean)
Pushes the specified hatch from an input AutoCAD Hatch entity into the stream.

- **`hatch`**: The specified hatch.
- **`pushEntityProperties`**: The boolean value indicates if entity properties should be pushed.

### StreamWcs(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.Geometry.Point3d)
Pushes the line segment by two points into the stream in the world coordinate system.

- **`begin`**: The start point.
- **`end`**: The end point.

### StreamWcs(Autodesk.AutoCAD.Geometry.Point3d[],System.Boolean,Autodesk.Aec.DatabaseServices.StreamEntityType)
Pushes each segment defined by the points into the stream in the world coordinate system.

- **`points`**: The specified points.
- **`closed`**: The boolean value indicates if the segment from the last point to first one should be streamed.
- **`intendedType`**: The specified type to stream entity.

### StreamWcs(Autodesk.AutoCAD.Geometry.Point3d[],System.Boolean,Autodesk.Aec.DatabaseServices.StreamEntityType,Autodesk.AutoCAD.Geometry.Vector3d)
Pushes each segment defined by the points into the stream in the world coordinate system.

- **`points`**: The specified points.
- **`closed`**: The boolean value indicates if the segment from the last point to first one should be streamed.
- **`intendedType`**: The specified type to stream entity.
- **`normal`**: The specified normal.

### StreamWcs(Autodesk.AutoCAD.Geometry.Point3d[],Autodesk.AutoCAD.Geometry.IntegerCollection)
Pushes each edge defined by the points with visibilities into the stream in the world coordinate system.

- **`points`**: The specified points.
- **`visibility`**: The specified collection indicates the visibility of each edge.

### StreamWcs(Autodesk.AutoCAD.Geometry.CircularArc3d)
Breaks up the circluar arc into line segments and pushes them into the stream in the world coordinate system.

- **`arc`**: The specified circular arc.

### StreamWcs(Autodesk.AutoCAD.Geometry.EllipticalArc3d)
Breaks up the elliptical arc into line segments and pushes them into the stream in the world coordinate system.

- **`ellipArc`**: The specified elliptical arc.

### StreamWcs(Autodesk.Aec.Modeler.Body)
Pushes the specified body into the stream in the world coordinate system.

- **`body`**: The specified body.

### StreamWcs(Autodesk.Aec.Modeler.Body,Autodesk.Aec.DatabaseServices.StreamColorToPropertiesMap)
Pushes the specified body into the stream in the world coordinate system.

- **`body`**: The specified body.
- **`colorToPropertiesMap`**: The specified map associates an object with a color of a body edge or face.

### StreamWireframeBodyWcs(Autodesk.Aec.Modeler.Body)
Pushes visible edges of the specified body into the stream in the world coordinate system.

- **`body`**: The specified body.

### PushProperties(Autodesk.AutoCAD.DatabaseServices.Entity)
Pushes layer, color, linetype, lineweight, linetype scale, and plotstyle of the specified entity onto the respective stacks.

- **`entity`**: The specified entity.

### PushProperties(Autodesk.Aec.DatabaseServices.DisplayComponentEntity)
Pushes layer, color, line type, linew eight, line type scale and plot style of the specified display component onto the respective stacks.

- **`properties`**: The specified display component.

### PopProperties
Pops the top layer, color, line type, line type scale, line weight and plot style off the respective stacks.

### IsVisible(Autodesk.Aec.DatabaseServices.DisplayComponentEntity)
Gets the boolean value that indicates if the specified display component will be drawn using the current stream settings.

- **`properties`**: The specified display component.

**Returns:** The boolean value indicates if the specified display component will be drawn using the current stream settings.

### PushLayer(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Pushes the specified layer onto the layer stack.

- **`id`**: The object id of the specified layer.

### PopLayer
Pops the top layer off the layer stack.

### PushColor(System.Int32)
Pushes the color index onto the color stack.

- **`colorIndex`**: The specified color index.

### PushColor(Autodesk.AutoCAD.Colors.Color)
Pushes the specified color onto the color stack.

- **`trueColor`**: The specified color.

### PopColor
Pops the top color off the color stack.

### PushLinetype(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Pushes the specified line type onto the line type stack.

- **`lineTypeId`**: The object id of the specified line type.

### PopLinetype
Pops the top line type off the line type stack.

### PushFillType(Autodesk.AutoCAD.GraphicsInterface.FillType)
Pushes the specified fill type onto the fill type stack.

- **`fillType`**: The specified fill type.

### PopFillType
Pops the top fill type off the fill type stack.

### PushRenderMode(Autodesk.Aec.DatabaseServices.RenderModeType)
Pushes the specified render mode onto the render mode stack.

- **`mode`**: The specified render mode.

### PopRenderMode
Pops the top render mode off the render mode stack.

### PushBodyEdgeColorMode(Autodesk.Aec.DatabaseServices.StreamBodyColorModeType)
Pushes the specified body color mode onto the body edge color mode stack.

- **`mode`**: The specified body color mode.

### PopBodyEdgeColorMode
Pops the top body color mode off the body edge color mode stack.

### PushBodyFaceColorMode(Autodesk.Aec.DatabaseServices.StreamBodyColorModeType)
Pushes the specified body color mode onto the body face color mode stack.

- **`mode`**: The specified body color mode.

### PopBodyFaceColorMode
Pops the top body color mode off the body face color mode stack.

### PushGsMarker(System.IntPtr)
Pushes the specified GsMarker onto the GsMarker stack.

- **`id`**: The specified GsMarker.

### PopGsMarker
Pops the top GsMarker off the GsMarker stack.

### PushEntity(Autodesk.AutoCAD.DatabaseServices.DBObject)
Pushes the specified entity onto the entity stack.

- **`object`**: The specified entity.

### PopEntity
Pops the top entity off the entity stack. The entity being popped out won't be closed or deleted.

### AlreadyDrawing(Autodesk.AutoCAD.DatabaseServices.DBObject)
Gets the boolean value to indicate if the specified entity has already been drawn.

- **`obj`**: The specified object.

**Returns:** The boolean value indicates if the specified entity has already been drawn.

### PushDisplayParameters(Autodesk.Aec.DatabaseServices.DisplayConfiguration)
Pushes the specified display configuration onto the display configuration stack.  Also calculates the display set and the display direction and pushes them onto the respective stacks.

- **`displayConfigurationId`**: The specified display configuration.
- **`transaction`**: An active transaction which will be used to open the display configuration.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
- **Exception `T:System.InvalidOperationException`**: System.InvalidOperationException.

### PopDisplayParameters
Pops the top objects off the display configuration, display set and display direction stacks.

### PushDisplayDirection(Autodesk.AutoCAD.Geometry.Vector3d)
Push the specified display direction onto the display direction stack.

- **`displayDirection`**: The specified display direction.

### PopDisplayDirection
Pops the top display direction off the display direction stack.

### PushXform(Autodesk.AutoCAD.Geometry.Matrix3d)
Pushes the specified matrix onto the xform matrix stack.

- **`matrix`**: The specified matrix.

### PopXform
Pops the top matrix off the xform stack.

### PushLineWeight(Autodesk.AutoCAD.DatabaseServices.LineWeight)
Pushes the specified line weight onto the line weight stack.

- **`lineWeight`**: The specified line weight.

### PopLineWeight
Pops the top line weight off the line weight stack.

### PushLineTypeScale(System.Double)
Pushes the specified line type scale onto the linetype scale stack.

- **`thickness`**: The specified thickness indicates the linetype scale.

### PopLineTypeScale
Pops the top line type scale off the line type scale stack.

### PushPlotStyle(Autodesk.AutoCAD.DatabaseServices.PlotStyleNameType,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Pushes the specified plot style name type and object id onto the plot style stack.

- **`type`**: The specified plot style name type.
- **`id`**: The object id of the specified plot style.

### PopPlotStyle
Pops the top plot style off the plot style stack.

### GetPlotStyleNameType
Gets the current plot style name type.

**Returns:** The current plot style name type.

### GetPlotStyleId
Gets the object id of the plot style at the top of the plot style stack.

**Returns:** The object id of the plot style at the top of the plot style stack.

### PushMaterial(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Pushes the specified material onto the material stack. The material stack is a stack of material definition but not material id.  So the material id pushed in will be opened for read.  Make sure you pop out the material using PopMaterial in the right sequence and with parameter closeIt set to "true" to ensure the material is not left open.  Or you can close the opened material yourself using the returned material definition and pop the stack without closing the top material.

- **`materialId`**: The object id of the specified material.

**Returns:** The material definition specified by the object id.

### PushMaterial(Autodesk.Aec.DatabaseServices.MaterialDefinition)
Pushes the specified material definition onto the material stack.

- **`materialDefinition`**: The specified material definition.

### PopMaterial(System.Boolean)
Pops the top material off the material stack. Set closeIt to "true" if the top material is pushed in as a material id.

- **`closeIt`**: The boolean value indicates if the material should be closed.

### PushSubObjectCoordinateSystem(Autodesk.AutoCAD.Geometry.Matrix3d)
Pushes the sub-object coordinate system onto the sub-object coordinate system stack.

- **`matrix`**: The specified coordinate system.

### PopSubObjectCoordinateSystem
Pops the the top coordinate system matrix off the sub-object coordinate system stack.

### PushInsertXform(Autodesk.AutoCAD.Geometry.Matrix3d)
Pushes the specified matrix onto the insert xform stack.

- **`matrix`**: The specified matrix.

### PopInsertXform
Pops the top matrix off the insert xform stack.

### SetSkipPushPopDisplayProperties(System.Boolean)
Sets the boolean value to indicate if pushing and popping display properties should be skipped.

- **`skip`**: The boolean value indicates if pushing and popping display properties should be skipped.

### AddToSkipPushPopDisplayPropertiesFlags(System.Int32)
Adds the specified flag to the flag set that indicates what type of display propertie(s) will be skipped for pushing and popping.

- **`newDisplayPropertiesToSkipFlagsToAdd`**: The specified flag to be added. This value can be combination of values in the SkipPushPopDisplayPropertiesType enumeration.

### RemoveFromSkipPushPopDisplayPropertiesFlags(System.Int32)
Removes the specified flag from the flag set that indicates what type of display propertie(s) will be skipped for pushing and popping.

- **`newDisplayPropertiesToSkipFlagsToRemove`**: The specified flag to be removed. This value can be combination of values in the SkipPushPopDisplayPropertiesType enumeration.

### PushVisualStyle(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Pushes the specified visual style onto the visual style stack.

- **`id`**: The object id of the specifed visual style.

### PopVisualStyle
Pops the top visual style off the visual style stack.

### PushAutoCADRenderMaterial(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Pushes the specified AutoCAD render material onto the AutoCAD render material stack.

- **`id`**: The object id of the specified render material.

### PopAutoCADRenderMaterial
Pops the top AutoCAD render material off the AutoCAD render material stack.
