---
title: Autodesk.Aec.DatabaseServices.ConstraintUtility
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ConstraintUtility
---

# Autodesk.Aec.DatabaseServices.ConstraintUtility

## Summary
Represents a utility group of constraint.

## Properties

### IsActionEvaluationInProgress
Is action evaluation in progress.

**Returns:** Determine whether action evaluation is in progress.

### IsConstraintEvaluationRelaxed
Checks wether the constraint already relaxed.

**Returns:** Specify wether the constraint already relaxed.

### HideInternalConstraint
Gets or sets the flag of constrolling display of internal constraint bar (the small constrol bar icon in AutoCAD)

### IsDragging
Checks whether currently is dragging.

**Returns:** Specify whether currently is dragging.

### DraggingState
Gets dragging state.

**Returns:** The dragging state.

## Methods

### #ctor
Initializes a new instance of the ConstraintUtility class.

### GetAssocPersSubentityIdPE(Autodesk.AutoCAD.Runtime.RXObject)
Gets AssocPersSubentityIdPE from object.

- **`object`**: The given object.

**Returns:** The output AssocPersSubentityIdPE.

### GetCurrentSpaceNetwork(System.Boolean)
Gets associate network for current model space.

- **`createIfNotExist`**: Determine whether create if it is not existing.

**Returns:** The object Id.

### GetSpaceModelConstraintGroup(Autodesk.AutoCAD.DatabaseServices.Database,System.Boolean,Autodesk.AutoCAD.Geometry.Plane)
Gets 2d constraint group.

- **`database`**: The input database.
- **`createIfDoesNotExist`**: Determine whether create if it is not existing.
- **`plane`**: The plane.

**Returns:** The 2d constraint group id.

### GetEdgeVertexSubentType(Autodesk.AutoCAD.DatabaseServices.SubentityId)
Gets edge vertex subentity's vertex type.

- **`vertexSubentityId`**: The vertex Subentity Id.

**Returns:** The vertext type.

### CreateEdgeVertexSubentId(Autodesk.AutoCAD.DatabaseServices.SubentityId,Autodesk.Aec.DatabaseServices.ConstraintUtility+EdgeVertexType)
Gets edge vertex subentity from edge subentity.

- **`edgeSubentityId`**: The edge subEntityId.
- **`vertexType`**: The vertex type.

**Returns:** The subEntityId.

### CreateAllEdgeVerticesSubentIds(Autodesk.AutoCAD.DatabaseServices.Entity)
Creates all edge vertices of an input entity.

- **`entity`**: The entity.

**Returns:** The subEntityId.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetEdgeSubentIdFromEdgeVertexSubentId(Autodesk.AutoCAD.DatabaseServices.SubentityId)
Gets edge subentity from vertex subentity (vertex subentity is created based on edge subentity).

- **`vertexSubentity`**: The vertex subentity Id.

**Returns:** The edge subentity Id.

### GetEdgeBasedSubentity(Autodesk.AutoCAD.DatabaseServices.SubentityId)
Gets edge subentity from vertex subentity, or just the edge subentity if input is an edge subentity.

- **`subEntityId`**: The vertex subentity.

**Returns:** The edge subentity.

### GetEdgeBasedFullSubentityPath(Autodesk.AutoCAD.DatabaseServices.FullSubentityPath)
Gets an edge subentity path from a input vertex subentity path.

- **`path`**: The input vertex subentity path.

**Returns:** The edge subentity path.

### GetEdgeVertexSubentities(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId,Autodesk.AutoCAD.DatabaseServices.SubentityId&,Autodesk.AutoCAD.DatabaseServices.SubentityId&)
Gets vertex subentity for given edge subentity.

- **`entity`**: The input entity.
- **`edgeSubentityId`**: The input edge subentity.
- **`startVertexSubentityId`**: The output start vertext subentity id.
- **`endVertexSubentityId`**: The output end vertext subentity id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetEdgeVertexSubentities(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId,Autodesk.AutoCAD.DatabaseServices.SubentityId&,Autodesk.AutoCAD.DatabaseServices.SubentityId&,Autodesk.AutoCAD.DatabaseServices.SubentityId&)
Gets vertex subentity for given edge subentity.

- **`entity`**: The input entity.
- **`edgeSubentityId`**: The input edge subentity.
- **`startVertexSubentityId`**: The output start vertext subentity id.
- **`endVertexSubentityId`**: The output end vertext subentity id.
- **`middleSubentityId`**: The output middle vertext subentity id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetEdgeVertexSubentities(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId,Autodesk.AutoCAD.DatabaseServices.SubentityId&,Autodesk.AutoCAD.DatabaseServices.SubentityId&,Autodesk.AutoCAD.DatabaseServices.SubentityId&,Autodesk.AutoCAD.DatabaseServices.SubentityId&)
Gets vertex subentity for given edge subentity.

