---
title: "Support Files (CodesSpecific.vb, Utilities.vb)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-A3F3DD7B-5C9D-4D62-A632-4CF8E868D233.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Creating Custom Subassemblies Using .NET", "Structure of Subassembly Programs", "Support Files (CodesSpecific.vb, Utilities.vb)"]
---

# Support Files (CodesSpecific.vb, Utilities.vb)

You can also use the two support files *CodesSpecific.vb* and *Utilities.vb* in your subassembly.

*CodesSpecific.vb* provides the `CodeType` and `AllCodes` structures and the global variable `Code -` an instance of an `AllCodes` structure with all code information filled.

*Utilities.vb* provides a series of shared helper functions for error handling, computing subassembly geometry, attaching code strings, and other tasks. For example, to report a “parameter not found” error to the Autodesk Civil 3D event viewer, use the following line:

```
Utilities.RecordError( _
   corridorState, _
   CorridorError.ParameterNotFound, _
   "Edge Offset", _
   "BasicLaneTransition")
```

The following table lists all the functions within the `Utility` class:

| Utility function | Description |
| --- | --- |
| RecordError | Sends an error message to the Event Viewer. |
| RecordWarning | Sends a warning to the Event Viewer. |
| AdjustOffset | For a given offset from an offset baseline, this function computes the actual offset from the base baseline. |
| GetVersion | Returns the version number of the subassembly as specified in the .***atc*** file. |
| GetAlignmentAndOrigin | Returns the assembly and the origin point for the subassembly. |
| CalcElevationOnSurface | Given a surface Id, alignment Id, a station, and an offset from the station, this returns the elevation of the surface at that location. |
| GetRoundingCurve | Returns an array of points along a curve where it will be tessellated, given a series of parameters describing the curve and how it is to be tessellated. |
| CalcAlignmentOffsetToThisAlignment | Calculates the offset from this alignment to an offset target, and returns the XY coordinate of the offset target at the point perpendicular to this alignment's station |
| AddCodeToLink | Adds a series of code strings to a particular link. The parameter **i** identifies which set of code strings to use. The parameter **iLinks** contains the collection of all links in an applied subassembly. The parameter **linkIndex** identifies which link in the link collection is given the code strings. The **strArrCode** parameter is a two-dimensional array of code strings. The first dimension identifies which set of codes to use, and the second dimension contains a variable-length array of code strings. |
| AddCodeToPoint | Adds a series of code strings to a particular point. The parameter **i** identifies which set of code strings to use. The parameter **iPoints** contains the collection of all points in an applied subassembly. The parameter **pointIndex** identifies which point in the point collection is given the code strings. The **strArrCode** parameter is a two-dimensional array of code strings. The first dimension identifies which set of codes to use, and the second dimension contains a variable-length array of code strings. |
| IsProjectUnitsFeet | Returns `True` if the corridor is modeled in Imperial units, `False` if modeled in metric. |
| GetProjectUnitsDivisor | Returns the value to go from the general units of measurement to smaller units of measurement. If the corridor is modeled in feet, this will return 12 to allow you to compute the number of inches. If the corridor is modeled in meters, this will return 1000 to allow you to compute the number of millimeters. |
| GetSlope | Returns the percent slope of the alignment superelevation at the specified assembly section. The first parameter is a two-letter string indicates the part of the roadway to use. The first letter can be “S” for shoulder or “L” for lane. The second letter can be “I” for inside or “O” for outside. To determine the slope of the left side of the road, set the fourth parameter to `True`. To determine the slope of the right side, set the fourth parameter to `False`. |
| AddPoints | Given arrays of X and Y locations and code strings, this creates an array of `Point` objects (`AeccRoadwayPoint` objects) and a `PointsCollection` object (`AeccRoadwayPoints` object). |
| GetMarkedPoint | Given the string name of a point, returns the point object. |

The *CodesSpecific.vb* and *Utilities.vb* files are located in the *<Autodesk Civil 3D Install Directory>\Sample\Civil 3D API\C3DStockSubAssemblies* directory.

**Parent topic:** [Structure of Subassembly Programs](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-9129C83C-2FE0-486D-A399-47E443870AF0.htm)