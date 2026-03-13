---
title: "Adding a Proximity Breakline"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-35BA23BC-EF62-4FB5-A285-2404BA2E890D.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Surfaces in COM", "Working with TIN Surfaces", "Adding a Breakline to a TIN Surface", "Adding a Proximity Breakline"]
---

# Adding a Proximity Breakline

A proximity breakline does not add new points to a surface. Instead, the nearest surface point to each breakline endpoint is used. The triangles that make up a surface are then recomputed making sure those points are connected. A proximity breakline is created using the same fashion as standard breaklines except you call `AeccSurfaceBreaklines.AddProximityBreakline` instead of `AeccSurfaceBreaklines.AddStandardBreakline`.

```
Set oBreakline = oTinSurface.Breaklines.AddProximityBreakline( _
  oEntityArray, _
  "Sample Proximity Break", _
  1#)
```

**Parent topic:** [Adding a Breakline to a TIN Surface](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-DA156CFB-2C7D-4821-9DED-7ED049B47328.htm)