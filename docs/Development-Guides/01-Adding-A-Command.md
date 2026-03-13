# 01 - Adding a New Command

This guide explains how to add a new command following the current Command Discovery pattern using `ToolkitCommands` and `[ToolkitCommand]`.

## Process Flow

1. **Shared (Contract)**: Add a command constant to `ToolkitCommands`.
2. **Core (Domain)**: Add a new service method if the command changes the database.
3. **Infrastructure or Plugin**: Implement the command class and decorate it with `[ToolkitCommand]`.
4. **Plugin (Composition)**: Register the command in `DiContainer`.
5. **Loader (Proxy)**: Add the AutoCAD command proxy in `MainLoader`.

---

### Step 1: Add the Command Name (Shared)

In `src/Civil3dToolkit.Shared/ToolkitCommands.cs`:

```csharp
public const string DrawCircle = "TK_CIRCLE";
```

---

### Step 2: Update the Domain Interface (Optional)

If your command performs a new type of database action, add it to `src/Civil3dToolkit.Core/Interfaces/ICivilService.cs`:

```csharp
bool DrawCircle(double x, double y, double radius);
```

---

### Step 3: Implement Logic in the Service (Infrastructure)

Implement the method in `src/Civil3dToolkit.Infrastructure/Services/CivilServiceImpl.cs` using the `ITransactionService` wrapper:

```csharp
public bool DrawCircle(double x, double y, double radius)
{
    return transactionService.RunInModelSpace((tr, btr) =>
    {
        using Circle circle = new(new Point3d(x, y, 0), Vector3d.ZAxis, radius);
        btr.AppendEntity(circle);
        tr.AddNewlyCreatedDBObject(circle, true);
    });
}
```

---

### Step 4: Create the Command Class

Create a new class in `src/Civil3dToolkit.Infrastructure/Commands/` (for CAD logic) or `src/Civil3dToolkit.Plugin/Commands/` (for UI-heavy logic).

**File:** `src/Civil3dToolkit.Infrastructure/Commands/DrawCircleCommand.cs`

```csharp
namespace Civil3dToolkit.Infrastructure.Commands;

using Civil3dToolkit.Core.Commands;
using Civil3dToolkit.Core.Interfaces;
using Civil3dToolkit.Shared;

[ToolkitCommand(ToolkitCommands.DrawCircle)]
internal class DrawCircleCommand(IUserInteractionService ui, ICivilService civilService) : IToolkitCommand
{
    public void Execute()
    {
        var pt = ui.GetPoint("Center: ");
        if (pt.Status != InputStatus.Ok) return;

        var radius = ui.GetDouble("Radius: ", 5.0, allowZero: false, allowNegative: false);
        if (radius.Status != InputStatus.Ok) return;

        civilService.DrawCircle(pt.X, pt.Y, radius.Value);
    }
}
```

---

### Step 5: Register in DI Container

In `src/Civil3dToolkit.Plugin/DiContainer.cs`, register your command:

```csharp
services.AddTransient<IToolkitCommand, DrawCircleCommand>();
```

---

### Step 6: Register the Proxy Method (Loader)

In `src/Civil3dToolkit.Loader/MainLoader.cs`:

```csharp
[CommandMethod(ToolkitCommands.DrawCircle)]
public void DrawCircleCommand() => RouteCommandToPlugin(ToolkitCommands.DrawCircle);
```

---

## Benefits

- Command names are centralized in `ToolkitCommands`.
- Clear separation between user interaction, domain logic, and CAD transactions.
