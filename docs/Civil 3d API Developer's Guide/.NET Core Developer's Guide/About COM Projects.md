---
title: "About COM Projects"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-280CCBAB-7712-4EEB-9A8C-808F8FC3121D.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", " .NET Core Developer's Guide", "About COM Projects"]
---

# About COM Projects

In general, .NET migration does not have significant implications for COM interfaces, but we do observe some necessary changes.

Before:

```
objectobj = Marshal.GetActiveObject("AutoCAD.Application.24.3"); 
readonlystringm_sAeccAppProgId ="AeccXUiRoadway.AeccRoadwayApplication.13.6";
```

Now:

```
[DllImport("ole32.dll")]
public static extern int GetActiveObjectExt(ref Guid rclsid, IntPtr reserved, [MarshalAs(UnmanagedType.Interface)] out object ppunk);
...
var type = Type.GetTypeFromProgID("AutoCAD.Application.25");
readonly string m_sAeccAppProgId = "AeccXUiRoadway.AeccRoadwayApplication.13.7";
var guid = type.GUID;
 
int result = GetActiveObjectExt(ref guid, IntPtr.Zero, out obj);
```

**Parent topic:** [.NET Core Developer's Guide](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-71F9A52A-9B91-41A1-B542-0B3422B5C2E7.htm)