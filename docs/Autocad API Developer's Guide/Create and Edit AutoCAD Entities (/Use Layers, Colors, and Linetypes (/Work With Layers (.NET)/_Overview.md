---
title: "Work With Layers (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-97955B2B-F823-4787-86C7-97F7E701FD72.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Use Layers, Colors, and Linetypes (.NET)", "Work With Layers (.NET)"]
---

# Work With Layers (.NET)

You are always drawing on a layer. It may be the default layer or a layer you create and name yourself. Each layer has an associated color and linetype among other properties. For example, you can create a layer on which you draw only centerlines and assign the color blue and the linetype CENTER to that layer. Then, whenever you want to draw centerlines you can switch to that layer and start drawing.

All layers and linetypes are stored in separate symbol tables. Layers are kept within the `LayerTable`, and linetypes are kept within the `LinetypeTable`.

**Parent topic:** [Use Layers, Colors, and Linetypes (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-758F50B8-A2A0-429C-AC31-88B3A2D1BBBC.htm)

#### Related Concepts

* [Use Layers, Colors, and Linetypes (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-758F50B8-A2A0-429C-AC31-88B3A2D1BBBC.htm)
* [Sort Layers and Linetypes (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-8C2502C9-ED82-4956-BA45-6A87ED4D676B.htm)
* [Create and Name Layers (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-7BF88244-D866-40D1-8C21-7DD1A2C633DF.htm)
* [Make a Layer Current (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-07DDED83-4D27-4A5F-B411-25BF4F5E76D4.htm)
* [Turn Layers On and Off (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-09BBF8AE-B581-499D-AFF0-41F53C1B6ACC.htm)
* [Freeze and Thaw Layers (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-4ADF80DD-5BEF-4C28-90A9-76FDA8E2E804.htm)
* [Lock and Unlock Layers (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-505CCDA2-7060-4180-929C-CD065AD840D2.htm)
* [Assign Color to a Layer (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-4C6504CF-3AEE-4CBF-97DE-55BDF2515192.htm)
* [Assign a Linetype to a Layer (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-21AFAAC8-5B07-4DEB-B45E-980AECC05168.htm)
* [Remove Layers (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DF8A64D3-AE09-4BCE-B9E1-1B642DA4FCFF.htm)