---
title: "Menu Macros (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C75BC92C-0784-44B7-9D5C-62D5A74B2333.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Customize User Interface (CUI) Managed API (.NET)", "Customization Sections (.NET)", "Menu Macros (.NET)"]
---

# Menu Macros (.NET)

Menu macros define the command sequences to be passed to the AutoCAD Command prompt when a user interface element is clicked.

The CUIx file defines menu macros that are attached to elements. An interface element must have a MacroID to identify the action to be performed when the element is clicked; each macro has a unique identity string to represent that command. The
`MenuMacro` class defines a macro string, which can be a simple command, a command sequence with options and values, or a complex DIESEL expression.

For information on creating macros and using DIESEL, see “About Command Customization” and “About DIESEL Expressions in Macros” in the AutoCAD help system.

## PopMenus with DIESEL Expressions

The DIESEL expressions passed to the
`PopMenu.DisplayName()` and
`PopMenuItem.DisplayName()` properties are evaluated by the AutoCAD application environment during runtime. In this case, the properties return the name of the menu item as it would appear in the pulldown menu. When called from a stand-alone application, these methods just return the DIESEL expression.

**Parent topic:** [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")

#### Related Concepts

* [CUI Elements (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-311320E4-6829-4799-A5B0-9425C157A8FD.htm "Many user interface elements share a number of properties in common with each other that describe .")
* [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")
* [Customize User Interface (CUI) Managed API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-71554E76-8FD5-4853-82CD-3587764CBCAC.htm "Many of the user interface elements can be customized in the AutoCAD program with the Customize User Interface (CUI) dialog box or CUI managed API.")