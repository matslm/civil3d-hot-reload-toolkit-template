# 02 - Adding a WPF View (MVVM)

Learn how to create a new window using WPF and bind it to a ViewModel using Dependency Injection and the attribute-based command discovery pattern.

---

### Step 1: Add a Command Name (Shared)

In `src/Civil3dToolkit.Shared/ToolkitCommands.cs`:

```csharp
public const string CircleUi = "TK_CIRCLE_UI";
```

---

### Step 2: Create the ViewModel (Core)

In `src/Civil3dToolkit.Core/ViewModels/`, create `CircleViewModel.cs`:

```csharp
namespace Civil3dToolkit.Core.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class CircleViewModel : ObservableObject
{
    [ObservableProperty]
    private double _radius = 10.0;

    [RelayCommand]
    private void Draw()
    {
        // ViewModel logic goes here
    }
}
```

---

### Step 3: Create the WPF View (Plugin)

In `src/Civil3dToolkit.Plugin/Views/`, create `CircleWindow.xaml`:

```xml
<Window x:Class="Civil3dToolkit.Plugin.Views.CircleWindow"
        Title="Draw Circle" Height="200" Width="300">
    <StackPanel Margin="20">
        <TextBox Text="{Binding Radius}" />
        <Button Command="{Binding DrawCommand}" Content="Draw!" />
    </StackPanel>
</Window>
```

---

### Step 4: Configure Dependency Injection (Plugin)

In `src/Civil3dToolkit.Plugin/DiContainer.cs`:

```csharp
services.AddTransient<CircleViewModel>();
services.AddTransient<CircleWindow>();
```

---

### Step 5: Create the Command Trigger (Plugin)

Create `src/Civil3dToolkit.Plugin/Commands/OpenCircleUiCommand.cs`:

```csharp
namespace Civil3dToolkit.Plugin.Commands;

using Civil3dToolkit.Core.Commands;
using Civil3dToolkit.Plugin.Views;
using Civil3dToolkit.Shared;

[ToolkitCommand(ToolkitCommands.CircleUi)]
internal class OpenCircleUiCommand(IServiceProvider serviceProvider) : IToolkitCommand
{
    public void Execute()
    {
        CircleWindow win = serviceProvider.GetRequiredService<CircleWindow>();
        Application.ShowModalWindow(win);
    }
}
```

---

## Architectural Benefits

- **Separation of Concerns**: The View knows nothing about the CAD database.
- **Dependency Injection**: ViewModels are injected into Views via constructor injection.
- **Headless Testing**: You can test `CircleViewModel` in the Tests project without launching Civil 3D.
