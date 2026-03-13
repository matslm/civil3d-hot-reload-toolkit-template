namespace Civil3dToolkit.Infrastructure.Transactions;

internal class TransactionService : ITransactionService
{
    public bool RunInModelSpace(Action<Transaction, BlockTableRecord> action)
    {
        Document? doc = Application.DocumentManager.MdiActiveDocument;
        if (doc == null) return false;
        
        Database db = doc.Database;

        try
        {
            using (doc.LockDocument())
            {
                using (Transaction tr = db.TransactionManager.StartTransaction())
                {
                    BlockTable bt = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                    BlockTableRecord btr = (BlockTableRecord)tr.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite);

                    // Execute the specific logic passed in
                    action(tr, btr);

                    tr.Commit();
                }
            }
            return true;
        }
        catch (Exception ex)
        {
            doc.Editor.WriteMessage($"\n[DATABASE ERROR]: {ex.Message}\n");
            return false;
        }
    }
}
