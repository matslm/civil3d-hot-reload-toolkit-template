---
title: "To Debug Projects"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-4B65B45B-5C51-4637-ACC5-6E8067C863E6.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", " .NET Core Developer's Guide", "To Debug Projects"]
---

# To Debug Projects

1. In Visual Studio, select Debug ![](../images/ac.menuaro.gif) Attach to Process (or press
   `Ctrl+Alt+P`) to open the Attach to Process dialog box.
2. Select the code types. Choose both if you want to do the mixed debugging.

   ![](../images/GUID-B2A5F4C7-DB29-4A41-A791-9CBF42E4B443.png)

   * Managed(.NET Core, .NET 5+) for .NET Core codes debugging
   * Native - C/C++ for native code debugging

To facilitate your debugging

1. Switch your configuration to Debug.

   ![](../images/GUID-387274FD-68D4-4DF5-B528-6C37F53C2174.png)
2. Add necessary calls in your class so that you can understand the state of your program.

   ```
   Debug.WriteLine("Just a test");
   ```

**Parent topic:** [.NET Core Developer's Guide](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-71F9A52A-9B91-41A1-B542-0B3422B5C2E7.htm)