---
title: Autodesk.Aec.DatabaseServices.DisplayPropertiesMaterial
hierarchy: AecBaseMgd > Autodesk > Aec > DatabaseServices > DisplayPropertiesMaterial
---

# Autodesk.Aec.DatabaseServices.DisplayPropertiesMaterial

## Summary
Represents a display properties of material.

## Properties

### SurfaceHatch
Gets the surface hatch.

**Returns:** The surface hatch.

### LineworkProperties
Gets the line work properties.

**Returns:** The line work properties.

### BodyProperties
Gets the body properties.

**Returns:** The body properties.

### SectionElevationLineworkProperties
Gets the section elevation line work properties.

**Returns:** The section elevation line work properties.

### PlanHatch
Gets the plane hatch.

**Returns:** The plane hatch.

### SectionHatch
Gets the section hatch.

**Returns:** The section hatch.

### OutsideBodyProperties
Gets the outside body properties.

**Returns:** The outside body properties.

### SectionedBoundaryProperties
Gets the sectioned boundary properties.

**Returns:** The sectioned boundary properties.

### ExcludeFrom2dSectionShrinkwrap
Gets or sets the exclude from 2d section shrink wrap.

**Returns:** The exclude from 2d section shrink wrap.

### MergeCommonMaterials
Gets or sets the merge common materials.

**Returns:** The merge common material.

### KeepAllHiddenLinework
Gets or sets the keep all hidden line work.

**Returns:** The keep all hidden line work.

### SurfaceRenderingMaterialId
Gets or sets the surface rendering material id.

**Returns:** The surface rendering material id.

### SectionRenderingMaterialId
Gets or sets the section rendering material id.

**Returns:** The section rendering material id.

### SectionedBodyRenderingMaterialId
Gets or sets the sectioned body rendering material id.

**Returns:** The sectioned body rendering material id.

### SurfaceRenderMaterialMapping
Gets or sets the surface render material mapping.

**Returns:** The surface render material mapping.

### SurfaceHatchLocationFlags
Gets or sets the surface hatch location flags.

**Returns:** The surface hatch flags.

## Methods

### #ctor
Initializes a new instance of the DisplayPropertiesMaterial class.

### DisplayComponentForDisplayComponentType(Autodesk.Aec.DatabaseServices.ByMaterialDisplayComponentType)
Gets the display component for display component type.

- **`materialDisplayComponentType`**: The material display component type.

### DisplayComponentTypeForDisplayComponent(Autodesk.Aec.DatabaseServices.DisplayComponentEntity)
Gets the display component type for display component.

- **`component`**: The component.

**Returns:** The display component type for display component.

### MaterialDisplayComponentName(Autodesk.Aec.DatabaseServices.DisplayPropertiesMaterial.ByMaterialDisplayComponentType)
Gets the material display component name.

- **`materialDisplayComponentType`**: The material display component type.

**Returns:** The material display component name.

### MaterialComponentType(System.String)
Gets the material component type.

- **`componentName`**: The component name.

**Returns:** The material component type.

### GetDisplayPropertiesForMaterial(Autodesk.AutoCAD.DatabaseServices.ObjectId,Autodesk.AutoCAD.DatabaseServices.ObjectId)
Gets the display properties for material.

- **`materialDisplayRepresentId`**: The material display represent id.
- **`materialId`**: The material id.

**Returns:** The display properties for material.
