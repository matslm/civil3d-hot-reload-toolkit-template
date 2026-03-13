---
title: "Adding a Non-destructive Breakline"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-479244F4-1823-409A-A0AD-2CB826CD6A54.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Surfaces in COM", "Working with TIN Surfaces", "Adding a Breakline to a TIN Surface", "Adding a Non-destructive Breakline"]
---

# Adding a Non-destructive Breakline

A non-destructive breakline does not remove any triangle edges. It places new points along the breakline at each intersection with a triangle edge and new triangles are computed. Again, it is created like standard breaklines are created except you call the `AeccSurfaceBreaklines.AddNonDestructiveBreakline` method.

```
Set oBreakline = oTinSurface.Breaklines _
  .AddNonDestructiveBreakline( _
    oEntityArray, _
    "Sample Non-Destructive Break", _
    1#)
```

**Parent topic:** [Adding a Breakline to a TIN Surface](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-DA156CFB-2C7D-4821-9DED-7ED049B47328.htm)