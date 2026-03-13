---
title: "Sharing Styles Between Drawings"
source_url: "https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-5A425429-1737-4661-8F33-2556F4F08549.htm"
hierarchy: ["Developer's Guide", "API Developer's Guide", "Root Objects and Common Concepts", "Label Styles", "Sharing Styles Between Drawings"]
---

# Sharing Styles Between Drawings

Label styles, like all style objects, can be shared between drawings. To do this, call the style’s `ExportTo()` method, targeting the drawing you want to add the style to.

Note:

You can also export collections of styles to another drawing by using the static `StyleBase::ExportTo()` method.

When exporting styles, you specify how conflicts are resolved using the `StyleConflictResolverType` enum. In this example, the first style in the `MajorStationLabelStyles` collection is exported from the active drawing to another open drawing named Drawing1.dwg:

```
[CommandMethod("ExportStyle")]
public void ExportStyle()
{
    CivilDocument doc = CivilApplication.ActiveDocument;
    Document AcadDoc = Application.DocumentManager.MdiActiveDocument;
    Database destDb = null;
    // Find the database for "Drawing 1"
    foreach (Document d in Application.DocumentManager)
    {
        if (d.Name.Equals("Drawing1.dwg")) destDb = d.Database;
    }
    // cancel if no matching drawing:
    if (destDb == null) return;
    using (Transaction ts = AcadDoc.Database.TransactionManager.StartTransaction())
    {
        // Export style:
        ObjectId styleId = doc.Styles.LabelStyles.AlignmentLabelStyles.MajorStationLabelStyles[0];
        LabelStyle oLabelStyle = ts.GetObject(styleId, OpenMode.ForRead) as LabelStyle;
        oLabelStyle.ExportTo(destDb, Autodesk.Civil.StyleConflictResolverType.Rename);
    }
}
```

Note:

In certain situations attempts to abort the transaction will fail when calling `ExportTo()`. This is the case when all the following conditions are all true: multiple styles are being exported, there is a naming conflict between styles, and the `StyleConflictResolverType` is `StyleConflictResolverType.Override`.

**Parent topic:** [Label Styles](https://help.autodesk.com/cloudhelp/2026/ENU/Civil3D-DevGuide/files/GUID-641D7838-292D-43FD-AA50-140B7D9B774F.htm)