---
title: "Shape Style"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-2E9AB4E5-C918-4D89-B0BA-03AA7429CEA0.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Corridors in COM", "Styles", "Shape Style"]
---

# Shape Style

The collection of all shape style objects are found in the `AeccRoadwayDocument.ShapeStyles` property. This style object contains properties for adjusting the visual display of assembly and subassembly shapes, including the outline and the inside area.

Note:

Shape style objects are not used directly with shape objects, but are instead used with roadway style sets.

```
' Create a new shape style and change it so that it has
' an orange border and a yellow hatch fill.
Dim oShapeStyle As AeccRoadwayShapeStyle
Set oShapeStyle = oRoadwayDocument.ShapeStyles.Add("Style3")
With oShapeStyle
    .AreaFillDisplayStylePlan.color = 50 ' yellow
    .AreaFillDisplayStylePlan.Visible = True
    .AreaFillHatchDisplayStylePlan.HatchType = aeccHatchPreDefined
    .AreaFillHatchDisplayStylePlan.Pattern = "LINE"
    .BorderDisplayStylePlan.color = 30 ' orange
    .BorderDisplayStylePlan.Visible = True
End With
```

**Parent topic:** [Styles](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-FBD270F4-E403-4FDA-9A92-28A448DA124B.htm)