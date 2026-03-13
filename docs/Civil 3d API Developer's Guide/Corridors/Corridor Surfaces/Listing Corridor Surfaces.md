---
title: "Listing Corridor Surfaces"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-CD7E82F2-39B4-4A9D-80FC-6C4E1D636FA8.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Corridors", "Corridor Surfaces", "Listing Corridor Surfaces"]
---

# Listing Corridor Surfaces

The collection of all corridor surfaces for each corridor is held in the `Corridor.CorridorSurfaces` property. Each corridor surface contains the boundary of the surface and a list of all point, link, and feature line codes used in the construction of the surface. Corridor surfaces also contain read-only references to the surface style ID and section style ID used in drawing the surface.

This sample lists all the corridor surfaces within a corridor and specifies the point codes that make up each surface:

```
// List surfaces
foreach (CorridorSurface oCorridorSurface in oCorridor.CorridorSurfaces)
{
    ed.WriteMessage("Corridor surface: {0}\n", oCorridorSurface.Name);
 
    // Get the point codes for the surface.
    String[] oPointCodes = oCorridorSurface.PointCodes();                        
    ed.WriteMessage("Surface point codes:\n");
    foreach (String s in oPointCodes)
    {
        ed.WriteMessage("{0}\n", s); 
    }
 
}
```

**Parent topic:** [Corridor Surfaces](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-99425C70-15B1-48E8-8DCF-3E4831DDB773.htm)