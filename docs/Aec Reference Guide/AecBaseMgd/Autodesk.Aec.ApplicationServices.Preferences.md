---
title: Autodesk.Aec.ApplicationServices.Preferences
hierarchy: AecBaseMgd > Autodesk > Aec > ApplicationServices > Preferences
---

# Autodesk.Aec.ApplicationServices.Preferences

## Summary
Represents a class that contains static methods to access preferences of AEC Editor.

## Properties

### ObjectRelationshipGraphDiagnostics
Gets or sets whether the object relationship graph diagnostics is enabled.

**Returns:** Boolean value indicates whether object relationship graph diagnostics is enabled.

### DisplayEnhancedReferenceObjectRelationshipGraphMessages
Gets or sets whether the enhanced reference object relationship graph messages are displayed.

**Returns:** Boolean value indicates whether the enhanced reference object relationship graph messages are displayed.

### QuickOsnapMode
Gets or sets whether the quick osnap mode is enabled.

**Returns:** Boolean value indicates whether the quick osnap mode is enabled.

### ApplyCommonProperties
Gets or sets whether the common properties are applied.

**Returns:** Boolean value indicates whether the common properties are applied.

### ViewManagementSystemDiagnostics
Gets or sets whether the view management system diagnostics is enabled.

**Returns:** Boolean value indicates whether the view management system diagnostics is enabled.

### GeometryDiagnostics
Gets or sets whether the geometry diagnostics is enabled.

**Returns:** Boolean value indicates whether the geometry diagnostics is enabled.

### MaintainExplodedObjectBlockProperties
Gets or sets whether the exploded object block properties are maintained.

**Returns:** Boolean value indicates whether the exploded object block properties are maintained.

### LegacyDrawingUnitMode
Gets the legacy drawing unit mode.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** The legacy drawing unit mode.

### DraftWarningSymbol
Gets or sets whether the draft warning symbol is enabled.

**Returns:** Boolean value indicates whether the draft warning symbol is enabled.

### PlotOrPublishWarningSymbol
Gets or sets whether the plot or publish warning symbol is enabled.

**Returns:** Boolean value indicates whether the plot or publish warning symbol is enabled.

### ExportExplodedToAcadFilePrefix
Gets or sets the filename prefix which is used when exporting exploded entities to AutoCAD.

### ExportExplodedToAcadFileSuffix
Gets the filename suffix which is used when exporting exploded entities to AutoCAD.

- **`suffix`**: The filename suffix which is used when exporting exploded entities to AutoCAD.
- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

### ExportExplodedToAcadBindXrefs
Gets or sets whether the external references are binded when exporting exploded entities to AutoCAD.

**Returns:** Boolean value indicates whether the external references are binded when exporting exploded entities to AutoCAD.

### ExportExplodedToAcadInsertWhenBinding
Gets or sets whether the Insert method is used to bind the external references when exporting exploded entities to AutoCAD.

**Returns:** Boolean value indicates whether the Insert method is used to bind the external references when exporting exploded entities to AutoCAD.

### ExportExplodedToAcadExportFormat
Gets the drawing version which is used when exporting exploded entities to AutoCAD.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** The drawing version which is used when exporting exploded entities to AutoCAD.

### AllowSnapToSurfaceHatch
Gets or sets whether snapping to surface hatch is allowed.

**Returns:** Boolean value indicates whether snapping to surface hatch is allowed.

### DisableOsnapGsMarkerOptimization
Gets or sets whether the osnap gs marker optmization is disabled.

**Returns:** Boolean value indicates whether the osnap gs marker optmization is disabled.

### EnableProgressiveUpdate
Gets or sets whether the progressive update function is enabled in the registry table.

**Returns:** Boolean value indicates whether the progressive update function is enabled.

## Methods

### GetObjectRelationshipGraphDiagnostics(System.Boolean)
Gets whether the object relationship graph diagnostics is enabled.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** Boolean value indicates whether object relationship graph diagnostics is enabled.

### SetObjectRelationshipGraphDiagnostics(System.Boolean,System.Boolean,System.Boolean)
Sets whether the object relationship graph diagnostics is enabled.

- **`enabled`**: Boolean value indicates whether object relationship graph diagnostics is enabled.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetDisplayEnhancedReferenceObjectRelationshipGraphMessages(System.Boolean)
Gets whether the enhanced reference object relationship graph messages are displayed.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** Boolean value indicates whether the enhanced reference object relationship graph messages are displayed.

### SetDisplayEnhancedReferenceObjectRelationshipGraphMessages(System.Boolean,System.Boolean,System.Boolean)
Sets whether the enhanced reference object relationship graph messages are displayed.

- **`enabled`**: Boolean value indicates whether the enhanced reference object relationship graph messages are displayed.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetQuickOsnapMode(System.Boolean)
Gets whether the quick osnap mode is enabled.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** Boolean value indicates whether the quick osnap mode is enabled.

### SetQuickOsnapMode(System.Boolean,System.Boolean,System.Boolean)
Sets whether the quick osnap mode is enabled.

- **`enabled`**: Boolean value indicates whether the quick osnap mode is enabled.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetApplyCommonProperties(System.Boolean)
Gets whether the common properties are applied.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** Boolean value indicates whether the common properties are applied.

### SetApplyCommonProperties(System.Boolean,System.Boolean,System.Boolean)
Sets whether the common properties are applied.

- **`enabled`**: Boolean value indicates whether the common properties are applied.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetViewManagementSystemDiagnostics(System.Boolean)
Gets whether the view management system diagnostics is enabled.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** Boolean value indicates whether the view management system diagnostics is enabled.

### SetViewManagementSystemDiagnostics(System.Boolean,System.Boolean,System.Boolean)
Sets whether the view management system diagnostics is enabled.

