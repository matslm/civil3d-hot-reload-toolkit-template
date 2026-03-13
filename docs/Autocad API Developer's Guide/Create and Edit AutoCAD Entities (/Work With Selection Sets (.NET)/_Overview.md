---
title: "Work With Selection Sets (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DE15FB0E-8669-4D58-9261-DB4CF86F89F3.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Work With Selection Sets (.NET)"]
---

# Work With Selection Sets (.NET)

A selection set can consist of a single object, or it can be a more complex grouping: for example, the set of objects on a certain layer.

A selection set is typically created by requesting a user to select an object in the drawing area before a command is started through pick first selection or at the Select objects: prompt when a command is active. Selection sets are not persistent objects, if you need to maintain a selection set for use between multiple commands or future use, you will need to create a custom dictionary and record the ObjectIds found in the selection set as soft pointers in dictionary records.

As an alternatively to storing ObjectIds as soft pointers, you could store each objects handle in the dictionary. You would then use the
`Database.GetObjectId` method to get an object's ObjectId from the stored handle.

Note: Whether you store an ObjectId as a soft pointer or a handle in a dictionary, you will want to make sure the object exists before accessing it.

### Prompts and Selection Filters

The management of selection sets is split across multiple objects that are part of the
`Autodesk.AutoCAD.EditorInput` namespace. You use the
`Editor` object to prompt the user for a selection, and to perform the selection action. The
`PromptSelectionOptions` object is used to configure the prompt that will be displayed to the user when the selection operation begins, and the
`SelectionFilter` class can be used to filter a selection set by entity properties.

The
`PromptSelectionOptions` class provides a
`SetKeywords` method for specifying prompt keywords, as well as
`MessageForAdding` and
`MessageForRemoval` properties for configuring the prompt message. The
`SelectionFilter` class accepts filter parameters in the form of an array of
`TypedValue` objects, as described in the "ResultBuffer Data Type (.NET)" topic. Each
`TypedValue` object represents a single filter condition. Any number of conditions may be specified for a selection.

When your application is ready to prompt for the selection, you call the
`GetSelection` method on the
`Editor` object. The
`Editor.GetSelection` method exists in a number of overloaded versions. For a simple, unfiltered selection using the standard AutoCAD prompt, you use the no-parameter overload. For cases where you want to provide custom prompt messages, including keywords, you use an overload that accepts a
`PromptSelectionOptions` object. To specify a filter, use an overload that accepts a
`SelectionFilter` object.

Other selection methods cover the full range of selection modes available in the AutoCAD program. The
`Editor.SelectImplied` method provides access to the implied, or pick-first, selection set. The
`Editor.SelectPrevious` method returns the objects selected in the previous selection set. Methods such as
`SelectCrossingWindow` and
`SelectFence` let applications select entities by window, crossing, fence, and polygon.

**Parent topic:** [Create and Edit AutoCAD Entities (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F5601807-2FA9-486F-A212-E693D452D81F.htm)

#### Related Concepts

* [Obtain the PickFirst Selection Set (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-D4987D00-1164-4217-A82E-B8B49FFB7A29.htm)
* [Select Objects in the Drawing Area (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CBECEDCF-3B4E-4DF3-99A0-47103D10DADD.htm)
* [Selection Set Keywords (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-94A4E3DE-0066-4D6A-8558-0252BE8CB85E.htm "Applications may use keywords to prompt users for selection preferences before actually creating the selection set.")
* [Add To or Merge Multiple Selection Sets (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-D0BD4249-1122-4209-ABEA-6F19FA156F91.htm)
* [Define Rules for Selection Filters (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-D9FB23AE-D853-4D00-A910-4F66FCC4607A.htm)
* [Remove Objects From a Selection Set (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C1573808-66CF-4E40-8E7A-C52DFBCA352E.htm)
* [ResultBuffer Data Type (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-A43BA3F1-513E-42E5-A21F-633FAF97B5C9.htm "The ResultBuffer type is a class that mirrors the resbuf struct defined in the ObjectARX SDK. The resbuf struct provides a flexible container for AutoCAD-specific data.")