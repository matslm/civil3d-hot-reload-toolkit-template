---
title: "Creating Profile View Styles"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-884E35F2-B3A6-46E0-AE73-9FEE6C51E02F.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Profiles", "Profile Views", "Creating Profile View Styles"]
---

# Creating Profile View Styles

The profile view style, an object of type `ProfileViewStyle`, governs all aspects of how the graph axes, text, and titles are drawn. Within `ProfileViewStyle` are objects dealing with the top, bottom, left, and right axes; lines at geometric locations within profiles; and with the graph as a whole. All profile view styles in the document are stored in the `CivilDocument.ProfileViewStyles` collection. New styles are created using the collection’s `Add` method with the name of the new style.

```
ObjectId profileViewStyleId = doc.Styles.ProfileViewStyles.Add("New Profile View Style");
ProfileViewStyle oProfileViewStyle = ts.GetObject(profileViewStyleId, OpenMode.ForRead) as ProfileViewStyle;
```

**Parent topic:** [Profile Views](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-64F78FB9-C7B7-4DE2-9ED9-30B1F1551058.htm)