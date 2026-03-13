---
title: "Plot Your Drawing (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CE91C625-A278-4445-8219-3A2D880E6C22.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Define Layouts and Plot (.NET)", "Plot Your Drawing (.NET)"]
---

# Plot Your Drawing (.NET)

You can plot your drawing as it is viewed in Model space, or you can plot one of your prepared Paper space layouts. Plotting from Model space is often preferable when you want to view or verify your drawing prior to creating a Paper space layout. Once your model is ready, you can prepare and plot a Paper space layout.

Note: The BACKGROUNDPLOT system variable controls if plotting occurs in the background or the foreground. Set BACKGROUNDPLOT to 0 to plot in the foreground.

Plotting involves working with a number of different objects: `PlotFactory`, `PlotEngine`, `PlotInfo`, `PlotSettings`, `PlotSettingsValidator`, `PlotInfoValidator`, and `PlotPageInfo`. The `PlotEngine` object is responsible for generating a plot based on the information provided to it by a `PlotInfo` object.

The `PlotEngine` object is used to generate the output of a layout. From the `PlotEngine` object, you can do the following:

* Plot to a file
* Plot to a plotter or printer
* Displays a preview of a layout

**Parent topic:** [Define Layouts and Plot (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-0A29EBB7-C010-4C4E-A712-334731DADAB4.htm)

#### Related Concepts

* [Define Layouts and Plot (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-0A29EBB7-C010-4C4E-A712-334731DADAB4.htm)
* [Plot From Model Space (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-6E0B1F7B-7B0E-4E3E-B1FD-018E0A3673BE.htm)
* [Plot From Paper Space (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C8AF82C4-FF10-42B9-A99F-79DC3D8CEF51.htm)
* [Publish Layouts (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-B08B5173-0C17-4663-BD1C-A40E4C8F3A75.htm)