---
title: "Center Objects (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-3711BC79-542D-4681-8CBB-A8B1C768305A.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Control the AutoCAD Environment (.NET)", "Control the Drawing Windows (.NET)", "Zoom and Pan the Current View (.NET)", "Center Objects (.NET)"]
---

# Center Objects (.NET)

You can reposition the image in the drawing window by changing the center point of a view using the
`CenterPoint` property. When the center point of a view is changed and the size of the view is not changed, the view is panned parallel to the screen.

## Zoom in on the active drawing to a specified center

This example code demonstrates how to change the center point of the current view using the Zoom procedure defined under the "Manipulate the Current View" topic.

While the Zoom procedure is passed a total of four values, the first two values are defined as new 3D points and are ignored by the procedure. The third value is the point (5,5,0) to define the new center point of the view and 1 is passed in for the last value to retain the size of the current view.

### C#

```
[CommandMethod("ZoomCenter")]
static public void ZoomCenter()
{
  // Center the view at 5,5,0
  Zoom(new Point3d(), new Point3d(), new Point3d(5, 5, 0), 1);
}
```

### VB.NET

```
<CommandMethod("ZoomCenter")> _
Public Sub ZoomCenter()
  '' Center the view at 5,5,0
  Zoom(New Point3d(), New Point3d(), New Point3d(5, 5, 0), 1)
End Sub
```

### VBA/ActiveX Code Reference

```
Sub ZoomCenter()
    Dim Center(0 To 2) As Double
    Dim magnification As Double
 
    Center(0) = 5: Center(1) = 5: Center(2) = 0
    magnification = 1
 
    ThisDrawing.Application.ZoomCenter Center, magnification
End Sub
```

**Parent topic:** [Zoom and Pan the Current View (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-B44F15B0-BF4A-48ED-AA86-5445075B94BD.htm)

#### Related Concepts

* [Zoom and Pan the Current View (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-B44F15B0-BF4A-48ED-AA86-5445075B94BD.htm)
* [Scale a View (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-25131FDB-7C20-44C1-B3F2-BACD27F7C116.htm)
* [Manipulate the Current View (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-FAC1A5EB-2D9E-497B-8FD9-E11D2FF87B93.htm)