---
title: "Creating Data Band Sets for Profile Views"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-A2AF30B5-5AA2-4687-BB97-4BC3A142133D.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Data Bands in COM", "Creating a Data Band Set", "Creating Data Band Sets for Profile Views"]
---

# Creating Data Band Sets for Profile Views

Individual band styles can be grouped together into a set, which can then be assigned to a graph. Profile band sets are `AeccProfileViewBandStyleSet` objects stored in the `AeccDocument.ProfileViewBandStyleSet` collection.

The following example demonstrates creating a profile band style set and adding a band style to it:

```
Dim oProfileViewBandStyleSet As AeccProfileViewBandStyleSet
Set oProfileViewBandStyleSet = _
  oDocument.ProfileViewBandStyleSets.Add("Profile Band set")
 
' Add a band style we have already created to the
' band set.
Call oProfileViewBandStyleSet.Add(oBandProfileDataStyle)
 
' Now we have a band set consisting of one band.
```

Data band sets are used when profile views are first created. The following sample code is taken from the topic [Creating a Profile View](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-8B62A6B6-32CC-4289-89B0-EFDFDB3B04C8.htm), but this time a data band set is passed in the last parameter.

```
Set oProfileView = oAlignment.ProfileViews.Add( _
   "Profile Style 01", _
   "0", _
   dOriginPt, _
   oProfileViewStyle, _
   oProfileViewBandStyleSet)
```

**Parent topic:** [Creating a Data Band Set](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-13900D9A-ECC2-4484-87C4-A2B7F15B468E.htm)