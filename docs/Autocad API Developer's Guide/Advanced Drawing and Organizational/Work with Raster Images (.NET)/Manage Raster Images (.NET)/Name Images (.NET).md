---
title: "Name Images (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-B2275251-B262-4607-BDBE-7A73200E8744.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Advanced Drawing and Organizational Techniques (.NET)", "Work with Raster Images (.NET)", "Manage Raster Images (.NET)", "Name Images (.NET)"]
---

# Name Images (.NET)

Image names are not necessarily the same as image file names. When you attach an image to a drawing, you assign a name to the image file reference in the Image dictionary. You can change the image name without affecting the name of the file.

The image file is represented by the `SourceFileName` property on the `RasterImageDef` object. Changing the `SourceFileName` property will change the image in the drawing. The image name is represented by the `Key` property for the `DBDictionaryEntry` object that represents the `RasterImageDef` object, and changing the `Key` property will change the name of the image only, not the file associated with it.

**Parent topic:** [Manage Raster Images (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-55037987-E94F-451E-8190-6385DA147FD9.htm)

#### Related Concepts

* [Change Image File Paths (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-475A8D8C-61A3-4C72-849A-D2FB39C4C9D9.htm)
* [Manage Raster Images (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-55037987-E94F-451E-8190-6385DA147FD9.htm)
* [Work with Raster Images (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-9C12C46C-FC03-4E41-B27F-06FFD4991A84.htm)
* [Advanced Drawing and Organizational Techniques (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CD733E01-7E42-45E8-AAC9-63B6EC39FF4E.htm)