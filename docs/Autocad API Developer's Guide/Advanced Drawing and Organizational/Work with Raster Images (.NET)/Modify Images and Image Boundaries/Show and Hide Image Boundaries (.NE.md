---
title: "Show and Hide Image Boundaries (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-530C64AD-A003-4489-A6F8-0AE907B9EC69.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Advanced Drawing and Organizational Techniques (.NET)", "Work with Raster Images (.NET)", "Modify Images and Image Boundaries (.NET)", "Show and Hide Image Boundaries (.NET)"]
---

# Show and Hide Image Boundaries (.NET)

Hiding an image boundary ensures that the image cannot accidentally be moved or modified and prevents the boundary from being plotted or displayed. When image boundaries are hidden, clipped images are still displayed to their specified boundary limits; only the boundary is affected. Showing and hiding image boundaries affects all images attached to your drawing.

Use the `IsClipped` property when you want to show or hide the image boundary.

Note: This property affects only the image boundary. To see a change in the image when toggling this property, look closely at the small boundary surrounding the image.

**Parent topic:** [Modify Images and Image Boundaries (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F036DC50-B12C-422D-80C8-EC34E5B7DB27.htm)

#### Related Concepts

* [Modify Images and Image Boundaries (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F036DC50-B12C-422D-80C8-EC34E5B7DB27.htm)
* [Attach and Scale a Raster Image (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-00A0BCD9-4519-4746-BC73-88544D75D789.htm)
* [Work with Raster Images (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-9C12C46C-FC03-4E41-B27F-06FFD4991A84.htm)
* [Advanced Drawing and Organizational Techniques (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CD733E01-7E42-45E8-AAC9-63B6EC39FF4E.htm)