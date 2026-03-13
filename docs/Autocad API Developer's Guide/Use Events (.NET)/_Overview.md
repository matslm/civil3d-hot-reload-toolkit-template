---
title: "Use Events (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-61F01DC0-F385-43A2-8040-140C051B171E.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Use Events (.NET)"]
---

# Use Events (.NET)

Events are notifications, or messages, that are sent out by AutoCAD® to inform you about the current state of the session, or alert you that something has happened. For example, when a drawing is saved the `BeginSave` event is triggered. There are other events triggered when a drawing is closed, a command is started or even when a system variable is changed. Given this information you could write a subroutine, or event handler, that uses these events to track changes to a drawing or the amount of time a user spends working on a particular drawing.

#### Related Concepts

* [Understand AutoCAD Events (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CC1C9D4A-9517-40BF-8D3D-CBC15C9646B9.htm)
* [Guidelines for Event Handlers (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-FE7D58D5-28A0-4C98-A876-D4D48F06D0B2.htm)
* [Register and Unregister Events (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-5089A5B4-5553-4A4C-A88B-455AA29A0E96.htm)
* [Handle Application Events (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-4BD5D384-5448-4D19-9023-DA12A55FAEF0.htm)
* [Handle Document Events (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F432E285-8B94-4ACD-A186-89E1218DEC07.htm)
* [Handle DocumentCollection Events (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-E619BB54-D531-4640-BB74-B61E6CA13238.htm)
* [Handle Object Events (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-E30279D1-E4B5-48A4-A3D8-9CEC83BD0967.htm)
* [Register COM Based Events (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F7E86804-F789-418F-937D-919188D88A45.htm)