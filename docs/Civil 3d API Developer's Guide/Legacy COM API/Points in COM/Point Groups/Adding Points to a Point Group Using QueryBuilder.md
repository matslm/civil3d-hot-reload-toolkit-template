---
title: "Adding Points to a Point Group Using QueryBuilder"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-42398447-CE0A-4B9B-AD7E-8D3619FDBD6A.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Points in COM", "Point Groups", "Adding Points to a Point Group Using QueryBuilder"]
---

# Adding Points to a Point Group Using QueryBuilder

Points can be placed into a point group by using the QueryBuilder, which is a mechanism for selecting from among all the points in the document. The `AeccPointGroup.QueryBuilder` property is an object of type `AeccPointGroupQueryBuilder`, and contains many different properties that allow including or excluding points based on a specific criteria. These properties are:

|  |  |
| --- | --- |
| `InlcudeElevations` | `ExcludeElevations` |
| `IncludeFullDescriptions` | `ExcludeFullDescriptions` |
| `IncludeNames` | `ExcludeNames` |
| `IncludeNumbers` | `ExcludeNumbers` |
| `IncludeRawDescriptions` | `ExcludeRawDescriptions` |
| `IncludePointGroups` |  |

Each of these properties is a string that describes the selection criteria used. As many properties may be used as needed to make your selection. Any property left blank has no affect on the selection.

The properties that query string properties of points (`FullDescription`, `Name`, `RawDescription`) consist of a comma-separated list of possible strings to match against. Each element in that list may contain the wildcards “?” and “\*”. The properties that deal with number properties of points consist of a comma delineated list of specific numbers or ranges of numbers (two values separated by a hyphen, such as “100-200”). The properties that deal with elevation consist of a comma delineated list of specific elevations, ranges of elevation, upper limits (a less-than symbol followed by a value, such as “<500”), or lower limits (a greater-than symbol followed by a value, such as “>100”).

```
' Add points to the point group using the QueryBuilder.
 
' Add point 1 and point 2 to the point group.
oPtGroup.QueryBuilder.IncludeNames = "po?nt1,point2"
' Add point 3 to the point group by using its number.
oPtGroup.QueryBuilder.IncludeNumbers = "3"
' You can also use wildcards. The following would
' select all points with a name beginning with "poi".
oPtGroup.QueryBuilder.IncludeNames = "poi*"
' Exclude those points with an elevation above 300.
oPtGroup.QueryBuilder.ExcludeElevations = ">300"
' And include those points with identification numbers 
' 100 through 200 inclusive, and point number 206.
oPtGroup.QueryBuilder.IncludeNumbers = "100-200,206"
```

To create a group that contains every point in the document, set the boolean `AeccPointGroup.InlcudeAllPoints` property to `True`.

**Parent topic:** [Point Groups](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-38BAEBE7-FB02-41B0-90AC-EDD985AE7A97.htm)