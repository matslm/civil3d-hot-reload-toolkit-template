---
title: "C++ Interoperability (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-FE481D64-4239-448A-8711-6F6F98D1B092.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "About .NET and the AutoCAD .NET API (.NET)", "Overview of Microsoft Visual Studio (.NET)", "C++ Interoperability (.NET)"]
---

# C++ Interoperability (.NET)

Your .NET application can include C++ portions, so you can also use ObjectARX APIs that do not have managed wrappers. The ObjectARX managed wrapper classes have a consistent property and method that enable you to go back and forth between the managed and unmanaged object.

A pointer to the underlying unmanaged object from a managed object can be obtained using the
`UnmanagedObject` property. You can create a managed object from an unmanaged object with the
`DisposableWrapper.Create()` method.

**Parent topic:** [Overview of Microsoft Visual Studio (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-381ADCF4-57D6-47FD-AB31-251A895BAD6B.htm)

#### Related Concepts

* [Components of the AutoCAD .NET API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-8657D153-0120-4881-A3C8-E00ED139E0D3.htm)
* [Overview of Microsoft Visual Studio (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-381ADCF4-57D6-47FD-AB31-251A895BAD6B.htm)