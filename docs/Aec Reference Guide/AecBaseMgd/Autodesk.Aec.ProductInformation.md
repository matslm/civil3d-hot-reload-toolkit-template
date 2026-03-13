---
title: Autodesk.Aec.ProductInformation
hierarchy: AecBaseMgd > Autodesk > Aec > ProductInformation
---

# Autodesk.Aec.ProductInformation

## Summary
The Product Information module contains miscellaneous constants.

## Fields

### VersionId
Version Id of the product.

### VersionIdAsDouble
Version Id of the product (double format).  Note that the data here is stored as a double, so a version of 6.0 would be stored as the value 6 (not always correct, since it may really be 6.0). If you want to true version (ie. for the registry, consider the VersionIdAsString API.

### VersionIdAsString
Version Id of the product (string format). This version is useful for registry versioning since you may want "6.0" instead of just 6 as VersionIdAsDouble provides.

### ObjectMajor
Major version number for objects.

### ObjectMinor
Minor version number for objects.

### AutoCADVersion
AutoCAD version number for this release.
