---
title: Autodesk.Aec.DatabaseServices.StreamCollectBodies
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > StreamCollectBodies
---

# Autodesk.Aec.DatabaseServices.StreamCollectBodies

## Summary
Represents a stream that collects the bodies that are produced during a sequence of draw routines.

## Methods

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database)
Initializes a new instance of the StreamCollectBodies class using the specified database.

- **`db`**: The specified database.

### GetBody
Gets the current body. The oringal body data in the stream is transfered to the returned body.  This function is much faster than GetBodyCopy.

**Returns:** The current body.

### GetBodyCopy
Gets a copy of the current body.

**Returns:** The copy of the current body.

### InitializeBody
Initializes the current body.
