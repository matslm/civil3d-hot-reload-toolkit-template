---
title: "Mouse Button Behavior (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-B0D1B503-D3A7-4495-8833-C04E7907F162.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Customize User Interface (CUI) Managed API (.NET)", "Customization Sections (.NET)", "Mouse Button Behavior (.NET)"]
---

# Mouse Button Behavior (.NET)

Mouse and digitizer button actions can be customized by associating them with shortcut menus or macro commands. The left mouse button and mouse wheel functions cannot be changed.

Custom actions for the middle and right buttons work properly based upon the value of the MBUTTONPAN and SHORTCUTMENU system variables.

The
`CustomizationSection.MenuGroup.MouseButtons` property returns a
`MouseButtonGroupCollection` collection of
`ButtonGroup` objects. Each
`ButtonGroup` object is a collection of
`ButtonItem` objects. You use the
`ButtonItems` property of the
`ButtonGroup` object to get the
`ButtonItemCollection` object. The
`ButtonItem` object defines the behavior of a button by attaching a macro. The button items define the behavior for regular clicks and clicks executed while an accelerator key (SHIFT, CTRL or SHIFT+CTRL) is pressed and held.

Use the
`CustomizationSection.MenuGroup.DigitzerButtons` collection to modify digitizer button behavior.

**Parent topic:** [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")

#### Related Concepts

* [CUI Elements (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-311320E4-6829-4799-A5B0-9425C157A8FD.htm "Many user interface elements share a number of properties in common with each other that describe .")
* [Menu Macros (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C75BC92C-0784-44B7-9D5C-62D5A74B2333.htm "Menu macros define the command sequences to be passed to the AutoCAD Command prompt when a user interface element is clicked.")
* [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")
* [Customize User Interface (CUI) Managed API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-71554E76-8FD5-4853-82CD-3587764CBCAC.htm "Many of the user interface elements can be customized in the AutoCAD program with the Customize User Interface (CUI) dialog box or CUI managed API.")