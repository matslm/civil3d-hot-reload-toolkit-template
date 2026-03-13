---
title: Autodesk.Aec.DatabaseServices.NameTranslator
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > NameTranslator
---

# Autodesk.Aec.DatabaseServices.NameTranslator

## Summary
Represents a name translator.

## Methods

### #ctor
Initializes a new instance of the NameTranslator class.

### Create(System.IntPtr,System.Boolean)
Creates a new instance of the NameTranslator class.

- **`unmanagedPointer`**: Inputs the unmanaged pointer of NameTranslator object.
- **`autoDelete`**: Inputs true if unmanaged object is destroyed by wrapper, otherwise false.

### Add(System::String^,System::String^)
Adds a translation entry from globalName to localName.

- **`globalName`**: The global name to translate.
- **`localName`**: The local name to be translated to.

**Returns:** true, if added; false, otherwise.

### Get(System::String^,System::String^)
Gets the translation for globalName.

- **`globalName`**: The global name to translate.

**Returns:** The local name translated to.

### ManageTranslator(NameTranslator^)
Passes ownership of the memory for a translator elsewhere, to be deleted when the application is closed.

- **`translator`**: The translator to be managed.

**Returns:** true if ownership was successfully transfered, false if the translator is already managed.

### IsTranslatorManaged(NameTranslator^)
Tells whether or not the memory of a translator is being managed.

- **`translator`**: The translator being queried.

**Returns:** true if translator is being managed, false otherwise.
