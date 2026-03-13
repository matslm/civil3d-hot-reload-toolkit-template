---
title: "Use Transactions With the Transaction Manager (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-12ADA0F2-C44D-4D88-B248-1803D39DF3AA.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Open and Close Objects (.NET)", "Use Transactions With the Transaction Manager (.NET)"]
---

# Use Transactions With the Transaction Manager (.NET)

Transactions are used to group multiple operations on multiple objects together as a single operation. Transactions are started and managed through the Transaction Manager. Once a transaction is started, you can then use the `GetObject` function to open an object.

As you work with objects opened with `GetObject`, the Transaction manager keeps track of the changes that are being made to the object. Any new objects that you create and add to the database should be added to a transaction as well with the `AddNewlyCreatedDBObject` function. Once the objects have been edited or added to the database, you can save the changes made to the database and close all the open objects with the `Commit` function on the Transaction object created with the Transaction Manager. Once you are finished with a transaction, call the `Dispose` function close the transaction.

**Parent topic:** [Open and Close Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-774B7F11-E374-450B-9E2E-CAE02F4AADFE.htm)

#### Related Concepts

* [Open and Close Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-774B7F11-E374-450B-9E2E-CAE02F4AADFE.htm)
* [Use Transactions to Access and Create Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-50FD6118-B2D1-4313-A7D6-830794DFDEFA.htm)
* [Commit and Rollback Changes (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C3DE4301-EAC3-4745-A434-9F28EE87AB73.htm)
* [Nest Transactions (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-8D8B9EE8-9D85-4C29-93A0-0BDC90F66EA7.htm)
* [About Using the Dynamic Language Runtime (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F2A96EC2-B693-498E-8425-258A0CE3653F.htm "The AutoCAD Managed .NET API allows you to utilize the Dynamic Language Runtime (DLR) that was introduced with .NET 4.0.")
* [Dispose Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-9DFB5767-F8D6-4A88-87D6-9676C0189369.htm)