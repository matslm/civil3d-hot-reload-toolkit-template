---
title: "Open and Close Objects (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-774B7F11-E374-450B-9E2E-CAE02F4AADFE.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Create and Edit AutoCAD Entities (.NET)", "Open and Close Objects (.NET)"]
---

# Open and Close Objects (.NET)

Whether you are working with objects such as lines, circles and polyline or a symbol table and its records, you need to open the object for read or write. When querying an object you want to open the object for read, but if you are going to make changes to the object you will want to open it for write.

**Parent topic:** [Create and Edit AutoCAD Entities (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F5601807-2FA9-486F-A212-E693D452D81F.htm)

#### Related Concepts

* [Create and Edit AutoCAD Entities (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F5601807-2FA9-486F-A212-E693D452D81F.htm)
* [Work With ObjectIds (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-8D56532D-2B17-48D1-8C81-B4AD89603A1C.htm)
* [Use Transactions With the Transaction Manager (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-12ADA0F2-C44D-4D88-B248-1803D39DF3AA.htm)
* [Open and Close Objects Without the Transaction Manager (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-BF06F786-DDA6-4603-B5E5-25A35A4130A3.htm)
* [Upgrade and Downgrade Open Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-CC5CC229-B122-4897-A8DA-5C5ADADB0F38.htm "An object's current open mode can be changed from read to write or write to read by upgrading or downgrading the object.")
* [About Using the Dynamic Language Runtime (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-F2A96EC2-B693-498E-8425-258A0CE3653F.htm "The AutoCAD Managed .NET API allows you to utilize the Dynamic Language Runtime (DLR) that was introduced with .NET 4.0.")
* [Dispose Objects (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-9DFB5767-F8D6-4A88-87D6-9676C0189369.htm)