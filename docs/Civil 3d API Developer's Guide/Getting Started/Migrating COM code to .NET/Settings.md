---
title: "Settings"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-8382A198-2A48-4342-B8EE-8F75FE8EA1CD.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Getting Started", "Migrating COM code to .NET", "Settings"]
---

# Settings

In the COM API, settings are accessed through the `AeccDatabase::Settings` object, which contains properties representing the settings object hierarchy. In the .NET API, you use a method to retrieve specific settings objects, for example:

```
SettingsPipeNetwork oSettingsPipeNetwork = doc.Settings.GetFeatureSettings<SettingsPipeNetwork>() as SettingsPipeNetwork;
```

**Parent topic:** [Migrating COM code to .NET](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-40723CA6-38F1-4F7A-A1CA-373F8DC52358.htm)