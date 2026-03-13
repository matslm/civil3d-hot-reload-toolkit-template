---
title: "Plot Scale (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-BDDF7C1B-797D-4C8E-AF5F-7B830638D024.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Define Layouts and Plot (.NET)", "Layouts (.NET)", "Layout Settings (.NET)", "Plot Scale (.NET)"]
---

# Plot Scale (.NET)

Generally, you draw objects at their actual size. When you plot the drawing, you either specify a precise scale or fit the image to the output size. You specify a scale with either a standard or custom plot scale.

A standard scale is used when the `UseStandardScale` property is set to `TRUE`. The actual scale at which the plot will be scaled to can be queried with the `StdScale` property.

A custom scale is used when the `UseStandardScale` property is set to `FALSE`. The custom scale at which the plot will be scaled to can be queried with the `CustomPrintScale` property.

When reviewing an early draft view, a precise scale is not always important. You can set the `StdScaleType` property to a value of `ScaleToFit` defined by the `StdScaleType` enum to plot the layout at the largest possible size that fits the output size.

**Parent topic:** [Layout Settings (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-0071C84E-1BC0-4AB0-848A-FE4CAF9472CB.htm)

#### Related Concepts

* [Layout Settings (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-0071C84E-1BC0-4AB0-848A-FE4CAF9472CB.htm)