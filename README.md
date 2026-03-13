# Civil3dToolkit - Enterprise Plugin Template

A professional, modular, and hot-reloadable framework for Autodesk Civil 3D 2026 development, built with .NET 8.0 and WPF.

## Key Features

- **Clean Architecture**: Strict separation between Domain logic (Core), Autodesk APIs (Infrastructure), and UI (Plugin).
- **Command Discovery**: Commands are discovered via `[ToolkitCommand]` and registered through DI (no switch statements).
- **Command Registry**: Centralized command names in `ToolkitCommands` to avoid string drift.
- **Transaction Wrapper**: `ITransactionService` provides `RunInModelSpace`, `RunInTransaction`, and `RunReadOnly`.
- **Hot-Reloading**: Update logic via `TK_RELOAD` without restarting Civil 3D.
- **Unit Testable Core**: ViewModels and services can be tested headlessly using xUnit and Moq.
- **Modern C# Style**: File-scoped namespaces, nullable reference types, primary constructors, and collection expressions.

---

## Architecture Overview

The solution is divided into 5 distinct layers:

| Project | Layer | Responsibility |
| :--- | :--- | :--- |
| **Loader** | Entry Proxy | Permanent AutoCAD resident; handles assembly loading and command routing. |
| **Shared** | Contract | Defines stable interfaces (`IPluginBootstrapper`) and command constants. |
| **Core** | Domain | Pure C#. ViewModels, Interfaces, and Models. No Autodesk or WPF references. |
| **Infrastructure** | Implementation | AutoCAD API implementations, transactions, and CAD-specific commands. |
| **Plugin** | Composition | WPF Views, DI registration, UI services, and UI-triggering commands. |

---

## Getting Started

### Prerequisites
- .NET 8.0 SDK
- Autodesk Civil 3D 2026

### Building
```powershell
dotnet build
```

### Loading into Civil 3D
1. Open Civil 3D 2026.
2. Run `NETLOAD`.
3. Select `bin/Debug/Civil3dToolkit.Loader.dll`.
4. The plugin will auto-initialize. Use `TK_RELOAD` to refresh after a rebuild.

---

## Development Guides

Follow these step-by-step tutorials to extend the toolkit:

1. **[Adding a New Command](./docs/Development-Guides/01-Adding-A-Command.md)**: Using `[ToolkitCommand]` and the command registry.
2. **[Creating a WPF View](./docs/Development-Guides/02-Adding-A-View.md)**: Building windows with MVVM and DI.
3. **[Database & Transactions](./docs/Development-Guides/03-Database-Transactions.md)**: Using the transaction wrapper.

---

## Testing
Run unit tests from the CLI:
```powershell
dotnet test
```
*Note: Only the Core project is testable headlessly. Infrastructure tests require a CAD environment.*

## License
This project is for internal development use.
