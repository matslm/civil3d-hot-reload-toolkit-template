namespace Civil3dToolkit.Infrastructure.Services;

using Civil3dToolkit.Core.Interfaces;
using Civil3dToolkit.Infrastructure.Transactions;

/// <summary>
/// Concrete implementation of the ICivilService executing actual AutoCAD transactions.
/// Acts as the Worker library for all CAD-specific logic.
/// </summary>
internal class CivilServiceImpl(ITransactionService transactionService) : ICivilService
{
    public IEnumerable<string> GetDocumentLayers()
    {
        List<string> layers = [];
        transactionService.RunReadOnly((tr, db) =>
        {
            LayerTable lt = (LayerTable)tr.GetObject(db.LayerTableId, OpenMode.ForRead);
            foreach (ObjectId ltrId in lt)
            {
                LayerTableRecord ltr = (LayerTableRecord)tr.GetObject(ltrId, OpenMode.ForRead);
                layers.Add(ltr.Name);
            }
        });
        return layers.OrderBy(l => l);
    }

    public IEnumerable<string> GetDocumentTextStyles()
    {
        List<string> styles = [];
        transactionService.RunReadOnly((tr, db) =>
        {
            TextStyleTable tst = (TextStyleTable)tr.GetObject(db.TextStyleTableId, OpenMode.ForRead);
            foreach (ObjectId tsrId in tst)
            {
                TextStyleTableRecord tsr = (TextStyleTableRecord)tr.GetObject(tsrId, OpenMode.ForRead);
                styles.Add(tsr.Name);
            }
        });
        return styles.OrderBy(s => s);
    }

    public bool DrawSquare(double x, double y, double side)
    {
        return transactionService.RunInModelSpace((tr, btr) =>
        {
            using Polyline acPoly = new();
            acPoly.AddVertexAt(0, new Point2d(x, y), 0, 0, 0);
            acPoly.AddVertexAt(1, new Point2d(x + side, y), 0, 0, 0);
            acPoly.AddVertexAt(2, new Point2d(x + side, y + side), 0, 0, 0);
            acPoly.AddVertexAt(3, new Point2d(x, y + side), 0, 0, 0);
            acPoly.Closed = true;

            btr.AppendEntity(acPoly);
            tr.AddNewlyCreatedDBObject(acPoly, true);
        });
    }

    public bool DrawCustomBandTexts(
        List<(double X, double Y)> midpoints, 
        List<string> texts, 
        string layerName, 
        string textStyleName,
        double textSize, 
        bool useMask)
    {
        return transactionService.RunInModelSpace((tr, btr) =>
        {
            Database db = btr.Database;
            ObjectId styleId = db.Textstyle; 
            TextStyleTable tst = (TextStyleTable)tr.GetObject(db.TextStyleTableId, OpenMode.ForRead);
            if (tst.Has(textStyleName))
            {
                styleId = tst[textStyleName];
            }

            ObjectIdCollection textIds = new();

            for (int i = 0; i < midpoints.Count; i++)
            {
                var pt = midpoints[i];
                string textValue = i < texts.Count ? texts[i] : "-";

                using MText mText = new();
                mText.Location = new Point3d(pt.X, pt.Y, 0);
                mText.Contents = textValue;
                mText.TextHeight = textSize;
                mText.Attachment = AttachmentPoint.MiddleCenter;
                mText.Layer = string.IsNullOrEmpty(layerName) ? "0" : layerName;
                mText.TextStyleId = styleId;
                    
                if (useMask)
                {
                    mText.BackgroundFill = true;
                    mText.UseBackgroundColor = true;
                    mText.BackgroundScaleFactor = 1.2;
                }

                btr.AppendEntity(mText);
                tr.AddNewlyCreatedDBObject(mText, true);
                textIds.Add(mText.ObjectId);
            }

            if (textIds.Count > 1)
            {
                DBDictionary groupDict = (DBDictionary)tr.GetObject(db.GroupDictionaryId, OpenMode.ForWrite);
                string groupName = $"TK_CUSTOMBAND_{Guid.NewGuid().ToString()[..8]}";

                using Group textGroup = new("TK_CUSTOMBAND Group", true);
                textGroup.Append(textIds);
                groupDict.SetAt(groupName, textGroup);
                tr.AddNewlyCreatedDBObject(textGroup, true);
            }
        });
    }
}
