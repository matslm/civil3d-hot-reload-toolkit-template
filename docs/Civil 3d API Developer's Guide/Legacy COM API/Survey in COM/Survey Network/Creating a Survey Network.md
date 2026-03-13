---
title: "Creating a Survey Network"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-52A3A7C1-D9BF-4C9E-9F85-A236EC37CF9D.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Survey in COM", "Survey Network", "Creating a Survey Network"]
---

# Creating a Survey Network

Survey networks are created through the `Create` method of the `AeccSurveyProject.Networks` collection.

```
Dim oSurveyNetwork As AeccSurveyNetwork
Set oSurveyNetwork = oSurveyProject.Networks.Create("Net_01")
```

**Parent topic:** [Survey Network](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-4E9D6754-8E47-4A64-B6EE-B0AF4EFB44B0.htm)