- **`entity`**: The input entity.
- **`edgeSubentityId`**: The input edge subentity.
- **`startVertexSubentityId`**: The output start vertext subentity id.
- **`endVertexSubentityId`**: The output end vertext subentity id.
- **`middleSubentityId`**: The output middle vertext subentity id.
- **`centerSubentityId`**: The output center vertext subentity id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAllSubEntitiesInEntity(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Get subenttities, the vertex subentities will not be returned if any edge subentity found.

- **`entityId`**: The input entity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IsEntityHasEdgeSubent(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Check whether an entity has edge subentity or not.

- **`entityId`**: The input entity.

**Returns:** Specify whether an entity has edge subentity.

### AddGeomConstraintToSubents(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId,Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint+ConstraintType,System.Boolean)
Adds geometrical constraint to one subentity, for example fix/vertical/horizontal.

- **`entity`**: The input entity.
- **`subEntityId`**: The subentity.
- **`constraintType`**: The geometrical constraint type.
- **`setToImplied`**: Determine whether set to implied.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddGeomConstraintToSubents(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId,Autodesk.AutoCAD.DatabaseServices.SubentityId,Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint+ConstraintType,System.Boolean)
Adds geometrical constraint between two subentities.

- **`entity`**: The input entity.
- **`subEntityId1`**: The first subentity.
- **`subEntityId2`**: The second subentity.
- **`constraintType`**: The geometrical constraint type.
- **`setToImplied`**: Determine whether set to implied.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddDistanceConstraint(Autodesk.AutoCAD.DatabaseServices.FullSubentityPath,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds distance constraint on one subentity.

- **`subentity`**: The subentity.
- **`valueDependencyId`**: The value dependency id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddDistanceConstraint(Autodesk.AutoCAD.DatabaseServices.FullSubentityPath,Autodesk.AutoCAD.DatabaseServices.FullSubentityPath,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds distance constraint between two subentities.

- **`subentity1`**: The first subentity.
- **`subentity2`**: The second subentity.
- **`valueDependencyId`**: The value dependency id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddDistanceConstraint(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds distance constraint on one subentity.

- **`entity`**: The input entity.
- **`subEntityId`**: The subentity id.
- **`valueDependencyId`**: The value dependency id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddDistanceConstraint(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId,Autodesk.AutoCAD.DatabaseServices.SubentityId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Adds distance constraint between two subentities.

- **`entity`**: The input entity.
- **`subEntityId1`**: The first subentity id.
- **`subEntityId2`**: The second subentity id.
- **`valueDependencyId`**: The value dependency id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Get2dConstraintsOnObject(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint[]&,System.Boolean)
Gets 2d constraints on object.

- **`entityId`**: The input entity.
- **`constraints`**: The output contraints.
- **`includeExplicitConstraints`**: Determine whether include explicit constraints.

**Returns:** Specify whether successfully get 2d constraints.

### Get2dConstraintsOnObject(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint[]&)
Gets 2d constraints on object.

- **`entityId`**: The input entity.
- **`constraints`**: The output contraints.

**Returns:** Specify whether successfully get 2d constraints.

### Get2dConstraintsOnSubent(System.ValueType,Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint[]&,System.Boolean)
Gets 2d constraints on subentity.

- **`subentityPath`**: The input subentity path.
- **`constraints`**: The output contraints.
- **`includeExplicitConstraints`**: Determine whether include explicit constraints.

**Returns:** Specify whether successfully get 2d constraints.

### Get2dConstraintsOnConstrainedGeometry(Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry,Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint[]&,System.Boolean)
Gets Constraints On constraint geometry.  Note that if the input constraintGeometry is an implicit point( NAMESPACE_ACDB::ConstrainedImplicitPoint ), then this function will not return any constraint, so please use Get2dConstraintsOnImplicitPoints() for NAMESPACE_ACDB::ConstrainedImplicitPoint.

- **`constraintGeometry`**: The input constraint geometry.
- **`constraints`**: The output constraints.
- **`includeExplicitConstraints`**: Determine whether include explicit constraints.

**Returns:** Specify whether successfully get 2d constraints.

### Get2dConstraintsOnImplicitPoint(Autodesk.AutoCAD.DatabaseServices.ConstrainedImplicitPoint,Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint[]&,System.Boolean)
Gets constraints on implicit point.

- **`implicitPoint`**: The input implicit point.
- **`constraints`**: The output constraints.
- **`includeExplicitConstraints`**: Determine whether include explicit constraints.

**Returns:** Specify whether successfully get 2d constraints.

### Get2dConstraintsOnImplicitPoints(Autodesk.AutoCAD.DatabaseServices.ConstrainedImplicitPoint[],Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint[]&,System.Boolean)
Gets constraints on implicit points.

- **`points`**: The input implicit points.
- **`constraints`**: The output constraints.
- **`includeExplicitConstraints`**: Determine whether include explicit constraints.

**Returns:** Specify whether successfully get 2d constraints.

### ObjectHasConstraint(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Checks whether an object has constraint or not.

- **`entityId`**: The input entity id.

**Returns:** Specify whether an object has constraint or not.

### ObjectHasFixConstraint(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Checks whether an object has fix constraint or not.

- **`entityId`**: The input entity id.

**Returns:** Specify whether an object has fix constraint or not.

### SubentityHasConstraint(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId)
Checks if a subentity has constraint or not.

- **`entity`**: The input entity.
- **`subEntityId`**: The input subentity id.

**Returns:** Specify whether a subentity has constraint or not.

### DeleteConstraint(Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint)
Removes Constraint.

- **`constraint`**: The input constraint.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### RemoveGeometryConstraintsOnObjects(Autodesk.AutoCAD.DatabaseServices.DBObject)
Remove all geom constraint on an object.

- **`object`**: The given object.

### GetConstraintedGeometryOnSubent(System.ValueType)
Gets constrained geometry (node) from subentity path.

- **`subentityPath`**: The given subentity path.

**Returns:** The constrained geometry.

### GetAllConstraintedGeometryOnEntity(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry[]&)
Gets all constrained geometries from object.

- **`entity`**: The given entity.
- **`geometries`**: The output constrained geometries.

**Returns:** Specify whether successfully get all constrainted geometries.

### AddConstraintGeometry(Autodesk.AutoCAD.DatabaseServices.FullSubentityPath)
Adds constraint geometry node into the 2d constraint group based on the input subentity path.

- **`subentityPath`**: The input subentity path.

**Returns:** The constraint geometry.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetGeometryDependencyIdsOnEntity(Autodesk.AutoCAD.DatabaseServices.Entity)
Gets geometry dependencies in an entity.

- **`entity`**: The given entity.

**Returns:** The geometry dependence ids.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetSubentGeomDependency(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId)
Gets geometry dependence id for given subentity in an entity.

- **`entity`**: The given entity.
- **`subEntityId`**: The given subentity id.

**Returns:** The geometry dependence id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ObjectHasGeomDependency(Autodesk.AutoCAD.DatabaseServices.Entity)
Checks whether an object has constraint geometry or not.  this is an quicker way to check if an object has constraint or not than the function of ObjectHasConstraint.

- **`entity`**: The given entity.

**Returns:** Specify whether an object has constraint geometry or not.

### ObjectHasGeomDependency(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Checks whether an object has constraint geometry or not this is an quicker way to check if an object has constraint or not than the function of ObjectHasConstraint.

- **`id`**: The given object id.

**Returns:** Specify whether an object has constraint geometry or not.

### SubentHasGeomDependency(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId)
Checks whether subentity has geomDependency.

- **`entity`**: The given entity.
- **`subEntityId`**: The given subentity id.

**Returns:** Specify whether subentity has geomDependency.

### DeleteGeometryNodeInConstraintGroup(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Deletes geometry dependency in constraint group.

- **`geometryDependencyId`**: The given geometry dependency id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DeleteGeometryNodeInConstraintGroup(Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Deletes geometry dependency in constraint group.

- **`ids`**: The given constraint group.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DeleteGeometryNodeInConstraintGroup(Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry[])
Deletes geometry dependency in constraint group.

- **`constrainedGeometries`**: The given constrained geometries.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DeleteGeometryNodeInConstraintGroup(Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry)
Deletes geometry dependency in constraint group.

- **`constrainedGeometry`**: The given constrained geometry.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### DeleteGeometryDependencyOnSubentity(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId)
Deletes geometry dependency in constraint group.

- **`entity`**: The given entity.
- **`subEntityId`**: The given subentity id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetValueDependencyByName(Autodesk.AutoCAD.DatabaseServices.Entity,System.String)
Gets value dependency id by value name.

- **`entity`**: The given entity.
- **`valueName`**: The value name.

**Returns:** The value dependency id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAcDbAssocValueDependencyIds(Autodesk.AutoCAD.DatabaseServices.Entity)
Gets value dependencies.

- **`entity`**: The given entity.

**Returns:** The value dependencies.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetAllImplicitPointsOnObject(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ConstrainedImplicitPoint[]&)
Gets all implicit points from object.

- **`entity`**: The given entity.
- **`implicitPoints`**: The output implicit points.

**Returns:** Specify whether successfully get all implicit points.

### GetAllStartEndImplicitPointsOnObject(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ConstrainedImplicitPoint[]&)
Gets all start/end implicit points on db curve.

- **`entity`**: The given entity.
- **`implicitPoints`**: The output implicit points.

**Returns:** Specify whether successfully get all implicit points.

### GetVertexSubentityFullPathOfImplicitPoint(Autodesk.AutoCAD.DatabaseServices.ConstrainedImplicitPoint)
Gets vertext subentity full path of implicit point.

- **`implicitPoint`**: The given implicit point.

**Returns:** The output vertext subentity path.

### RelaxConstraintEvaluation
Relax constraint evaluation ( modify action to fulfill the object modifications )

### RestoreConstraintEvaluation
Restore constraint evaluation.

### ProjectToXYPlanCurve(Autodesk.AutoCAD.Geometry.Curve3d)
Projects curve3d to XY plane (Z = 0), and return the value after projected.

- **`curve3d`**: The curve.

**Returns:** The value after projected to XY plane.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AddInternalConstraint(Autodesk.Aec.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId)
Adds internal constraint on subentity.

- **`entity`**: The given entity.
- **`subEntityId`**: The given subentity id.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### OnAcDbAssocGeometryDependencyAppended(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Updates internal constraints while geometry dependency attached.

- **`dependencyObjectId`**: The dependency object id.

### GetClosestEdgeSubentity(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.DatabaseServices.SubentityType)
Gets closest edge subentity.

- **`entity`**: The given entity.
- **`fullPathObjectIds`**: The give full path object ids.
- **`inputPoint`**: The input point.
- **`subentityType`**: The subentity type.

**Returns:** The closest edge subentity.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetClosetVertexSubentityId(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection,Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.DatabaseServices.SubentityId,Autodesk.AutoCAD.DatabaseServices.SubentityId&)
Gets closet vertex subEntityId.

- **`entity`**: The given entity.
- **`objectIds`**: The given object ids.
- **`pickPoint`**: The given pick point.
- **`edgeSubentityId`**: The given edge subentity id.
- **`closestVertexSubentityId`**: The output closest vertext subentity id.

**Returns:** Determine whether successfully get closet vertex subentity id.

### GetSubentGeometryXform(Autodesk.AutoCAD.DatabaseServices.ObjectIdCollection)
Gets subentity geometry X form.

- **`objectIds`**: The given object ids.

**Returns:** The subentity geometry X form.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### IsValidSubentity(Autodesk.AutoCAD.DatabaseServices.Entity,Autodesk.AutoCAD.DatabaseServices.SubentityId)
Checks a subentity is valid or not.

- **`entity`**: The given entity.
- **`subEntityId`**: The given subentity id.

**Returns:** Specify a subentity is valid or not.

### RecordForDelayRegen(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Some objects' update while evaluating constraint may break constraint system, so invent this function (and function DelayRegenCachedObjects) to delay regen these objects in command-end.

- **`id`**: The given object id.

### RecordForDelayRegen2ndRound(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Records object for 2nd round of delay regen.

- **`id`**: The given object id.

### RemoveEntityRedundantInternalConstraints(Autodesk.Aec.DatabaseServices.Entity)
Remove entity redundant internal constraints.

- **`entity`**: The given entity.

### IsSubentityFixed(Autodesk.AutoCAD.DatabaseServices.FullSubentityPath)
Checks whether the subentity is fixed.

- **`path`**: The given subentity path.

**Returns:** Specify whether the subentity is fixed.

### AddFixConstraintOnSubent(Autodesk.AutoCAD.DatabaseServices.FullSubentityPath,Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry[]&)
Adds fix constraint on subentity.

- **`path`**: The given full subentity path.
- **`newlyAddedConstraintGeometry`**: The output newly added constraint geometries.

**Returns:** The newly added fix constraints.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AutoCoincidentConstraint(Autodesk.AutoCAD.DatabaseServices.FullSubentityPath[],Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry[]&)
Automatically adds coincident constraint to given subentities.

- **`fullSubentityPaths`**: The full sub-entity path.
- **`newlyAddedGeometries`**: The output newly added geometries.

**Returns:** The geometrical constraints.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetDelayUpdateSpaceEnabledForCurDwg(System.Boolean)
Set the flag of "delayConstraintUpdateEnabled"

- **`value`**: Specify the flag of "delayConstraintUpdateEnabled".

### IsAecDbEntityConstrBarVisible(Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint)
Gets constraint bar visibility.

- **`geometricalConstraint`**: The given geometrical constraint.

**Returns:** Specify the constraint bar visbility.
