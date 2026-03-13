---
title: "Listing Baseline Regions"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-FD659734-7D36-4C8E-A6D2-3C7A4A14F48B.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Corridors in COM", "Baselines", "Listing Baseline Regions"]
---

# Listing Baseline Regions

The collection of all the regions of a baseline are contained in the `AeccBaseline.BaselineRegions` property.

The Autodesk Civil 3D API does not include methods for creating new baseline regions or manipulating existing regions.

The following sample displays the start and end station for every baseline region in a baseline:

```
Dim oBaselineRegion As AeccBaselineRegion
For Each oBaselineRegion In oBaseline.BaselineRegions
    Debug.Print "Baseline information -"
    Debug.Print "Start station: " & oBaselineRegion.StartStation
    Debug.Print "End station: " & oBaselineRegion.EndStation
    Debug.Print
Next
```

**Parent topic:** [Baselines](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-AE66E414-80CA-4FA2-BA7C-C3E4BA404499.htm)