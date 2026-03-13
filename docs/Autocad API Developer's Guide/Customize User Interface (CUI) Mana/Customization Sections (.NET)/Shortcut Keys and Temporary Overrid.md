---
title: "Shortcut Keys and Temporary Overrides (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-4767A018-8699-4E69-ADB7-02240D6DD99E.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Customize User Interface (CUI) Managed API (.NET)", "Customization Sections (.NET)", "Shortcut Keys and Temporary Overrides (.NET)"]
---

# Shortcut Keys and Temporary Overrides (.NET)

Shortcut keys and temporary override are used to start commands and temporarily toggle drafting settings.

## Shortcut Keys

Shortcut keys are used to execute a command that starts a command or displays a dialog box. The main CUIx file defines many shortcut keys that are common to all Windows applications, such as Ctrl+O to opening a file or Ctrl+P to print/plot a file.

The
`AcceleratorCollection` class is used to manage the keyboard shortcuts in a customization group; use the
`CustomizationSection.MenuGroup.Accelerators` property to get the
`AcceleratorCollection` object. A keyboard shortcut is represented by a
`MenuAccelerator` object. The
`AcceleratorShortcutKey` property defines the key combination for a shortcut and is attached to a
`MenuAccelerator` object, which contains the macro command to execute.

The value assigned to the
`AcceleratorShortcutKey` property is a string that represents the key combination to be pressed, such as “CTRL+SHIFT+ALT+X”, where X is a valid character or virtual key description.

## Temporary Overrides

Temporary override keys to toggle drafting aids, such as Object Snaps, Dynamic Input, and Object Tracking. The main AutoCAD CUIx file defines the temporary overrides that can be used when working in a drawing.

The
`TemporaryOverrideCollection` class is used to manage the temporary overrides in a customization group; use the
`CustomizationSection.MenuGroup.TemporaryOverrides` property to get the
`TemporaryOverrideCollection` object. A temporary override is represented by a
`TemporaryOverride` object. The
`OverrideShortcutKey` property defines the key combination for a temporary override and is attached to a
`TemporaryOverride` object, which contains the macro command to execute when the key combination is pressed and held.

The value assigned to the
`OverrideShortcutKey` property is a string that represents the key combination to be pressed, such as “SHIFT+X”, where X is a valid character or virtual key description.

Temporary overrides can define macros for both the key up and key down events with the
`UpOverride` and
`DownOverride` properties.

**Parent topic:** [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")

#### Related Concepts

* [CUI Elements (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-311320E4-6829-4799-A5B0-9425C157A8FD.htm "Many user interface elements share a number of properties in common with each other that describe .")
* [Menu Macros (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C75BC92C-0784-44B7-9D5C-62D5A74B2333.htm "Menu macros define the command sequences to be passed to the AutoCAD Command prompt when a user interface element is clicked.")
* [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")
* [Customize User Interface (CUI) Managed API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-71554E76-8FD5-4853-82CD-3587764CBCAC.htm "Many of the user interface elements can be customized in the AutoCAD program with the Customize User Interface (CUI) dialog box or CUI managed API.")