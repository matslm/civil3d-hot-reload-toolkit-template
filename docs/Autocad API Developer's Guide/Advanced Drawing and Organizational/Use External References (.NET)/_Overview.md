---
title: "Use External References (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-563BAE97-48B1-4DCE-9DDA-16D8C6F13E23.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Advanced Drawing and Organizational Techniques (.NET)", "Use External References (.NET)"]
---

# Use External References (.NET)

An external reference (xref) links another drawing to the current drawing. When you insert a drawing as a block, the block and all of the associated geometry is stored in the current drawing database. It is not updated if the original drawing changes. When you insert a drawing as an xref, however, the xref is updated when the original drawing changes. A drawing that contains xrefs, therefore, always reflects the most current editing of each externally referenced file.

Like a block reference, an xref is displayed in the current drawing as a single object. However, an xref does not significantly increase the file size of the current drawing and cannot be exploded. As with blocks, you can nest xrefs that are attached to your drawing.

For more information about xrefs, see “About Attaching and Detaching Referenced Drawings (Xrefs)” in the product Help system.

**Parent topic:** [Advanced Drawing and Organizational Techniques (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CD733E01-7E42-45E8-AAC9-63B6EC39FF4E.htm)

#### Related Concepts

* [Update Xrefs (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-AB3AF3BF-6482-474E-B2F9-20FF528027D3.htm)
* [Attach Xrefs (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-D6EE5FE7-C0BC-4E9B-AAE3-3B5A14B870FE.htm)
* [Detach Xrefs (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-DEAD46A2-BC5B-4313-B84B-AB2B62D66DB2.htm)
* [Reload Xrefs (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-5716B433-01F1-4510-8B46-DDCB6E78C7EF.htm)
* [Unload Xrefs (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-FC87E6F7-1B67-4537-B155-B59FE226E38A.htm)
* [Bind Xrefs (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-640D3814-6258-4DCF-8407-FE58B5DB5D9C.htm)
* [Clip Blocks and Xrefs (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-72029044-0840-4187-9A58-F2A4518E3A23.htm)
* [Loading and Xref Performance (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-8FE5F117-AF55-4E5F-940D-75267AA20D41.htm)
* [Advanced Drawing and Organizational Techniques (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CD733E01-7E42-45E8-AAC9-63B6EC39FF4E.htm)