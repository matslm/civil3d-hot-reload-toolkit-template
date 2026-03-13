---
title: "Loading and Xref Performance (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-8FE5F117-AF55-4E5F-940D-75267AA20D41.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Advanced Drawing and Organizational Techniques (.NET)", "Use External References (.NET)", "Loading and Xref Performance (.NET)"]
---

# Loading and Xref Performance (.NET)

Through a combination of demand loading and saving drawings with indexes, you can increase the performance of drawings with external references. Demand loading works in conjunction with the XLOADCTL and INDEXCTL system variables. When you turn on demand loading, if indexes have been saved in the referenced drawings, AutoCAD loads into memory only the data from the reference drawing that is necessary to regenerate the current drawing. In other words, referenced material is read in “on demand.”

To turn on demand loading, set the XLOADCTL system variable using the `SetSystemVariable` method. The following settings apply to the XLOADCTL system variable:

* 0 = Turns off demand-loading. The entire drawing is loaded
* 1 = Turns on demand-loading. Referenced drawings are kept open and locked
* 2 = Turns on demand-loading. Copies of referenced drawings are opened and locked; referenced drawings are not locked

By default, XLOADCTL is set to 2 and stored with the AutoCAD user profile.

To realize the maximum benefits of demand loading, you need to save the referenced drawings with layer and spatial indexes. The performance benefits of demand loading are most noticeable when you clip the xref to display a small fraction of it, and a spatial index is saved in the externally referenced drawing.

Freeze several layers of the xref, and the externally referenced drawing is saved with a layer index.

To turn on layer and spatial indexes, set the INDEXCTL system variable using the `SetSystemVariable` method. The following settings apply to the INDEXCTL system variable:

* 0 = No indexes created
* 1 = Layer index created
* 2 = Spatial index created
* 3 = Both spatial and layer indexes created

By default, INDEXCTL is set to 0 when you create a new AutoCAD drawing.

For more information on demand loading and xrefs, see “About Improving Performance When Using Xrefs” in the product Help system.

**Parent topic:** [Use External References (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-563BAE97-48B1-4DCE-9DDA-16D8C6F13E23.htm)

#### Related Concepts

* [Attach Xrefs (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-D6EE5FE7-C0BC-4E9B-AAE3-3B5A14B870FE.htm)
* [Reload Xrefs (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-5716B433-01F1-4510-8B46-DDCB6E78C7EF.htm)
* [Update Xrefs (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-AB3AF3BF-6482-474E-B2F9-20FF528027D3.htm)
* [Use External References (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-563BAE97-48B1-4DCE-9DDA-16D8C6F13E23.htm)
* [Advanced Drawing and Organizational Techniques (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CD733E01-7E42-45E8-AAC9-63B6EC39FF4E.htm)