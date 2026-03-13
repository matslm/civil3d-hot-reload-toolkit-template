---
title: "Creating Surfaces"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-3445C7B8-88CA-40E1-90F1-DCCD1E6E56BB.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Surfaces", "Creating Surfaces"]
---

# Creating Surfaces

`GridSurface` and `TinSurface` objects can be created from an imported file, or created as a new, empty surface to which surface data can be added later. A new `TinSurface` can also be created by cropping existing `TinSurface` objects.

Note: Import from LandXML data is not supported in the .NET API at this time. You can use the COM API to import or export surface data to or from LandXML.

Most methods for creating empty or importing surfaces are similar in that they all have two overloads: one that specifies the database where the surface will be created (with the default `SurfaceStyle` applied), the other specifies a `SurfaceStyle` to apply, and adds the surface to the database that contains the `SurfaceStyle`.

Volume surfaces are created from two existing surfaces, the base (bottom) surface and a comparison surface.

**Parent topic:** [Surfaces](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-84BF7EAC-6DF4-447E-A0DB-82C03EA2F584.htm)