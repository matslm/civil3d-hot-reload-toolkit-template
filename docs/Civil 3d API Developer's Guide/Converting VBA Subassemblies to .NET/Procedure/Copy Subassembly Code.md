---
title: "Copy Subassembly Code"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-DBD634F5-94B4-4ACD-89D3-79ACEDE7F1F7.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Converting VBA Subassemblies to .NET", "Procedure", "Copy Subassembly Code"]
---

# Copy Subassembly Code

Copy the original code from the VBA module (\*.bas) to the corresponding place in the new class:

| From | To |
| --- | --- |
| `UserdefinedSA_GetLogicalNames()` | `GetLogicalnamesImplement()` |
| `UserdefinedSA _GetInputParameters()` | `GetInputParametersImplement()` |
| `UserdefinedSA _GetOutputParameters()` | `GetOutputParametersImplement()` |
| `UserdefinedSA()` | `DrawImplement()` |
| Const variables | Member variables section |

**Parent topic:** [Procedure](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-604F90A3-66AD-4EF2-A29B-75047BF4D0B2.htm)