- **`enabled`**: Boolean value indicates whether the view management system diagnostics is enabled.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetGeometryDiagnostics(System.Boolean)
Gets whether the geometry diagnostics is enabled.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** Boolean value indicates whether the geometry diagnostics is enabled.

### SetGeometryDiagnostics(System.Boolean,System.Boolean,System.Boolean)
Sets whether the geometry diagnostics is enabled.

- **`enabled`**: Boolean value indicates whether the geometry diagnostics is enabled.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetMaintainExplodedObjectBlockProperties(System.Boolean)
Gets whether the exploded object block properties are maintained.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** Boolean value indicates whether the exploded object block properties are maintained.

### SetMaintainExplodedObjectBlockProperties(System.Boolean,System.Boolean,System.Boolean)
Sets whether the exploded object block properties are maintained.

- **`enabled`**: Boolean value indicates whether the exploded object block properties are maintained.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetLegacyDrawingUnitMode(System.Boolean)
Gets the legacy drawing unit mode.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** The legacy drawing unit mode.

### SetLegacyDrawingUnitMode(Autodesk.Aec.ApplicationServices.LegacyDrawingUnitMode,System.Boolean,System.Boolean)
Sets the legacy drawing unit mode.

- **`mode`**: The legacy drawing unit mode.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetDraftWarningSymbol(System.Boolean)
Gets whether the draft warning symbol is enabled. Draft warning symbol is now defect marker in AutoCAD Architecture and disconnect marker in AutoCAD MEP.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** Boolean value indicates whether the draft warning symbol is enabled.

### SetDraftWarningSymbol(System.Boolean,System.Boolean,System.Boolean)
Sets whether the draft warning symbol is enabled. Draft warning symbol is now defect marker in AutoCAD Architecture and disconnect marker in AutoCAD MEP.

- **`enabled`**: Boolean value indicates whether the draft warning symbol is enabled.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetPlotOrPublishWarningSymbol(System.Boolean)
Gets whether the plot or publish warning symbol is enabled.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** Boolean value indicates whether the plot or publish warning symbol is enabled.

### SetPlotOrPublishWarningSymbol(System.Boolean,System.Boolean,System.Boolean)
Sets whether the plot or publish warning symbol is enabled.

- **`enabled`**: Boolean value indicates whether the plot or publish warning symbol is enabled.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetExportExplodedToAcadFilePrefix(System.Boolean)
Gets the filename prefix which is used when exporting exploded entities to AutoCAD.

- **`prefix`**: The filename prefix which is used when exporting exploded entities to AutoCAD.
- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

### SetExportExplodedToAcadFilePrefix(System.String,System.Boolean,System.Boolean)
Sets the filename prefix which is used when exporting exploded entities to AutoCAD.

- **`prefix`**: The filename prefix which is used when exporting exploded entities to AutoCAD.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetExportExplodedToAcadFileSuffix(System.Boolean)
Gets the filename suffix which is used when exporting exploded entities to AutoCAD.

- **`suffix`**: The filename suffix which is used when exporting exploded entities to AutoCAD.
- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

### SetExportExplodedToAcadFileSuffix(System.String,System.Boolean,System.Boolean)
Sets the filename suffix which is used when exporting exploded entities to AutoCAD.

- **`suffix`**: The filename suffix which is used when exporting exploded entities to AutoCAD.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetExportExplodedToAcadBindXrefs(System.Boolean)
Gets whether the external references are binded when exporting exploded entities to AutoCAD.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** Boolean value indicates whether the external references are binded when exporting exploded entities to AutoCAD.

### SetExportExplodedToAcadBindXrefs(System.Boolean,System.Boolean,System.Boolean)
Sets whether the external references are binded when exporting exploded entities to AutoCAD.

- **`enabled`**: Boolean value indicates whether the external references are binded when exporting exploded entities to AutoCAD.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetExportExplodedToAcadInsertWhenBinding(System.Boolean)
Gets whether the Insert method is used to bind the external references when exporting exploded entities to AutoCAD.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** Boolean value indicates whether the Insert method is used to bind the external references when exporting exploded entities to AutoCAD.

### SetExportExplodedToAcadInsertWhenBinding(System.Boolean,System.Boolean,System.Boolean)
Sets whether the Insert method is used to bind the external references when exporting exploded entities to AutoCAD.

- **`enabled`**: Boolean value indicates whether the Insert method is used to bind the external references when exporting exploded entities to AutoCAD.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetExportExplodedToAcadExportFormat(System.Boolean)
Gets the drawing version which is used when exporting exploded entities to AutoCAD.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** The drawing version which is used when exporting exploded entities to AutoCAD.

### SetExportExplodedToAcadExportFormat(Autodesk.AutoCAD.DatabaseServices.DwgVersion,System.Boolean,System.Boolean)
Sets the drawing version which is used when exporting exploded entities to AutoCAD.

- **`dwgFormat`**: The drawing version which is used when exporting exploded entities to AutoCAD.
- **`updateVariable`**: Boolean value indicates whether to update the runtime variable.
- **`updateRegistry`**: Boolean value indicates whether to update the registry.

### GetEnableProgressiveUpdate(System.Boolean)
Gets whether the progressive update function is enabled.

- **`fromRegistry`**: Boolean value indicates whether to get the value from registry or the runtime variable.

**Returns:** Boolean value indicates whether the progressive update function is enabled.

### SetEnableProgressiveUpdate(System.Boolean,System.Boolean,System.Boolean)
Sets whether the progressive update function is enabled.

- **`enabled`**: Boolean value indicates whether the progressive update function is enabled.
- **`updateVar`**: Boolean value indicates whether to update the runtime variable.
- **`updateReg`**: Boolean value indicates whether to update the registry.
