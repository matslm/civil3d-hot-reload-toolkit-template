---
title: "Create a New Project (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-43564EB9-F843-4771-823C-573495EE23E0.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Getting Started with Microsoft Visual Studio (.NET)", "Work with Microsoft Visual Studio Projects (.NET)", "Create a New Project (.NET)"]
---

# Create a New Project (.NET)

New projects are created based on a project template. When creating a new project that will be built into a DLL assembly that will be loaded into AutoCAD, use the Class Library template that comes with Microsoft Visual Studio or one of the AutoCAD Managed project application templates that get installed with the AutoCAD .NET Wizard. Both types of templates are available for the VB.NET and C# programming languages. After a new project is created, you will need to reference the files that make up the AutoCAD .NET API.

## Procedures

**To create a new project using a standard template**

1. In Microsoft Visual Studio, on the Start window, click Create a New Project.

   If the Start window isn't displayed, click File menu ![](../images/ac.menuaro.gif) New ![](../images/ac.menuaro.gif) Project to create a new project.
2. In the Create a New Project dialog box, from the Language drop-down list, select C# (or Visual Basic).
3. From the Platforms drop-down list, select Windows.
4. From the Project Types drop-down list, select Library.
5. In the Templates list, select Class Library - A project for creating a class library that targets .NET or .NET Standard.

   To utilize forms in your application, Select WPF Class Library - A project for creating a class library that targets a .NET WPF Application.

   Warning: Make sure to not select the Class Library (.NET Framework) or Class Library (Universal Windows) template.

   Note: If you created a C# or VB Class Library, it can be changed to a WPF Class Library by editing the project file and adding the attribute
   `<UseWPF>true</UseWPF>` to the
   `PropertyGroup` element.

   ![](../images/GUID-71F2A817-23AB-47BE-9679-3A5BFF3A3630.png)
6. Click Next.
7. In the Configure Your New Project dialog box, click in the Project Name box and enter a name for the new project.

   ![](../images/GUID-56DDB548-0804-4851-8210-E7BE1F705963.png)
8. In the Location box, enter a location or click Browse to select a folder for the new project.
9. In the Solution Name box, enter a name for the new solution that the project will be added to.
10. Optionally, clear the Place Solution and Project in the Same Directory check box to create a sub-folder under the solution for the project.
11. Click Next.
12. In the Additional Information dialog box, from the Framework drop-down list, select .NET 8.0 (Long Term Support).

    ![](../images/GUID-4D5EAF39-A833-4642-8170-BA39104CB6C6.png)
13. Click Create.
14. On the Solution Explorer, right-click over the project's node and choose
    **Edit Project File**.
15. In the editor window, add the following in bold within the
    `Project` element and below the
    `ProjectGroup` element.

    ```
    <Project Sdk="Microsoft.NET.Sdk">

      <PropertyGroup>
        <TargetFramework>net8.0</TargetFramework>
        <ImplicitUsings>enable</ImplicitUsings>
        <Nullable>enable</Nullable>
      </PropertyGroup>

      <ItemGroup>
        <FrameworkReference Include="Microsoft.WindowsDesktop.App"></FrameworkReference>
      </ItemGroup>
    </Project>
    ```

    Note: `TargetFramework` can also be updated from
    `net8.0` to
    `net8.0-windows` to target the Windows OS and utilize Windows related libraries. Instead of editing the value directly in the project's file, the value can be made under the Application section of the Project Properties window.
16. Save and close the project file.

**To create a new project using an AutoCAD Managed template**

Before using one of the AutoCAD Managed templates, you must first download and install the latest release of the ObjectARX SDK.

1. In Microsoft Visual Studio, click File menu ![](../images/ac.menuaro.gif) New ![](../images/ac.menuaro.gif) Project (or click File menu ![](../images/ac.menuaro.gif) New Project).
2. In the Create a New Project dialog box, click in the Search box and enter
   **AutoCAD**.
3. From the Templates list, select AutoCAD <release> C Sharp Plug-in (or AutoCAD <release> VB Plug-in).

   ![](../images/GUID-3A1883AA-438C-4F82-A019-B90F1E1B6E1A.png)
4. Click Next.
5. In the Configure Your New Project dialog box, click in the Project Name box and enter a name for the new project.

   ![](../images/GUID-577B5E68-643F-48B3-BFE6-4B26E6854E51.png)
6. In the Location box, enter a location or click Browse to select a folder for the new project.
7. In the Solution Name box, enter a name for the new solution that the project will be added to.
8. Optionally, clear the Place Solution and Project in the Same Directory check box to create a sub-folder under the solution for the project.
9. Click Create.
10. In the AutoCAD .NET Wizard Configurator dialog box, specify the libraries to reference to the project.

    ![](../images/GUID-0828F18E-84FB-45A1-A264-A73061F7E2C0.png)
11. Click OK.

**Parent topic:** [Work with Microsoft Visual Studio Projects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-1CC02D8C-78F3-4B2D-81FA-40DB3E89D601.htm)

#### Related Concepts

* [Components of the AutoCAD .NET API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-8657D153-0120-4881-A3C8-E00ED139E0D3.htm)
* [Work with Microsoft Visual Studio Projects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-1CC02D8C-78F3-4B2D-81FA-40DB3E89D601.htm)
* [Load an Assembly (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-4EB83A6B-9903-4BF7-9F19-767A4D419CE3.htm)