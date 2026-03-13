---
title: "Double-click Action Customization (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-D8326E2F-CEBE-4362-ABFC-5C19777109D2.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Customize User Interface (CUI) Managed API (.NET)", "Customization Sections (.NET)", "Double-click Action Customization (.NET)"]
---

# Double-click Action Customization (.NET)

Double-click actions can be used to start an editing command when an object in the drawing area is double-clicked.

Double clicking on most objects in the drawing window displays the Properties palette. This behavior can be changed with the
`DoubleClickAction` and
`DoubleClickCmd` classes. Use these classes to add editing behavior for a custom object.

The customization of the double-click behavior is done by first attaching a
`MacroId` to a
`DoubleClickCmd` object. This defines the action that will be performed. Next, attach a
`DoubleClickAction` object to a drawing object using the
`DxfName()` property. Finally attach the action to the command.

### C#

```
DoubleClickAction dblClickAction = new DoubleClickAction(cs.MenuGroup, "My Double click", -1);
dblClickAction.DxfName = "Polyline";

DoubleClickCmd dblClickCmd = new DoubleClickCmd(dblClickAction);
dblClickCmd.MacroID = "MM_1567";
dblClickAction.DoubleClickCmd = dblClickCmd;
```

### VB.NET

```
Dim dblClickAction as DoubleClickAction = New DoubleClickAction(cs.MenuGroup, "My Double click", -1)
dblClickAction.DxfName = "Polyline"

Dim dblClickCmd As DoubleClickCmd = New DoubleClickCmd(dblClickAction)
dblClickCmd.MacroID = "MM_1567"
dblClickAction.DoubleClickCmd = dblClickCmd
```

`dblClickAction` in the previous code samples is now set to execute the polyline edit macro (MM\_1567) when a Polyline graphical object is double-clicked. If a double-click action for an object is overridden, the new action takes precedence, and the old action becomes inactive.

**Parent topic:** [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")

#### Related Concepts

* [CUI Elements (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-311320E4-6829-4799-A5B0-9425C157A8FD.htm "Many user interface elements share a number of properties in common with each other that describe .")
* [Menu Macros (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C75BC92C-0784-44B7-9D5C-62D5A74B2333.htm "Menu macros define the command sequences to be passed to the AutoCAD Command prompt when a user interface element is clicked.")
* [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")
* [Customize User Interface (CUI) Managed API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-71554E76-8FD5-4853-82CD-3587764CBCAC.htm "Many of the user interface elements can be customized in the AutoCAD program with the Customize User Interface (CUI) dialog box or CUI managed API.")