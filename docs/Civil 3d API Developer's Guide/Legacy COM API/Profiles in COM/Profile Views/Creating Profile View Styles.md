---
title: "Creating Profile View Styles"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-5E51A716-C2CB-414C-AE34-CBFED85F7738.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Profiles in COM", "Profile Views", "Creating Profile View Styles"]
---

# Creating Profile View Styles

The profile view style, an object of type `AeccProfileViewStyle`, governs all aspects of how the graph axes, text, and titles are drawn. Within `AeccProfileViewStyle` are objects dealing with the top, bottom, left, and right axes; lines at geometric locations within profiles; and with the graph as a whole. All profile view styles in the document are stored in the `AeccDocument.ProfileViewStyles` collection. New styles are created using the collection’s `Add` method with the name of the new style.

```
Dim oProfileViewStyle As AeccProfileViewStyle
Set oProfileViewStyle = oDocument.ProfileViewStyles _
  .Add("Profile View style 01")
```

**Parent topic:** [Profile Views](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-866491CC-CD6A-4693-905E-A066CCA91B14.htm)