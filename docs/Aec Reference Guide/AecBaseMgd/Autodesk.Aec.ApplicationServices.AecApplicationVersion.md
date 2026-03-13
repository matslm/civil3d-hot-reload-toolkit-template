---
title: Autodesk.Aec.ApplicationServices.AecApplicationVersion
hierarchy: AecBaseMgd > Autodesk > Aec > ApplicationServices > AecApplicationVersion
---

# Autodesk.Aec.ApplicationServices.AecApplicationVersion

## Summary
This class holds the abstraction of the version information.

## Properties

### Major
Get the major number.

**Returns:** The major number.

### Minor
Gets the minor number.

**Returns:** The minor number.

### BuildMajor
Gets the build major.

**Returns:** The build major.

### BuildMinor
Gets the build minor.

**Returns:** The build minor.

## Methods

### #ctor(Autodesk.Aec.ApplicationServices.AppDbxconst)
Initializes a new instance of the AecApplicationVersion class using the specified ?.

- **`app`**: ?

### Base
Returns the verison of AecBase.dbx.

**Returns:** The version of AecBase.dbx.

### Specific(System.Int16,System.Int16,System.Int16,System.Int16)
Static "factory" method that creates an object from four specific unsigned 16-bit values.

- **`major`**: The major number.
- **`minor`**: The minor number.
- **`buildMajor`**: The build major number.
- **`buildMinor`**: The build minor number.

**Returns:** A new instance of application version.

### Older(System.Int16,System.Int32)
Constructs a version from two numbers (pre-2010 style)

- **`version`**: The version.
- **`actual`**: The actual number.

**Returns:** A new instance of application version.

### DwgInFields(Autodesk.AutoCAD.DatabaseServices.DwgFiler)
Reads the object in from a filer.

- **`filer`**: The filer used for reading the object.

### DwgOutFields(Autodesk.AutoCAD.DatabaseServices.DwgFiler)
Files out the object.

- **`filer`**: The filer used for writing out the object.

### op_Equality(Autodesk.Aec.ApplicationServices.AecApplicationVersion)
Compares the application version with the other.

- **`other`**: The other application verison passed in.

**Returns:** The boolean value if the application version is equal to the other.

### op_LessThan(Autodesk.Aec.ApplicationServices.AecApplicationVersion,Autodesk.Aec.ApplicationServices.AecApplicationVersion)
Operator "less-than". Compares each component and if equal, the next one, and so on.

- **`one`**: One of the application versions passed in.
- **`other`**: The other application version passed in.

**Returns:** The boolean value if the application version is less than the other.
