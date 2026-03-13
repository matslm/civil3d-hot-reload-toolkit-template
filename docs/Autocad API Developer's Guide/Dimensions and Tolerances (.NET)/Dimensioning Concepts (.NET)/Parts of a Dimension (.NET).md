---
title: "Parts of a Dimension (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-46E21E76-9FDE-4DE3-9351-EEB683B435F6.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Dimensions and Tolerances (.NET)", "Dimensioning Concepts (.NET)", "Parts of a Dimension (.NET)"]
---

# Parts of a Dimension (.NET)

Dimensions are made up of many different objects, such as lines, text, solid fills and blocks. While each dimension type might appear slightly different from one and another, they do have several parts in common.

![](../images/GUID-54632F71-4FA8-46CE-9283-CEABB9DDC9EA.png)

* **Dimension line.** A line that indicates the direction and extent of a dimension. For an angular dimension, the dimension line is an arc.
* **Extension line.** A line in which extends from the feature being dimensioned to the dimension line. Extension lines are also referred to as projection lines or witness lines.
* **Arrowhead.** A symbol that is used to indicate the ends of the dimension line. Arrowheads are also referred to as symbols of termination or just termination.
* **Dimension text.** A ext string that usually indicates the actual measurement of the distance or andle being measured. The text may also include prefixes, suffixes, and tolerances.
* **Leader.** A solid line leading from some annotation to the referenced feature.

![](../images/GUID-D9A24CCC-E495-4BB3-B8B1-11B6BE85788C.png)

* **Center mark.** A small cross that marks the center of a circle or arc.
* **Centerline.** A set of broken lines that mark the center of a circle or arc.

**Parent topic:** [Dimensioning Concepts (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-65908FEF-D599-42BD-A966-40E4670B7171.htm)

#### Related Concepts

* [Dimensioning Concepts (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-65908FEF-D599-42BD-A966-40E4670B7171.htm)