---
title: "Define Rules for Selection Filters (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-D9FB23AE-D853-4D00-A910-4F66FCC4607A.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Work With Selection Sets (.NET)", "Define Rules for Selection Filters (.NET)"]
---

# Define Rules for Selection Filters (.NET)

You can limit which objects are selected and added to a selection set by using a selection filter. A selection filter list can be used to filter selected objects by properties or type. For example, you might want to select only blue objects or objects on a certain layer. You can also combine selection criteria. For example, you can create a selection filter that limits selection to blue circles on the layer named Pattern.

Note: Filtering recognizes values explicitly assigned to objects, not those inherited by the layer. For example, if an object’s linetype property is set to ByLayer and the layer it is assigned is set to the Hidden linetype; filtering for objects assigned the Hidden linetype will not select these objects since their linetype property is set to ByLayer.

**Parent topic:** [Work With Selection Sets (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DE15FB0E-8669-4D58-9261-DB4CF86F89F3.htm "A selection set can consist of a single object, or it can be a more complex grouping: for example, the set of objects on a certain layer.")

#### Related Concepts

* [Work With Selection Sets (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DE15FB0E-8669-4D58-9261-DB4CF86F89F3.htm "A selection set can consist of a single object, or it can be a more complex grouping: for example, the set of objects on a certain layer.")
* [Use Selection Filters to Define Selection Set Rules (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-125398A5-184C-4114-9212-A2FF28FC1F1D.htm)
* [Specify Multiple Criteria in a Selection Filter (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-BE8B5EE4-9B5A-4D1F-B2D8-7DC013BFC6C0.htm)
* [Add Complexity to Your Filter List Conditions (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-04B8192E-B0D8-4731-A882-AE92B7CFAE22.htm)
* [Use Wild-Card Patterns in Selection Set Filter Criteria (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-3C1A759C-BB88-41A7-B1DE-697C493C92C8.htm)
* [Filter for Extended Data (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-FCEBA022-3F80-47BE-BC29-8DF73CA9C0B8.htm)
* [Select Objects in the Drawing Area (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CBECEDCF-3B4E-4DF3-99A0-47103D10DADD.htm)