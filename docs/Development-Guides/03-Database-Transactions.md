# 03 - Database & Transactions

Professional practices for interacting with the AutoCAD Database using the **Transaction Wrapper**.

## The Transaction Wrapper Pattern
To eliminate repetitive boilerplate (LockDocument, StartTransaction, Commit), use the `ITransactionService` found in the Infrastructure layer.

### Pattern Comparison

**Legacy Approach (30+ lines):**
```csharp
using (DocumentLock docLock = doc.LockDocument()) {
    using (Transaction tr = db.TransactionManager.StartTransaction()) {
        // ... open tables ...
        // ... logic ...
        tr.Commit();
    }
}
```

**Professional Approach (5 lines):**
```csharp
_transactionService.RunInModelSpace((tr, btr) => {
    // Logic here. Tables are already open for writing!
});
```

---

### Implementation Template

In `src/Civil3dToolkit.Infrastructure/Services/CivilServiceImpl.cs`:

```csharp
public bool DrawMyEntity(double x, double y)
{
    // The wrapper handles DocumentLock, Transaction start/commit, 
    // and opening ModelSpace automatically.
    return _transactionService.RunInModelSpace((tr, btr) =>
    {
        using (var line = new Line(new Point3d(x, y, 0), new Point3d(x + 10, y + 10, 0)))
        {
            btr.AppendEntity(line);
            tr.AddNewlyCreatedDBObject(line, true);
        }
    });
}
```

---

## 🚀 Pro Tips

### 💡 Error Handling
The `TransactionService` already contains a `try-catch` block that writes errors to the AutoCAD console. If your logic throws an exception, the transaction is aborted automatically, and the error is logged.

### 🧠 Unit Testing
By abstracting transactions into a service, your business logic becomes "headlessly testable." You can mock the `ITransactionService` to verify that your domain logic behaves correctly without actually needing a database connection.

### 📦 Batch Operations
If you are drawing many items, it is more efficient to perform them all inside a **single** call to `RunInModelSpace` to avoid the overhead of multiple locks and commits.
