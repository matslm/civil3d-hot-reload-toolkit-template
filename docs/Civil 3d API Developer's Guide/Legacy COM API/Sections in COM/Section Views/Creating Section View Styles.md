---
title: "Creating Section View Styles"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-58B1F1CC-42C2-4EBA-8EA5-D4B262642876.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Sections in COM", "Section Views", "Creating Section View Styles"]
---

# Creating Section View Styles

The section view style, an object of type `AeccSectionViewStyle`, governs all aspects of how the graph axes, text, and titles are drawn. Within `AeccSectionViewStyle` are objects dealing with the top, bottom, left, center vertical, and right axes and with the graph as a whole. All section view styles in the document are stored in the `AeccDocument.SectionViewStyles` collection. New styles are created using the collection’s `Add` method with the name of the new style.

```
Dim oSectionViewStyle As AeccSectionViewStyle
Set oSectionViewStyle = oDocument.SectionViewStyles _
  .Add("Section View style")
```

**Parent topic:** [Section Views](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-F0BF43AC-C9B2-4A8B-BFA3-0FA46F7C5D8C.htm)