# Project Guidelines: Autodesk Civil 3D & AutoCAD Plugin Development

You are an expert C# / VB.NET developer specializing in Autodesk Civil 3D and AutoCAD plugins. You do not have the complete, up-to-date APIs memorized. You MUST consult the local documentation before writing code or explaining concepts.

# Civil3dToolkit

A modular and hot-reloadable plugin for Autodesk Civil 3D 2026, built with .NET 8.0-windows and WPF.

## Project Overview

Civil3dToolkit is a professional template for extending Autodesk Civil 3D. It employs a **Loader Proxy pattern** and **Clean Architecture** to allow for "hot-reloading" of core plugin logic without requiring a restart of the host application (Civil 3D).

### Architecture

The solution follows a decoupled architecture split into five primary projects:

1.  **Civil3dToolkit.Loader**:
    *   **Purpose**: Acts as a permanent proxy inside Civil 3D.
    *   **Responsibilities**: Registers AutoCAD commands, manages the `AssemblyLoadContext`, and routes execution to the plugin via the stable `IPluginBootstrapper` interface.
2.  **Civil3dToolkit.Shared**:
    *   **Purpose**: Contract library for cross-context communication.
    *   **Responsibilities**: Contains the `IPluginBootstrapper` interface used by both the Loader and the Plugin.
3.  **Civil3dToolkit.Core**:
    *   **Purpose**: The Domain layer.
    *   **Responsibilities**: Pure C# business logic, interfaces (`ICivilService`, `IUserInteractionService`, `IToolkitCommand`), and ViewModels. **Strictly NO Autodesk references here.**
4.  **Civil3dToolkit.Infrastructure**:
    *   **Purpose**: The Infrastructure layer.
    *   **Responsibilities**: Implements Core interfaces using Autodesk SDKs. Contains `TransactionService` to wrap AutoCAD database operations and CAD-dependent `IToolkitCommand` implementations.
5.  **Civil3dToolkit.Plugin**:
    *   **Purpose**: The Presentation layer (Composition Root).
    *   **Responsibilities**: WPF Views, DI container configuration (`DiContainer.cs`), and UI-dependent `IToolkitCommand` implementations.

## Modern C# Style & Standards

To maintain the professional integrity of the template, follow these standards:

1.  **Nullable Reference Types**: Always keep `<Nullable>enable</Nullable>`. Use `?` for optional references and handle nulls explicitly (e.g., using `ArgumentNullException.ThrowIfNull`).
2.  **Primary Constructors**: Prefer Primary Constructors for classes with injected dependencies (e.g., `public class MyService(IOtherService service)`).
3.  **File-Scoped Namespaces**: Use the `namespace MyNamespace;` syntax at the top of all files.
4.  **Encapsulation**: Mark implementation classes as `internal`. Use `[assembly: InternalsVisibleTo("Civil3dToolkit.Plugin")]` in `AssemblyInfo.cs` to allow DI registration.
5.  **Global Usings**: Keep common namespaces in `GlobalUsings.cs` to reduce noise at the top of logic files.
6.  **Using Declarations**: Prefer `using var x = ...;` over `using (var x = ...) { }` blocks to reduce nesting, provided the disposal timing is appropriate for AutoCAD transactions.
7.  **Fully Qualified Usings**: When adding a manual `using`, provide the full path (e.g., `using Civil3dToolkit.Core.Interfaces;`) rather than relative paths to aid searchability and clarity.
8. **Collection Expressions**: Prefer C# 12 collection expressions (`[]`) over `new List<T>()`, `new T[]`, or `Array.Empty<T>()` to initialize arrays, lists, and spans concisely (e.g., `int[] numbers = [1, 2, 3];` or `List<string> emptyList = [];`).
9. **Target-Typed `new**`: Use target-typed `new()` when the type is explicitly stated on the left side of the assignment, in field declarations, or in object initializers to reduce redundancy (e.g., `Dictionary<string, int> map = new();`).
10. **Records & Immutability**: Use `record` or `record struct` for Data Transfer Objects (DTOs), configurations, and models that primarily encapsulate data. Prefer immutable state using `init` properties.
11. **Required Members**: Use the `required` modifier for properties that must be set during object initialization, removing the need for boilerplate constructor assignments for DTOs and models (e.g., `public required string Name { get; init; }`).
12. **Pattern Matching & Switch Expressions**: Prefer `switch` expressions over traditional `switch` statements when returning or assigning values. Leverage pattern matching (property patterns, list patterns, tuple patterns, and relational patterns) to write declarative and readable logic (e.g., `var status = code switch { 1 => "Ok", _ => "Unknown" };`).
13. **Raw String Literals**: Use raw string literals (`"""..."""`) for multi-line text, JSON, XML, or SQL queries. This avoids the need to escape quotation marks and keeps indentation clean.
14. **Modern LINQ Methods**: Utilize the latest LINQ extensions available in .NET. Prefer `.MinBy(x => x.Val)` and `.MaxBy(x => x.Val)` over sorting and taking the first element. Use `.Order()` or `.OrderDescending()` for simple types instead of `.OrderBy(x => x)`.
15. **Use `Any()` over `Count**`: When checking if a collection has elements, prefer `.Any()` instead of `.Count > 0` or `.Length > 0`, as it is safer for `IEnumerable` and better conveys intent.
16. **Avoid String Concatenation**: Always prefer String Interpolation (`$"{var1} {var2}"`) over `string.Format` or the `+` operator for readability.
17.  **Naming & Language**: All code, comments, and UI elements must be in **English**.

