# 01 - Adding a New Command

This guide explains how to add a new command to the toolkit following the **Command Discovery Pattern**.

## Process Flow

1. **Loader (Permanent Layer)**: Define the AutoCAD command proxy.
2. **Infrastructure (API Layer)**: Implement high-level logic in a Service (if reusable) and create a discrete Command class.
3. **Core (Domain Layer)**: Abstract the logic into an interface if it involves database operations.
4. **Plugin (Composition Layer)**: Register the new Command in the DI container.

---

### Step 1: Update the Domain Interface (Optional)

If your command performs a new type of database action, add it to `src/Civil3dToolkit.Core/Interfaces/ICivilService.cs`:

```csharp
bool DrawCircle(double x, double y, double radius);
```

### Step 2: Implement Logic in Service

Implement the method in `src/Civil3dToolkit.Infrastructure/Services/CivilServiceImpl.cs` using the `ITransactionService`:

```csharp
public bool DrawCircle(double x, double y, double radius)
{
    return _transactionService.RunInModelSpace((tr, btr) =>
    {
        using (var circle = new Circle(new Point3d(x, y, 0), Vector3d.ZAxis, radius))
        {
            btr.AppendEntity(circle);
            tr.AddNewlyCreatedDBObject(circle, true);
        }
    });
}
```

### Step 3: Create the Command Class

Create a new class in `src/Civil3dToolkit.Infrastructure/Commands/` (for CAD logic) or `src/Civil3dToolkit.Plugin/Commands/` (for UI-heavy logic).

**File:** `src/Civil3dToolkit.Infrastructure/Commands/DrawCircleCommand.cs`

```csharp
public class DrawCircleCommand : IToolkitCommand
{
    private readonly ICivilService _service;
    private readonly IUserInteractionService _ui;

    public string CommandName => "TK_CIRCLE"; // Matches Loader [CommandMethod]

    public DrawCircleCommand(ICivilService service, IUserInteractionService ui)
    {
        _service = service;
        _ui = ui;
    }

    public void Execute()
    {
        var pt = _ui.GetPoint("Center: ");
        if (!pt.Success) return;
        
        _service.DrawCircle(pt.X, pt.Y, 10.0);
    }
}
```

### Step 4: Register in DI Container

In `src/Civil3dToolkit.Plugin/DiContainer.cs`, register your command:

```csharp
// 2. Register Plugin Commands
services.AddTransient<IToolkitCommand, DrawCircleCommand>();
```

### Step 5: Register the Proxy Method (Loader)

In `src/Civil3dToolkit.Loader/MainLoader.cs`:

```csharp
[CommandMethod("TK_CIRCLE")]
public void CommandCircle() => RouteCommandToPlugin("TK_CIRCLE");
```

---

## ✅ Benefits
- **Zero modification** to `PluginEntry.cs` required.
- **Single Responsibility**: The command handles the user interaction; the service handles the database.
- **Extensible**: Just add a class and register it.
