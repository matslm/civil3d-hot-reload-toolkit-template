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

    public bool RunInTransaction(Action<Transaction, Database> action)
    {
        Document? doc = Application.DocumentManager.MdiActiveDocument;
        if (doc == null) return false;

        try
        {
            using (doc.LockDocument())
            {
                using (Transaction tr = doc.Database.TransactionManager.StartTransaction())
                {
                    action(tr, doc.Database);
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

    public bool RunReadOnly(Action<Transaction, Database> action)
    {
        Document? doc = Application.DocumentManager.MdiActiveDocument;
        if (doc == null) return false;

        try
        {
            using (Transaction tr = doc.Database.TransactionManager.StartTransaction())
            {
                action(tr, doc.Database);
                // No commit needed for ReadOnly
            }
            return true;
        }
        catch (Exception ex)
        {
            doc.Editor.WriteMessage($"\n[DATABASE READ ERROR]: {ex.Message}\n");
            return false;
        }
    }
}
