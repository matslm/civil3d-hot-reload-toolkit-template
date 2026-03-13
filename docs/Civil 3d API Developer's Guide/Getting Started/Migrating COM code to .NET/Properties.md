---
title: "Properties"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-4FB2FACB-6AB2-4BFC-945C-4A4DA2B7CD02.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Getting Started", "Migrating COM code to .NET", "Properties"]
---

# Properties

In the COM API, properties are usually simple built-in types, such as `double`, or types such as `BSTR` that map to built-in VBA types such as `String`. In the .NET API, most properties are one of the `Property*` classes that implement the `IProperty` interface. For these properties, you get or set the `Value` of the property. For example, this code in COM:

```
oLabelStyleLineComponent.Visibility = True
```

Becomes this in .NET:

```
oLabelStyleLineComponent.General.Visible.Value = true;
```

Note:

There are a few other changes here: the `Visibility` property is renamed `Visible`, which has moved to a sub-property of `LabelStyleLineComponent` called `General`.

**Parent topic:** [Migrating COM code to .NET](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-40723CA6-38F1-4F7A-A1CA-373F8DC52358.htm)