---
title: "Prompt for User Input (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-41E19C3B-B40A-41EC-88CB-347B1161B74A.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Control the AutoCAD Environment (.NET)", "Prompt for User Input (.NET)"]
---

# Prompt for User Input (.NET)

The
`Editor` object, which is a child of the
`Document` object, defines the user input methods. The user input methods display a prompt on the AutoCAD command line or in a dynamic input tooltip, and request input of various types. This type of user input is most useful for interactive input of screen coordinates, entity selection, and short-string or numeric values. If your application requires the input of numerous options or values, a Windows form may be more appropriate than individual prompts.

Each user input method displays an optional prompt on the command line and returns a value specific to the type of input requested. For example,
`GetString` returns a
`PromptResult` which allows you to determine the status of the
`GetString` method and retrieve the string the user entered. Each one of the user input methods has a specific return value.

The input methods accept a string for the prompt message to be displayed or a specific object type which controls the input from the user. These object types let you control things such as
`NULL` input (pressing Enter), base point, input of zero or negative numbers, and input of arbitrary text values.

To force the prompt to be displayed on a line by itself, use

* "\n" with strings in C#.
* the carriage return/linefeed constant
  `(vbCrLf)` or linefeed constant (vbLf) at the beginning of your prompt strings when using VB.NET.

**Parent topic:** [Control the AutoCAD Environment (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-B9D5DD07-846E-418F-A346-0CEB35E724F7.htm)

#### Related Concepts

* [Control the AutoCAD Environment (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-B9D5DD07-846E-418F-A346-0CEB35E724F7.htm)
* [GetString Method (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-203F2756-1BA6-4226-A505-B776ED8AF0FB.htm)
* [GetPoint Method (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-33058D80-EA6B-4A19-9F07-F20BC5EBC530.htm)
* [GetKeywords Method (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DF40DD82-FD27-43C5-B7D2-E75646B2E47E.htm)
* [Control User Input (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-3D998905-0C24-4FF9-A9C7-7F361A591B80.htm)