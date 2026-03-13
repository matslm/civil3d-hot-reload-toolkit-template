---
title: "Tooltips (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-705CC39E-D2FA-470D-8252-5A4823A247A6.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Customize User Interface (CUI) Managed API (.NET)", "Customization Sections (.NET)", "Tooltips (.NET)"]
---

# Tooltips (.NET)

Tooltips provide a short summary of a feature when the cursor of the pointing device is positioned over a command or control.

The
`ToolTip` and
`ToolTipContent` classes of the
`Autodesk.AutoCAD.Customization` namespace define the tooltips for commands and their content, respectively. When a tooltip is defined and assigned to a user interface element, the content of the tooltip can be displayed by positioning the cursor of the pointing device over the user interface element and pressing F1.

The
`ToolTip` and
`ToolTipService` classes of the
`Autodesk.Windows` namespace both derive from the classes of the same name in the
`System.Windows` namespace. You use the
`Autodesk.Windows.ToolTip` class to control the visual properties of a tooltip, such as showing and closing, fading in and fading out, and background opacity and color. The
`Autodesk.Windows.ToolTipService` class is used to define the help source and topics for the text to be displayed.

**Parent topic:** [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")

#### Related Concepts

* [CUI Elements (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-311320E4-6829-4799-A5B0-9425C157A8FD.htm "Many user interface elements share a number of properties in common with each other that describe .")
* [Menu Macros (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C75BC92C-0784-44B7-9D5C-62D5A74B2333.htm "Menu macros define the command sequences to be passed to the AutoCAD Command prompt when a user interface element is clicked.")
* [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")
* [Customize User Interface (CUI) Managed API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-71554E76-8FD5-4853-82CD-3587764CBCAC.htm "Many of the user interface elements can be customized in the AutoCAD program with the Customize User Interface (CUI) dialog box or CUI managed API.")