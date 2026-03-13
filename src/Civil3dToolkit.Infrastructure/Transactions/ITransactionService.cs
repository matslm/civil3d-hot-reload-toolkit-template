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
    /// <param name="action">The logic to execute, providing the Transaction and the ModelSpace BlockTableRecord.</param>
    /// <returns>True if the transaction committed successfully; otherwise, false.</returns>
    bool RunInModelSpace(Action<Transaction, BlockTableRecord> action);
}
