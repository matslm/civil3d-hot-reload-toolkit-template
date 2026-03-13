---
title: "Using Property Fields in Label Style Text"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-286C9C33-15F9-4A5C-9FB3-71C52CAC39CA.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Root Objects and Common Concepts in COM", "Label Styles", "Using Property Fields in Label Style Text"]
---

# Using Property Fields in Label Style Text

Text within a label is designated by the `AeccLabelStyleTextComponent.Contents` property, a string value. Of course, text labels are most useful if they can provide some sort of information that is unique to each particular item being labeled. This is accomplished by specifying property fields within the string. These property fields are of the form “<[*Property name*(*modifier 1*|[..] *modifier n*)]>”. Modifier values are optional and can be in any order. Any number of property fields can be combined with normal text in the Contents property.

In this example, a string component of a label is modified to show design speeds and station values for a point along an alignment:

```
Dim oTextComponent As AeccLabelStyleTextComponent
Set oTextComponent = oLabelStyle.TextComponents.Item(0)
 
oTextComponent.Contents = "SPD=<[Design Speed(P0|RN|AP|Sn)]>"
oTextComponent.Contents = oTextComponent.Contents & _
  "STA=<[Station Value(Uft|FS|P2|RN|AP|Sn|TP|B2|EN|W0|OF)]>"
```

Valid property fields for each element are listed in the appropriate chapter.

**Parent topic:** [Label Styles](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-CB057BA7-7EAE-4915-9B90-8451776C1407.htm)