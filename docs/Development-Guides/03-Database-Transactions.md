# 03 - Database and Transactions

Professional practices for interacting with the AutoCAD database using the `ITransactionService` wrapper.

## The Transaction Wrapper Pattern

To eliminate repetitive boilerplate (DocumentLock, StartTransaction, Commit), use `ITransactionService` from the Infrastructure layer.

### Pattern Comparison

**Legacy Approach (30+ lines):**
```csharp
using (DocumentLock docLock = doc.LockDocument())
{
    using (Transaction tr = db.TransactionManager.StartTransaction())
    {
        // ... open tables ...
        // ... logic ...
        tr.Commit();
    }
}
```

**Wrapper Approach (5 lines):**
```csharp
transactionService.RunInModelSpace((tr, btr) =>
{
    // Logic here. ModelSpace is already open for writing.
});
```

---

## Wrapper Methods

- **`RunInModelSpace`**: Write operations in ModelSpace with document lock and commit.
- **`RunInTransaction`**: General write operations with document lock and commit.
- **`RunReadOnly`**: Read operations without document lock or commit.

---

## Implementation Template

In `src/Civil3dToolkit.Infrastructure/Services/CivilServiceImpl.cs`:

```csharp
public bool DrawMyEntity(double x, double y)
{
    return transactionService.RunInModelSpace((tr, btr) =>
    {
        using Line line = new(new Point3d(x, y, 0), new Point3d(x + 10, y + 10, 0));
        btr.AppendEntity(line);
        tr.AddNewlyCreatedDBObject(line, true);
    });
}
```

---

## Pro Tips

### Error Handling
`TransactionService` logs exceptions to the AutoCAD editor. If your logic throws, the transaction is aborted and the error is logged.

### Unit Testing
By abstracting transactions, your business logic becomes headlessly testable. Mock `ITransactionService` to validate domain behavior without a database connection.

### Batch Operations
For multiple entities, do them all inside a single call to `RunInModelSpace` to avoid repeated locks and commits.
