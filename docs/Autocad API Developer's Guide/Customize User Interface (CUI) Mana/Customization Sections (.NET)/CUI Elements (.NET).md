---
title: "CUI Elements (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-311320E4-6829-4799-A5B0-9425C157A8FD.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Customize User Interface (CUI) Managed API (.NET)", "Customization Sections (.NET)", "CUI Elements (.NET)"]
---

# CUI Elements (.NET)

Many user interface elements share a number of properties in common with each other that describe .

User interface elements such as ribbon buttons, pop-up menu items, toolbar buttons, toolbar controls, and shortcut keys have the following common properties:

* Name
* Parent
* ElementID
* MenuMacroReference
* MacroID
* Display Name

Elements must define their parent in the constructor, which also adds the element into the parent object.

In the following sample code, a new button is added to the last position of the Draw toolbar during initialization. An explicit call to the toolbar’s
`Add()` method is not required.

### C#

```
Toolbar drawToolbar = cs.MenuGroup.Toolbars.FindToolbarWithName("DRAW");
ToolbarButton polyLineButton = new ToolbarButton(drawToolbar,-1);
```

### VB.NET

```
Dim drawToolbar As Toolbar = cs.MenuGroup.Toolbars.FindToolbarWithName("DRAW")
Dim polyLineButton As ToolbarButton = New ToolbarButton(drawToolbar,-1)
```

## Version Control

CUI elements derive from the
`VersionableElement` base class, which adds a revision number to the element. Newly created or modified elements are tagged with the version number of the current
*AcCui.dll* file.

The
`MenuMacro` class, which represents an action or command, can contain multiple versions of a macro. When calling the macro property, the correct macro for the current version of the AutoCAD program is returned. Iterate through the
`MenuMacro.Macros` collection for other versions of the macro.

**Parent topic:** [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")

#### Related Concepts

* [Menu Macros (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C75BC92C-0784-44B7-9D5C-62D5A74B2333.htm "Menu macros define the command sequences to be passed to the AutoCAD Command prompt when a user interface element is clicked.")
* [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")
* [Customize User Interface (CUI) Managed API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-71554E76-8FD5-4853-82CD-3587764CBCAC.htm "Many of the user interface elements can be customized in the AutoCAD program with the Customize User Interface (CUI) dialog box or CUI managed API.")