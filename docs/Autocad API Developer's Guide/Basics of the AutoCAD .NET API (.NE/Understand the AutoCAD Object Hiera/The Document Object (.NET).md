---
title: "The Document Object (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-A43A20B7-A73A-4BBC-B871-B8E6B9D1006C.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Basics of the AutoCAD .NET API (.NET)", "Understand the AutoCAD Object Hierarchy (.NET)", "The Document Object (.NET)"]
---

# The Document Object (.NET)

The `Document` object, which is actually an AutoCAD drawing, is part of the `DocumentCollection` object. You use the `DocumentExtension` and `DocumentCollectionExtention` objects to create, open, and close drawing files. A `Document` object provides access to the `Database` object which contains all of the graphical and most of the non-graphical AutoCAD objects.

Along with the `Database` object, the `Document` object provides access to the status bar, the window the document is opened in, the `Editor` and `TransactionManager` objects. The `Editor` object provides access to functions used to obtain input from the user in the form of a point or an entered string or numeric value.

The `TransactionManager` object is used to access multiple database objects under a single operation known as a *transaction*. Transactions can be nested, and when you are done with a transaction you can commit or abort the changes made.

![](../images/GUID-E8265C60-AD9F-4C53-97B3-AD4CA4474DFA.png)

**Parent topic:** [Understand the AutoCAD Object Hierarchy (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-7E64FDE7-C818-4566-ADF8-C40D50D91E32.htm)

#### Related Concepts

* [Understand the AutoCAD Object Hierarchy (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-7E64FDE7-C818-4566-ADF8-C40D50D91E32.htm)
* [The Database Object (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-7313ECA1-4875-4946-82E3-C06A4074F807.htm)
* [Prompt for User Input (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-41E19C3B-B40A-41EC-88CB-347B1161B74A.htm)
* [Use Transactions With the Transaction Manager (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-12ADA0F2-C44D-4D88-B248-1803D39DF3AA.htm)