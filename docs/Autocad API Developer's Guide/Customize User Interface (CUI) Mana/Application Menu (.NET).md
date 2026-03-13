---
title: "Application Menu (.NET)"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-671A4182-8769-446C-A050-3A6CC18277FB.htm"
hierarchy: ["ObjectARX and Managed .NET", "ObjectARX: Managed .NET Developer's Guide", "Customize User Interface (CUI) Managed API (.NET)", "Application Menu (.NET)"]
---

# Application Menu (.NET)

You can customize and add menu items to the application menu by modifying the Windows Registry settings to suit your development requirements.

The contents of the application button is loaded from a .xaml file. You can locate the file in the registry:

```
[HKEY_LOCAL_MACHINE\software\Autodesk\AutoCAD\R25.1\ACAD-9101\Variables\APPFRAMERESOURCES]
```

The default location for the file is
*"pack://application:,,,/AcWindows;component/AppFrame/AcAppFrame.xaml"*.

The application menu can be extended using the registry. The registry keys are read and the menu items specified get added.

Note: The application menu does not have a Customer User Interface (CUI) API to manage and modify its items.

The following code sample illustrates how to add two menu items (a menu and a submenu) to your AppMenu. The Menu item appears as
**Vaac** and the submenu as
**VaacCheckIn**. The custom menu item
**Vaac** gets inserted after the Publish menu item and
**VaacCheckIn** is a submenu item inside the parent menu. You can set the menu item names in the text entry field, which can also point to a localized resource DLL. For example,
`Text="menuitem"` or
`Text="xyz.dll,104"`.

```
/* Determines ApplicationMenuItem.Id of the newly created item. */
[HKEY_CURRENT_USER\<ProductRegRoot>\Profiles\<CurrentProfile>ApplicationMenu\vaacMenu]
/* Determines where the new item will be inserted. Supported values are InsertBefore and InsertAfter.
   AcPublish is the Id of an existing item.*/
"InsertBefore"="AcPublish"
/* ApplicationMenuItem.LargeImage is initialized with this value*/
"Image"="pack://.."
/* Determines whether you want to insert a separator after the item. This is optional. 
   Supported values are "After" and "Before". */
"Separator"="After"
/* ApplicationMenuItem.Text is initialized with this value. The value can be literal string
   (which need to be localized) or reference to managed or unmanaged resource string. */
"Text"="vaacres.dll,101"
/* ApplicationMenuItem.CommandParameter is initialized with this value. This is optional. 
   If it is not specified then this menu must have submenus. If Command is not specified 
   and there are no subkeys then we should not create an ApplicationMenuItem. If both 
   Command and subkeys are present then we should create an ApplicationMenuItem with the 
   IsSplit property set to "true". */
"Command"="_vaacManager"
/* Nesting implies that this menu item is a submenu. */
[HKEY_CURRENT_USER\<ProductRegRoot> \Profiles\<CurrentProfile>\Application Menu\vaacMenu\vaacCheckIn]
"Image"="pack://.."
"Text"="vaacres.dll,102"
"Command"="_vaacCheckIn"
```

**Parent topic:** [Customize User Interface (CUI) Managed API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-71554E76-8FD5-4853-82CD-3587764CBCAC.htm "Many of the user interface elements can be customized in the AutoCAD program with the Customize User Interface (CUI) dialog box or CUI managed API.")

#### Related Concepts

* [CUI Elements (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-311320E4-6829-4799-A5B0-9425C157A8FD.htm "Many user interface elements share a number of properties in common with each other that describe .")
* [Menu Macros (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-C75BC92C-0784-44B7-9D5C-62D5A74B2333.htm "Menu macros define the command sequences to be passed to the AutoCAD Command prompt when a user interface element is clicked.")
* [Customization Sections (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-269300ED-3423-4FF2-9642-ECCB2C627752.htm "The user interface and workspace data of a CUIx file can be accessed using the CUI managed API.")
* [Customize User Interface (CUI) Managed API (.NET)](https://help.autodesk.com/cloudhelp/2026/ENU/OARX-DevGuide-Managed/files/GUID-71554E76-8FD5-4853-82CD-3587764CBCAC.htm "Many of the user interface elements can be customized in the AutoCAD program with the Customize User Interface (CUI) dialog box or CUI managed API.")