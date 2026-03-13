---
title: "Changing Survey-Specific Ambient Settings"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-8904D5A0-A25B-42C7-9F7A-AA06E1116FC6.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Survey in COM", "Root Objects", "Changing Survey-Specific Ambient Settings"]
---

# Changing Survey-Specific Ambient Settings

Ambient settings for a survey document are held in the `AeccSurveyDocument.Settings` property, an object of type `AeccSurveySettingsRoot`. `AeccSurveySettingsRoot` inherits all the properties of the `AeccSettingsRoot` class from which it is derived. Ambient settings allow you to get and set the units and default property settings of survey objects. This is done through the `AeccSurveySettingsRoot.SurveySettings`, which contains a standard `AeccSettingsAmbient` object.

**Parent topic:** [Root Objects](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-6CAD24C4-43B7-450F-B1E8-3D01DE9FDF39.htm)