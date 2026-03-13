---
title: Autodesk.Aec.DatabaseServices.ConnectionComponent
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > ConnectionComponent
---

# Autodesk.Aec.DatabaseServices.ConnectionComponent

## Summary
Represents a connection component.

## Properties

### MaxSimultaneousConnections
Gets the maximum number of simultaneous connections.

**Returns:** The maximum number of simultaneous connections. If there is no limit, returns 0.

### BoundBox
Gets the bounding box for this connection component.

**Returns:** The bounding box for this connection component.

## Methods

### ConnectsWith(Autodesk.Aec.DatabaseServices.ConnectionComponent)
Determines whether this ConnectionComponent connects with the input ConnectionComponent.

- **`component`**: Input the connection component.

**Returns:** true if this ConnectionComponent connects with the input ConnectionComponent, or false otherwise.
