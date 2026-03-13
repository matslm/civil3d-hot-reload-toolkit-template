---
title: Autodesk.Aec.DatabaseServices.DictionaryRecord
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DictionaryRecord
---

# Autodesk.Aec.DatabaseServices.DictionaryRecord

## Summary
Represents a dictionary record.

## Properties

### Name
Gets the dictionary name.

**Returns:** Returns the dictionary name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### LocalizedName
Gets the localized display name.

**Returns:** Returns the localized display name.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AlternateName
Gets or sets the alternate name.

**Returns:** Returns the alternate name.

### IsLocked
Gets or sets the value that determines if the dict record is locked.

**Returns:** true, if the dict record is locked.

### Keynote
Gets or sets the keynote.

**Returns:** Returns the keynote.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### KeynoteValue
Gets the keynote value.

**Returns:** Returns the keynote value.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### AutomaticallyBoundSpaces
Gets or sets whether this object acts as an automatic space boundary.

**Returns:** AutomaticSpaceBoundary.Yes indicates it will act as an automatic space boundary.  AutomaticSpaceBoundary.No indicates it will NOT act as an automatic space boundary.  AutomaticSpaceBoundary.NotApplicableToThisObject indicates it can not act as an automatic space boundary.

- **Exception `T:Autodesk.AutoCAD.Runtime.Exception`**: Autodesk.AutoCAD.Runtime.Exception.

### Classifications
Gets the classification collection. Perform add/remove operations on the collection.

**Returns:** Returns the classification collection.

**Remarks:**
When there are no classifications present, an empty collection is provided that classification definitions Ids can be added to.

### Translator
Gets or sets the name translator for this dictionary record.

**Returns:** The current translator.
