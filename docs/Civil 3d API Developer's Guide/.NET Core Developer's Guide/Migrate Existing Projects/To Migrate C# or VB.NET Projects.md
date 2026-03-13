---
title: "To Migrate C# or VB.NET Projects"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-10C2EC00-1879-4028-A772-396A8E35CA85.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", " .NET Core Developer's Guide", "Migrate Existing Projects", "To Migrate C# or VB.NET Projects"]
---

# To Migrate C# or VB.NET Projects

Reference documents

* [Install .NET Upgrade Assistant](https://beehive.autodesk.com/community/service/rest/cloudhelp/resource/cloudhelpchannel/guidcrossbook/?v=2026&p=CIV3D&l=ENU&accessmode=live&guid=HTTPS://DOTNET.MICROSOFT)
* [Upgrade Assistant Overview](https://beehive.autodesk.com/community/service/rest/cloudhelp/resource/cloudhelpchannel/guidcrossbook/?v=2026&p=CIV3D&l=ENU&accessmode=live&guid=HTTPS://LEARN.MICROSOFT)
* [Upgrade Assistant for WinForms and .NET Framework](https://beehive.autodesk.com/community/service/rest/cloudhelp/resource/cloudhelpchannel/guidcrossbook/?v=2026&p=CIV3D&l=ENU&accessmode=live&guid=HTTPS://LEARN.MICROSOFT)
* [Porting to .NET Core](https://beehive.autodesk.com/community/service/rest/cloudhelp/resource/cloudhelpchannel/guidcrossbook/?v=2026&p=CIV3D&l=ENU&accessmode=live&guid=HTTPS://LEARN.MICROSOFT)
* [Modernizing .NET Applications](https://beehive.autodesk.com/community/service/rest/cloudhelp/resource/cloudhelpchannel/guidcrossbook/?v=2026&p=CIV3D&l=ENU&accessmode=live&guid=HTTPS://LEARN.MICROSOFT)

To migrate a C# or VB.NET Project

1. Install the .NET Upgrade Assistant plugin.

   ![](../images/GUID-667646B1-BB44-4823-B4F4-425E0D423585.png)
2. Right-click on the project in the Solution Explorer window, and select Upgrade.

   ![](../images/GUID-6D392A81-F093-4E27-B877-2C053CCBE550.png)
3. Select Upgrade project to a newer .NET version.

   ![](../images/GUID-26317E12-E5FB-47BA-99CC-117FE2C78709.png)
4. Select your upgrade type.

   ![](../images/GUID-F46C80A0-3DDE-492C-BA03-9C560F9175E3.png)
5. Select .NET 8.0 as the project target framework.

   ![](../images/GUID-1C3E9303-8E5A-473D-9806-F06D0F9A4644.png)
6. Select components to upgrade and click the Upgrade selection button.

   ![](../images/GUID-8E3F9B14-E4C2-4810-96C0-B9762DB9642B.png)
7. Check the result.

   ![](../images/GUID-EBC47761-3C90-418D-AE26-0248EBD8E23C.png)
8. Manually replace the reference DLLs with the .NET 8 version DLLs.

   ![](../images/GUID-728511CA-A3C9-4F0A-AA20-0F36CF0A101F.png)
9. To ensure the output DLL is generated to the correct folder, add the following properties to .csproj:

   ```
   <PropertyGroup>
     <AppendTargetFrameworkToOutputPath>false</AppendTargetFrameworkToOutputPath>
     <AppendRuntimeIdentifierToOutputPath>false</AppendRuntimeIdentifierToOutputPath>
   </PropertyGroup>
   ```
10. Rebuild the plugin projects.
11. In your PackageContents.xml file, be sure to set both
    `SeriesMin` and
    `SeriesMax` to "R25.0" and
    `Platform` to "Civil3D" to ensure it can be loaded and is only loaded in Civil 3D 2025. See more details on
    [AutoCAD 2024 Developer and ObjectARX Help | Runtime Requirements Element Reference](https://help.autodesk.com/view/OARX/2024/ENU/?guid=GUID-1591CA01-EF87-48CD-952B-772FE26037F1)

    ```
    <RuntimeRequirements SeriesMin="R25.0" SeriesMax="R25.0" Platform="Civil3D" OS="Win64"/>
    ```

## Reference Package

Some referenced packages are not supported in .NET 8. You should find an alternative by searching on
[Nuget](https://www.nuget.org/). Select the Frameworks tab on the package page, and check if the package supports .NET, .NET Core, and .NET Standard.

**Parent topic:** [Migrate Existing Projects](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-52909F1A-DA65-40D1-AFB8-190239289927.htm)