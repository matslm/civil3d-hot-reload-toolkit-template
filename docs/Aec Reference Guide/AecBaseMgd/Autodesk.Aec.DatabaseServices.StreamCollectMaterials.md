---
title: Autodesk.Aec.DatabaseServices.StreamCollectMaterials
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > StreamCollectMaterials
---

# Autodesk.Aec.DatabaseServices.StreamCollectMaterials

## Summary
Represents a stream that collects materials and bodies from the entities pushed in.  This stream compares the materials of the bodies with the materials in the MaterialFilter collection.  Both of the materials and the bodies are added to the result collections.  This stream can also scan for a face on a specified point by calling SetupFaceScan prior to the streaming process.  You can get the results of the face scanning by calling GetFaceScanResults.  If you want to find the nearest material to a point, call SetupLineworkScan prior to the streaming process and get the result by calling GetLineworkScanResult.  The stream cannot perform face scanning and linework scanning at the same time.  It only performs linework scan if both SetupFaceScan and SetupLineworkScan are called.  You can access the collected materials using MaterialIds property.  The collected bodies are grouped by their materials, so you can access the bodies by calling GetBody and specifying the material id.  If you want the bodies with the same material to be combined to one body instead of a connected body chain, set CombineBodies to true.

## Properties

### CombineBodies
Gets or sets if the collected bodies with the same material should be combined to one body instead of forming up a body chain.

**Returns:** True if the bodies should be combined.

### MaterialFilter
Gets the object id collection of the material filters. The bodies, which are specified with any material in the material filter collection, are collected.

- **`filter`**: Object id collection of material filters.

### MaterialIds
Gets the object id collection of collected materials.

**Returns:** The object id collection of collected materials.

## Methods

### #ctor(Autodesk.AutoCAD.DatabaseServices.Database)
Initializes a new instance of the StreamCollectMaterials class using the specified database.

- **`db`**: The database.

### SetupFaceScan(Autodesk.AutoCAD.Geometry.Point3d)
Enables the stream to scan for a face on the specified search point.  This stream only performs linework scan when both SetupLineworkScan and SetupFaceScan get called.

- **`point`**: The search point.

### GetFaceScanResults
Gets the results of the face scan. This function throws an exception if there is no face found on the search point.  Call SetupFaceScan prior to pushing all the entities into the stream.  And after the streaming process, call this function to get the results.

**Returns:** The face scan results. Only the MaterialId, PickedFace and FaceCoordinateSystem properties are valid in the returned FaceScanResults object.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### SetupLineworkScan(Autodesk.AutoCAD.Geometry.Point3d)
Enables the stream to scan for the nearest material from the specifed search point.  This stream only performs linework scan when both SetupLineworkScan and SetupFaceScan get called.

- **`point`**: The specified search point.

### GetLineworkScanResult
Gets the nearest material that was streamed through. Call SetupLineworkScan prior to pushing all the entities into the stream.  And after all the streaming process, call this function to get the result.  This function throws an exception if nothing can be found or the SetupLineworkScan is not called before calling this.

**Returns:** The object id of the material.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### ResetBodies
Resets all the bodies and materials in the stream. All the collected bodies are erased by calling this.  Call this function before you start another streaming process. This function does not affect the settings set by SetupFaceScan and SetupLineworkScan.

### GetBody(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the body with the specified material. The bodies with the same material are combined to one body if CombineBodies is set to true.  Otherwise, the returned body is the first body of the body chain and you may traverse all the bodies using Body.Next property recursively.  This function throws an exception if no body of the specified material can be found.

- **`materialId`**: The id of the specified material.

**Returns:** The body.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetVolume(Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the total volume of collected bodies with the same material.

- **`material`**: The id of the specified material.

**Returns:** The total volume.

### GetFaceOnPoint(Autodesk.AutoCAD.Geometry.Point3d)
Gets the face on the specified search point. GetFaceOnPoint searches within the collected bodies for a face on the specified search point.  This function throws an exception if no face on the point can be found.

- **`wcsPickPoint`**: The search point in world coordinate system.

**Returns:** The search result. The face and its material are returned using the FaceScanResults class.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### GetFaceOnPoint(Autodesk.AutoCAD.Geometry.Point3d,Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.Aec.DatabaseServices.SurfaceHatchFlags)
Gets the face on the specifed search point. This function searches within the collected bodies for the face matching the specified search conditions.  This function throws an exception if no face can be found.

- **`wcsPickPoint`**: The search point in world coordinate system.
- **`materialId`**: The id of the specified material.
- **`flags`**: The specified flags.

**Returns:** The face and its material are returned using the FaceScanResults class. The ExactHit of the return value is set to true if the returned face matches the specified flags.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.
