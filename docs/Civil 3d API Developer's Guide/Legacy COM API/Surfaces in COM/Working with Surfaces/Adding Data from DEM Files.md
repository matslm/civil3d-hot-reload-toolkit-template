---
title: "Adding Data from DEM Files"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-0305C3A1-8B75-42C2-B7AF-69C2B6FF3D29.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Surfaces in COM", "Working with Surfaces", "Adding Data from DEM Files"]
---

# Adding Data from DEM Files

Any number of DEM files can be added to existing grid and TIN surfaces. When a DEM file is added to the `AeccGridSurface.DEMFiles` or `AeccTinSurface.DEMFiles` collection, its information is converted to an evenly spaced lattice of triangles that is added to the surface.

```
oTinSurface.DEMFiles.Add("C:\My Documents\file.dem")
```

**Parent topic:** [Working with Surfaces](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-9D3780D3-858E-4310-882C-034005A9B48C.htm)