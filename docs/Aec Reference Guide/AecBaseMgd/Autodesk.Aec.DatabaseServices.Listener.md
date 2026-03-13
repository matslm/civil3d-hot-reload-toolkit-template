---
title: Autodesk.Aec.DatabaseServices.Listener
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > Listener
---

# Autodesk.Aec.DatabaseServices.Listener

## Summary
Represents a ?.

## Properties

### Enabled
Check whether this listener is enabled.

## Methods

### #ctor
Initializes a new instance of the Listener class.

### #ctor(System.Boolean)
Initializes a new instance of the Listener class.

- **`sendObjectAppendedAndErasedNotifications`**: Specify whether to receive object appended/Erased notifications.

### addClassParam(Autodesk.AutoCAD.Runtime.RXClass,System.Int32)
Specify the individual parameter of a specified class, when it's modified, will trigger a notification to this listener.

- **`type`**: Input the type of the class to listen for changes.
- **`parameterId`**: Input the id of the parameter, which should be defined in class type.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### addClassParam(System.Int32,Autodesk.AutoCAD.Runtime.RXClass)
Specify the individual parameter of a specified class, when it's modified, will trigger a notification to this listener.

- **`parameterId`**: Input the id of the parameter, which should be defined in class type.
- **`type`**: Input the type of the class to listen for changes.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### addClassToNotify(Autodesk.AutoCAD.Runtime.RXClass)
Specify the class type which is supposed to notify.

- **`type`**: The class type which is supposed to notify.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### addClassNotToNotify(Autodesk.AutoCAD.Runtime.RXClass)
Specify the class type which is not supposed to notify.

- **`type`**: The class type which is not supposed to notify.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### allowByClass(Autodesk.AutoCAD.Runtime.RXClass)
Check whether this input class type is allowed to notify.

- **`type`**: The input class type to check with.
