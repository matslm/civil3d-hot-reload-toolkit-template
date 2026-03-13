---
title: "Parcel Label Style"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-FA142C65-D7E0-41BC-9060-16DBA8BC3956.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Legacy COM API", "Sites and Parcels in COM", "Parcels", "Parcel Label Style"]
---

# Parcel Label Style

The style of text labels or graphical markers displayed with parcels and parcel segments are set by assigning a label style object to the `AeccParcel.AreaLabelStyle` property. All such label styles are held in the `AeccDocument.ParcelLabelStyles.AreaLabelStyles` property, a collection of `AeccLabelStyle` objects.

Parcel label styles can use the following property fields in the contents of any text component:

| Valid property fields for AeccLabelStyleTextComponent.Contents |
| --- |
| <[Name(CU)]> |
| <[Description(CP)]> |
| <[Parcel Area(Usq\_ft|P2|RN|AP|Sn|OF)]> |
| <[Parcel Number(Sn)]> |
| <[Parcel Perimeter(Uft|P3|RN|AP|Sn|OF)]> |
| <[Parcel Address(CP)]> |
| <[Parcel Site Name(CP)]> |
| <[Parcel Tax ID(Sn)]> |

Label styles are described in detail in the chapter 1 section [Label Styles](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-CB057BA7-7EAE-4915-9B90-8451776C1407.htm).

**Parent topic:** [Parcels](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-78091BA8-63CA-4CF8-95E2-5BA6A8747C82.htm)