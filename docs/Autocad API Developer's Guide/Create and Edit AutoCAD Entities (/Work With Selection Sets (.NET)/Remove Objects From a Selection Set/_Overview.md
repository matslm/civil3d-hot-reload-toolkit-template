---
title: "Remove Objects From a Selection Set (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C1573808-66CF-4E40-8E7A-C52DFBCA352E.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Work With Selection Sets (.NET)", "Remove Objects From a Selection Set (.NET)"]
---

# Remove Objects From a Selection Set (.NET)

After you create a selection set, you can work with the object ids of the objects selected. Selection sets do not allow you to add or remove object ids from it, but you can use an `ObjectIdCollection` object to merge multiple selection sets into a single object to work with. You can add and remove object ids from an `ObjectIdCollection` object. Use the `Remove` or `RemoveAt` methods to remove an object id from an `ObjectIdCollection` object.

**Parent topic:** [Work With Selection Sets (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DE15FB0E-8669-4D58-9261-DB4CF86F89F3.htm "A selection set can consist of a single object, or it can be a more complex grouping: for example, the set of objects on a certain layer.")

#### Related Concepts

* [Work With Selection Sets (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DE15FB0E-8669-4D58-9261-DB4CF86F89F3.htm "A selection set can consist of a single object, or it can be a more complex grouping: for example, the set of objects on a certain layer.")
* [Add To or Merge Multiple Selection Sets (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-D0BD4249-1122-4209-ABEA-6F19FA156F91.htm)