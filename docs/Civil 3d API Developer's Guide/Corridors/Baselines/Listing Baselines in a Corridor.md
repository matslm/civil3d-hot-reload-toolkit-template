---
title: "Listing Baselines in a Corridor"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-9CD5C53D-3DA6-454F-8A0B-190E10B9E283.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Corridors", "Baselines", "Listing Baselines in a Corridor"]
---

# Listing Baselines in a Corridor

The collection of all baselines in a corridor are contained in the `Corridor.Baselines` property, which is type `BaselineCollection`.

The following sample displays information about the underlying alignment and profile for every baseline in a corridor:

```
foreach (Baseline oBaseline in oCorridor.Baselines)
{                       
    Alignment oAlign = ts.GetObject(oBaseline.AlignmentId, OpenMode.ForRead) as Alignment;
    Profile oProfile = ts.GetObject(oBaseline.ProfileId, OpenMode.ForRead) as Profile;
    ed.WriteMessage(@"Baseline information - 
      Alignment     : {0}
      Profile       : {1}
      Start station : {2}
      End station   : {3}", 
      oAlign.Name,
      oProfile.Name,
      oBaseline.StartStation,
      oBaseline.EndStation);
}
```

**Parent topic:** [Baselines](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-1AA0E4C0-F3CB-4907-8AC4-9CBF4175CF8C.htm)