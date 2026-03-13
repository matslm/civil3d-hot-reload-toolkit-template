---
title: "Rename a Project (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-1224BFC8-2641-44F9-B644-7DAED9A0B81E.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Getting Started with Microsoft Visual Studio (.NET)", "Edit an Existing Project or Solution (.NET)", "Rename a Project (.NET)"]
---

# Rename a Project (.NET)

When a project is created, the name of the project file is stored with the project. If the name of a project file is changed outside of Visual Studio, the stored project name will not be changed to match. As a best practice, only rename your project or solution from Visual Studio to maintain consistency.

You can rename a project file from the Properties window or through File Explorer. The project name is set when the project is first created, but can be renamed through the Solution Explorer.

Caution: While a project file can be renamed through File Explorer, it is not recommended to do this. It can break the reference with the solution file or another project file. If you break the reference with a solution or another project, when you open the solution or project file, you will be notified that a reference is missing.

## Procedures

**To change the name of a project**

1. In Microsoft Visual Studio, Solution Explorer, right-click the project you want to rename and click Rename.
2. In the In-place text editor, enter a new name.

   ![](../images/GUID-7E331960-6D23-43B4-B175-F7DD0DD312E0.png)
3. Press Enter or click outside the in-place text editor to finish renaming the project.

**Parent topic:** [Edit an Existing Project or Solution (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-5B0B3B8A-DF3C-4053-94E8-0519550CD553.htm)

#### Related Concepts

* [Edit an Existing Project or Solution (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-5B0B3B8A-DF3C-4053-94E8-0519550CD553.htm)
* [Create a New Project (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-43564EB9-F843-4771-823C-573495EE23E0.htm)
* [Use the Properties Window (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CCD5BCF6-0C18-4608-A3FF-8EBD89882CE0.htm)