## Development Conventions

### Adding a New Command

1.  **Logic (Service)**: If the command modifies the database, add a method to `ICivilService` and implement it in `CivilServiceImpl` using the `ITransactionService` wrapper.
2.  **Command (Orchestrator)**: Create a new class implementing `IToolkitCommand` in either `Infrastructure/Commands` (CAD-heavy) or `Plugin/Commands` (UI-heavy).
3.  **Registration (DI)**: Register the new Command class in `src/Civil3dToolkit.Plugin/DiContainer.cs`.
4.  **Loader (Proxy)**: Add a `[CommandMethod]` in `MainLoader.cs` that calls `RouteCommandToPlugin("TK_YOUR_COMMAND")`.

### UI and MVVM

*   **Views**: Located in `src/Civil3dToolkit.Plugin/Views/`. Built using WPF (XAML). Use constructor injection for ViewModels.
*   **ViewModels**: Located in `src/Civil3dToolkit.Core/ViewModels/`. Use `CommunityToolkit.Mvvm`.
*   **Dependency Injection**: All implementations must be registered in `src/Civil3dToolkit.Plugin/DiContainer.cs`.

### Testing

*   **Unit Tests**: Located in `tests/Civil3dToolkit.Tests/`.
*   Use **Moq** to mock `ICivilService` or `IUserInteractionService` to test ViewModels headlessly.

### Available Commands

*   **`TK_RELOAD`**: Unloads the current plugin and fetches the latest compiled code.
*   **`TK_MAIN_UI`**: Opens the main WPF dashboard interface.
*   **`TK_SQUARE`**: Basic interaction sample (Draws a square).
*   **`TK_CUSTOMBAND`**: Advanced interaction sample (Point loop -> Window -> Grouped MTEXT).

## Active Documentation Sources

### 1. Autodesk Civil 3D API Developer's Guide
*   **Path:** `.\docs\Civil 3d API Developer's Guide`
*   **Description:** Comprehensive markdown documentation on Civil 3D concepts.

### 2. Autocad API Developer's Guide
*   **Path:** `.\docs\Autocad API Developer's Guide`
*   **Description:** Documentation on AutoCAD .NET API (Entities, Transactions, Selection).

### 3. AEC Reference Guide
*   **Path:** `.\docs\Aec Reference Guide`
*   **Description:** Reference on AEC for dealing with AecBaseMgd and AecPropDataMgd.

## Documentation Lookup Mandate
When a task requires knowledge from the sources above, follow these strict steps:
1.  **Search:** Use the `grep_search` or `glob` tools to search the specific documentation directory.
2.  **Read:** Use the `read_file` tool to understand the API methods and C# examples.
3.  **Implement:** Only begin writing code after you have retrieved the relevant context. Do not guess API signatures.
