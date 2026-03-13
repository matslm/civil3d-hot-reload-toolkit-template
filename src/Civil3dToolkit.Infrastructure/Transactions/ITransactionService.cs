namespace Civil3dToolkit.Infrastructure.Transactions;

/// <summary>
/// Abstracts the repetitive AutoCAD Transaction and DocumentLock boilerplate.
/// </summary>
public interface ITransactionService
{
    /// <summary>
    /// Executes an action within a locked document and an open transaction.
    /// Automatically opens the Model Space block table record for writing and commits the transaction upon success.
    /// </summary>
    bool RunInModelSpace(Action<Transaction, BlockTableRecord> action);

    /// <summary>
    /// Executes a general action within a write transaction.
    /// Handles document locking and transaction committing automatically.
    /// </summary>
    bool RunInTransaction(Action<Transaction, Database> action);

    /// <summary>
    /// Executes an action within a read-only transaction.
    /// No document locking is performed.
    /// </summary>
    bool RunReadOnly(Action<Transaction, Database> action);
}
