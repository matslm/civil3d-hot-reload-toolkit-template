---
title: "Exercise: Reference the AutoCAD .NET API Files (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-2363CE7C-AC2B-4CAC-AE5D-F77B386132D7.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Getting Started with Microsoft Visual Studio (.NET)", "Exercises: Create Your First Project (.NET)", "Exercise: Reference the AutoCAD .NET API Files (.NET)"]
---

# Exercise: Reference the AutoCAD .NET API Files (.NET)

In this exercise, you will reference the .NET assemblies
*AcCoreMgd.dll*,
*AcMgd.dll*, and
*AcDbMgd.dll*. After you reference the three files, you will adjust the properties of the referenced files so they are not copied to the build output folder.

## To reference the AutoCAD .NET API Files

1. In Microsoft Visual Studio, click View menu ![](../images/ac.menuaro.gif) Solution Explorer to display the Solution Explorer; if it is not already displayed.
2. In the Solution Explorer, right-click the Dependencies node and click Add Project Reference.
3. In the Reference Manager -
   *<project>* dialog box, at the bottom of the dialog, click Browse.
4. In the Select the Files to Reference dialog box, browse to one of the following locations:
   * *inc* folder within the ObjectARX SDK that is supported for this release (recommended)
   * Install folder of AutoCAD; default install location is
     *<drive>:\Program Files\Autodesk\AutoCAD <release>*
5. Select the
   *AcCoreMgd.dll* file, then press and hold Ctrl, and select the
   *AcDbMgd.dll* and
   *AcMgd.dll* files. Click Add.
6. Click OK.
7. In the Solution Explorer, click the triangle to the left of the Dependencies node to expand it.
8. Press and hold Ctrl, and select AcCoreMgd, AcDbMgd, and AcMdg from under the Dependencies node.
9. Right-click over one of the selected references and click Properties.
10. In the Properties window, click the Copy Local field and then select No from the drop-down list.

    Note: Setting Copy Local to No instructs Microsoft Visual Studio to not include the referenced DLLs in the build output for the project. If the referenced DLLs are copied to the build output folder, it might cause unexpected results when the assembly file is loaded into AutoCAD.

**Parent topic:** [Exercises: Create Your First Project (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-BA686431-C8BF-49F2-946E-9CEB2F7AE4FA.htm)

#### Related Concepts

* [Exercise: Create a New Project (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-23E33075-3C36-48CA-B937-B85606B77F71.htm)
* [Exercise: Create a New Command (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-90D867AA-6513-4F0C-A498-7453FEA4FEC3.htm)